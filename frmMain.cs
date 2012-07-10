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
        }

        private void btnDecompSource_Click(object sender, EventArgs e)
        {
            if (opnDecompSource.ShowDialog() == DialogResult.OK)
                txtDecompSource.Text = opnDecompSource.FileName;
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
            int address;
            if (!Extensions.TryParseHex(txtDecompAddr.Text, out address))
            {
                // Not a valid hex number
                lblStatus.Text = "Not a valid hex number";
                txtDecompAddr.Focus();
                txtDecompAddr.Select();
                return;
            }

            // See if it's in range
            if ((address < 0) || (address >= src.Length))
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
                result = LZ77.Decompress(src, address, out decomp);
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

        private void lblAbout_Click(object sender, EventArgs e)
        {
            string about = "By JeffMan" + Environment.NewLine +
                "jeffman@starmen.net" + Environment.NewLine +
                "";
        }
    }
}
