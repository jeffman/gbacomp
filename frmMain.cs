using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using GBA;

namespace gbacomp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();

            savDecomp.Filter = opnDecompSource.Filter;
            opnCompSource.Filter = opnDecompSource.Filter;
            savComp.Filter = opnDecompSource.Filter;
            opnCompDest.Filter = opnDecompSource.Filter;

            rdoNewFile_CheckedChanged(null, null);
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            string about = "By JeffMan" + Environment.NewLine +
                "https://github.com/jeffman/gbacomp";

            MessageBox.Show(about, "About");
        }

        private void btnDecompSource_Click(object sender, EventArgs e)
        {
            if (opnDecompSource.ShowDialog() == DialogResult.OK)
                txtDecompSource.Text = opnDecompSource.FileName;
        }

        private void btnCompSource_Click(object sender, EventArgs e)
        {
            if (opnCompSource.ShowDialog() == DialogResult.OK)
                txtCompSource.Text = opnCompSource.FileName;
        }

        private void btnCompDest_Click(object sender, EventArgs e)
        {
            if (rdoNewFile.Checked)
            {
                if (savComp.ShowDialog() == DialogResult.OK)
                    txtCompDest.Text = savComp.FileName;
            }
            else if (rdoExistingFile.Checked)
            {
                if (opnCompDest.ShowDialog() == DialogResult.OK)
                    txtCompDest.Text = opnCompDest.FileName;
            }
        }

        private void btnDecomp_Click(object sender, EventArgs e)
        {
            // Check if the file exists
            if (!File.Exists(txtDecompSource.Text))
            {
                lblStatus.Text = "File not found";
                txtDecompSource.Focus();
                txtDecompSource.SelectAll();
                return;
            }

            // Try loading the file
            byte[] src = null;

            try
            {
                src = File.ReadAllBytes(txtDecompSource.Text);
            }
            catch
            {
                // Error loading file
                lblStatus.Text = "Error loading file";
                txtDecompSource.Focus();
                txtDecompSource.SelectAll();
                return;
            }

            // Grab the source address
            int srcAddr;
            if (txtDecompAddr.Text.Equals(string.Empty))
                srcAddr = 0;
            else if (!Extensions.TryParseHex(txtDecompAddr.Text, out srcAddr))
            {
                // Not a valid hex number
                lblStatus.Text = "Not a valid hex number";
                txtDecompAddr.Focus();
                txtDecompAddr.Select();
                return;
            }

            // See if it's in range
            if ((srcAddr < 0) || (srcAddr >= src.Length))
            {
                // Out of range
                lblStatus.Text = "Address out of range";
                txtDecompAddr.Focus();
                txtDecompAddr.Select();
                return;
            }

            // Decomp
            int result = 0;
            byte[] decomp;

            try
            {
                result = LZ77.Decompress(src, srcAddr, out decomp);
            }
            catch
            {
                // Unexpected error, shouldn't happen
                lblStatus.Text = "Unexpected error";
                return;
            }

            // See if it worked
            switch (result)
            {
                case -1:

                    // Missing LZ77 signature
                    lblStatus.Text = "Not a valid compressed block";
                    return;

                default:

                    // Worked
                    lblStatus.Text = "Decompressed " + decomp.Length + " bytes from " +
                        result + " bytes";

                    // Ask for an output file
                    if (savDecomp.ShowDialog() == DialogResult.OK)
                    {
                        // Write the file
                        try
                        {
                            File.WriteAllBytes(savDecomp.FileName, decomp);
                            lblStatus.Text = "File written successfully";
                        }
                        catch
                        {
                            lblStatus.Text = "Error writing to file";
                            return;
                        }
                    }

                    break;
            }
        }

        private void btnCompress_Click(object sender, EventArgs e)
        {
            bool newfile = rdoNewFile.Checked;

            // Check if the source exists
            if (!File.Exists(txtCompSource.Text))
            {
                lblStatus.Text = "File not found";
                txtCompSource.Focus();
                txtCompSource.SelectAll();
                return;
            }

            // Check if the existing dest file exists
            if (!newfile && !File.Exists(txtCompDest.Text))
            {
                lblStatus.Text = "File not found";
                txtCompDest.Focus();
                txtCompDest.SelectAll();
                return;
            }

            // Try loading the files
            byte[] src = null;

            try
            {
                src = File.ReadAllBytes(txtCompSource.Text);
            }
            catch
            {
                // Error loading file
                lblStatus.Text = "Error loading file";
                txtCompSource.Focus();
                txtCompSource.SelectAll();
                return;
            }

            byte[] dest = null;

            if (!newfile)
            {
                try
                {
                    dest = File.ReadAllBytes(txtCompDest.Text);
                }
                catch
                {
                    // Error loading file
                    lblStatus.Text = "Error loading file";
                    txtCompDest.Focus();
                    txtCompDest.SelectAll();
                    return;
                }
            }

            // Grab the destination address
            int destAddr = -1;
            if (dest != null)
            {
                if (txtCompDestAddr.Text.Equals(""))
                    destAddr = 0;

                else if (!Extensions.TryParseHex(txtCompDestAddr.Text, out destAddr))
                {
                    // Not a valid hex number
                    lblStatus.Text = "Not a valid hex number";
                    txtCompDestAddr.Focus();
                    txtCompDestAddr.Select();
                    return;
                }

                // See if it's in range
                if ((destAddr < 0) || (destAddr >= dest.Length))
                {
                    // Out of range
                    lblStatus.Text = "Address out of range";
                    txtCompDestAddr.Focus();
                    txtCompDestAddr.Select();
                    return;
                }
            }

            // Comp
            lblStatus.Text = "Compressing...";
            byte[] comp = LZ77.Compress(src);

            if (!newfile)
            {
                // Insert it into the destination file
                try
                {
                    Array.Copy(comp, 0, dest, destAddr, comp.Length);
                }
                catch
                {
                    lblStatus.Text = "Error copying data to destination";
                    return;
                }
            }
            else
            {
                // Ask for destination file
                dest = comp;
            }

            // Write the destination file
            try
            {
                File.WriteAllBytes(txtCompDest.Text, dest);
            }
            catch
            {
                lblStatus.Text = "Error writing destination file";
                return;
            }

            // Finished
            lblStatus.Text = "Compressed " + src.Length + " bytes to " + comp.Length + " bytes";
        }

        private void rdoNewFile_CheckedChanged(object sender, EventArgs e)
        {
            txtCompDestAddr.Enabled = !rdoNewFile.Checked;
        }
    }
}
