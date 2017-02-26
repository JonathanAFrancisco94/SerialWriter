namespace SerialWriter.FormUI
{
    partial class frmMessageBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.plMid = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.plBottom2 = new System.Windows.Forms.Panel();
            this.mtrBtnOK = new MetroFramework.Controls.MetroButton();
            this.plBottom = new System.Windows.Forms.Panel();
            this.plTop = new System.Windows.Forms.Panel();
            this.plRight = new System.Windows.Forms.Panel();
            this.plLeft = new System.Windows.Forms.Panel();
            this.plTop3 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.plTop2 = new System.Windows.Forms.Panel();
            this.plMid.SuspendLayout();
            this.plBottom2.SuspendLayout();
            this.plTop3.SuspendLayout();
            this.SuspendLayout();
            // 
            // plMid
            // 
            this.plMid.Controls.Add(this.lblDescription);
            this.plMid.Controls.Add(this.plBottom2);
            this.plMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMid.Location = new System.Drawing.Point(33, 82);
            this.plMid.Name = "plMid";
            this.plMid.Size = new System.Drawing.Size(693, 196);
            this.plMid.TabIndex = 14;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(0, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(50, 18);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "label2";
            // 
            // plBottom2
            // 
            this.plBottom2.Controls.Add(this.mtrBtnOK);
            this.plBottom2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom2.Location = new System.Drawing.Point(0, 164);
            this.plBottom2.Name = "plBottom2";
            this.plBottom2.Size = new System.Drawing.Size(693, 32);
            this.plBottom2.TabIndex = 6;
            // 
            // mtrBtnOK
            // 
            this.mtrBtnOK.BackColor = System.Drawing.Color.White;
            this.mtrBtnOK.Dock = System.Windows.Forms.DockStyle.Right;
            this.mtrBtnOK.Location = new System.Drawing.Point(614, 0);
            this.mtrBtnOK.Name = "mtrBtnOK";
            this.mtrBtnOK.Size = new System.Drawing.Size(79, 32);
            this.mtrBtnOK.Style = MetroFramework.MetroColorStyle.Magenta;
            this.mtrBtnOK.TabIndex = 0;
            this.mtrBtnOK.Text = "OK(&O)";
            this.mtrBtnOK.UseCustomBackColor = true;
            this.mtrBtnOK.UseCustomForeColor = true;
            this.mtrBtnOK.UseSelectable = true;
            this.mtrBtnOK.Click += new System.EventHandler(this.mtrBtnOK_Click);
            // 
            // plBottom
            // 
            this.plBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plBottom.Location = new System.Drawing.Point(33, 278);
            this.plBottom.Name = "plBottom";
            this.plBottom.Size = new System.Drawing.Size(693, 22);
            this.plBottom.TabIndex = 11;
            // 
            // plTop
            // 
            this.plTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop.Location = new System.Drawing.Point(33, 60);
            this.plTop.Name = "plTop";
            this.plTop.Size = new System.Drawing.Size(693, 22);
            this.plTop.TabIndex = 10;
            // 
            // plRight
            // 
            this.plRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.plRight.Location = new System.Drawing.Point(726, 60);
            this.plRight.Name = "plRight";
            this.plRight.Size = new System.Drawing.Size(33, 240);
            this.plRight.TabIndex = 9;
            // 
            // plLeft
            // 
            this.plLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.plLeft.Location = new System.Drawing.Point(0, 60);
            this.plLeft.Name = "plLeft";
            this.plLeft.Size = new System.Drawing.Size(33, 240);
            this.plLeft.TabIndex = 8;
            // 
            // plTop3
            // 
            this.plTop3.Controls.Add(this.lblTitle);
            this.plTop3.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop3.Location = new System.Drawing.Point(0, 10);
            this.plTop3.Name = "plTop3";
            this.plTop3.Size = new System.Drawing.Size(759, 50);
            this.plTop3.TabIndex = 13;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(252, 45);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Configuration";
            // 
            // plTop2
            // 
            this.plTop2.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTop2.Location = new System.Drawing.Point(0, 0);
            this.plTop2.Name = "plTop2";
            this.plTop2.Size = new System.Drawing.Size(759, 10);
            this.plTop2.TabIndex = 12;
            // 
            // frmMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(759, 300);
            this.Controls.Add(this.plMid);
            this.Controls.Add(this.plBottom);
            this.Controls.Add(this.plTop);
            this.Controls.Add(this.plRight);
            this.Controls.Add(this.plLeft);
            this.Controls.Add(this.plTop3);
            this.Controls.Add(this.plTop2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMessageBox";
            this.plMid.ResumeLayout(false);
            this.plMid.PerformLayout();
            this.plBottom2.ResumeLayout(false);
            this.plTop3.ResumeLayout(false);
            this.plTop3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plMid;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel plBottom2;
        private MetroFramework.Controls.MetroButton mtrBtnOK;
        private System.Windows.Forms.Panel plBottom;
        private System.Windows.Forms.Panel plTop;
        private System.Windows.Forms.Panel plRight;
        private System.Windows.Forms.Panel plLeft;
        private System.Windows.Forms.Panel plTop3;
        private System.Windows.Forms.Panel plTop2;
        private System.Windows.Forms.Label lblTitle;
    }
}