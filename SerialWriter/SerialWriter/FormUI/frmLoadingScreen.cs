using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SerialWriter.FormUI
{
    public partial class frmLoadingScreen : Form
    {
        Form opener;

        public frmLoadingScreen(Form parentParam)
        {
            InitializeComponent();
            opener = parentParam;
            this.CenterToParent();

        }
        public frmLoadingScreen()
        {
            this.CenterToParent();
            this.TopMost = true;
            InitializeComponent();

        }

        public void CloseLoadingScreen()
        {
            if (this.InvokeRequired == true)
            {
                this.Invoke(new MethodInvoker(CloseLoadingScreen));
            }
            else
            {
                this.Close();
            }
        }

    }
}
