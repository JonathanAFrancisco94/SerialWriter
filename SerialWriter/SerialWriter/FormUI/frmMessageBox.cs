using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialWriter.FormUI
{
    public partial class frmMessageBox : Form
    {
        String _comPort;
        String _filePath;
        private int intX = Screen.PrimaryScreen.Bounds.Width;
        private int intY = Screen.PrimaryScreen.Bounds.Height;
        public frmMessageBox(String comPort, String filePath)
        {
            InitializeComponent();

            this.Height = Convert.ToInt32(intY * 0.4);
            this.Width = intX;
            _comPort = comPort;
            _filePath = filePath;
            lblTitle.Text = "Configuration";
            if (comPort == "")
            {
                _comPort = "No comport selected, Please select COMPORT";
            }

            if (filePath == "")
            {
                _filePath = "No path selected, Please Go to File > Open > Select Files";
            }

            //String _IPAddress = System.Net.IPAddress.IPv6Any;
            this.lblDescription.Text = "PC NAME: " + System.Environment.MachineName + System.Environment.NewLine +
                //"IP: " + _IPAddress + System.Environment.NewLine +
                "COMPORT: " + _comPort + System.Environment.NewLine +
                "FILE PATH: " + _filePath;
        }

        public frmMessageBox(String descriptionAbout)
        {
            InitializeComponent();
            this.Height = Convert.ToInt32(intY * 0.4);
            this.Width = intX;
            lblTitle.Text = "About";
            lblDescription.Text = descriptionAbout;
        }

        private void mtrBtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
