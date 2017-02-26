using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SerialWriter.FormUI;
using System.Threading;
using System.Diagnostics;

using System.Runtime.InteropServices;

namespace SerialWriter
{

    public partial class mtrfrmSerialWriterMain : MetroFramework.Forms.MetroForm
    {
        public String[] _availableComPort;
        public MetroFramework.MetroColorStyle _styleColor;
        public MetroFramework.MetroThemeStyle _themeColor;
        public String _comPort = "";
        public String _filePath = "";
        public Boolean _bolFirstAdd = false;
        public Thread SplashScreenThread;
        public frmLoadingScreen frmLoading = new frmLoadingScreen();
        #region FormLoading/Closing
        public mtrfrmSerialWriterMain()
        {
            InitializeComponent();
            preInitialize();
        }
        public void preInitialize()
        {
            if (File.Exists(Application.StartupPath + "\\Config" + "\\Settings.txt") == true)
            {

                StreamReader readConfig = new StreamReader(Application.StartupPath + "\\Config" + "\\Settings.txt");
                String[] subStrings = readConfig.ReadLine().Split('|');
                String getStyle = Convert.ToString(subStrings.GetValue(0));
                String getTheme = Convert.ToString(subStrings.GetValue(1));
                String getPathFile = Convert.ToString(subStrings.GetValue(2));

                switch (getStyle)
                {
                    case "Blue":
                        blueToolStripMenuItem.PerformClick();
                        break;
                    case "Brown":
                        brownToolStripMenuItem.PerformClick();
                        break;
                    case "Green":
                        greenToolStripMenuItem.PerformClick();
                        break;
                    case "Magenta":
                        magentaToolStripMenuItem.PerformClick();
                        break;
                    case "Orange":
                        orangeToolStripMenuItem.PerformClick();
                        break;
                    case "Red":
                        redToolStripMenuItem.PerformClick();
                        break;
                    case "Pink":
                        pinkToolStripMenuItem.PerformClick();
                        break;
                    case "Teal":
                        tealToolStripMenuItem.PerformClick();
                        break;
                    case "Yellow":
                        yellowToolStripMenuItem.PerformClick();
                        break;
                }

                switch (getTheme)
                {
                    case "Default":
                    case "Light":
                        tSmiLight.PerformClick();
                        break;
                    case "Dark":
                        tSmiDark.PerformClick();
                        break;
                }

                if (getPathFile != "")
                {
                    this._filePath = getPathFile;
                    ThreadJob();
                }

                this.mtrcboComPort.Items.Clear();
                _availableComPort = SerialPort.GetPortNames();
                for (int i = 0; i < _availableComPort.Length; i++)
                {
                    this.mtrcboComPort.Items.Add(_availableComPort[i]);
                }
            }
            else
            {
                this.mtrlblSendResult.Text = String.Empty;
                this.mtrcboComPort.Items.Clear();
                this.lbItemScan.Items.Clear();
                this.colorStyle(_styleColor);
                _availableComPort = SerialPort.GetPortNames();
                for (int i = 0; i < _availableComPort.Length; i++)
                {
                    this.mtrcboComPort.Items.Add(_availableComPort[i]);
                }
            }
        }
        #endregion

        #region RalatedToBarcode
        private bool ReceivedText(string InputText)
        {
            bool bolReturnResult = false;
            String _ReceivedData = InputText;
            try
            {
                if (this.mtrlblSendResult.InvokeRequired)
                {
                    ReceivedText(_ReceivedData);
                }
                else
                {
                    _ReceivedData = _ReceivedData + System.Environment.NewLine;
                    spBarcodeScanner.Write(_ReceivedData);
                    mtrlblSendResult.Text = _ReceivedData.Trim();
                    bolReturnResult = true;
                }
            }
            catch
            {
                bolReturnResult = false;
            }
            return bolReturnResult;
        }
        private void mtrcboComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            spBarcodeScanner.PortName = mtrcboComPort.Text;
            spBarcodeScanner.BaudRate = 9600;
            spBarcodeScanner.Open();
            _comPort = mtrcboComPort.Text;
        }
        #endregion

        #region EventHandler
        private void tSmiOpen_Click(object sender, EventArgs e)
        {
            this.lbItemScan.Items.Clear();
            frmLoading.Close();
            OpenFileDialog openTxtFile = new OpenFileDialog();
            openTxtFile.Filter = "txt file(*.txt)|";
            openTxtFile.FileName = "";
            if (openTxtFile.ShowDialog() == DialogResult.OK)
            {
                this._filePath = openTxtFile.FileName.ToString();
                this.lbItemScan.Items.Clear();
                //this._bolFilePath = true;
                SplashScreenThread = new Thread(ThreadJob);
                SplashScreenThread.Start();
                frmLoading = new frmLoadingScreen();
                frmLoading.StartPosition = FormStartPosition.CenterScreen;
                frmLoading.ShowDialog();
            }
        }
        private void tSmiConfiguration_Click(object sender, EventArgs e)
        {
            frmMessageBox messageBox = new frmMessageBox(_comPort, _filePath);
            messageBox.Show();
        }
        private void lbItemScan_DoubleClick(object sender, EventArgs a)
        {
            try
            {
                if (spBarcodeScanner.IsOpen)
                {
                    String lbSelectedItem = String.Empty;
                    lbSelectedItem = lbItemScan.SelectedItem.ToString();
                    ReceivedText(lbSelectedItem + System.Environment.NewLine);
                }
                else
                {
                    MessageBox.Show("Please check ComPort Connection or use 3rd party software for emulating Scanner port", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void mtrLSend_Click(object sender, EventArgs e)
        {
            if (!spBarcodeScanner.IsOpen)
            {
                MessageBox.Show("Please check ComPort Connection or use 3rd party software for emulating Scanner port", "System Check", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }
            ReceivedText(this.mtrlblSendResult.Text.Trim());
        }
        private void mtrLAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lbItemScan.Items.Add(mtrlblSendResult.Text.Trim());

                using (StreamWriter sw = new StreamWriter(_filePath, true))
                {
                    if (_bolFirstAdd == false)
                    {
                        sw.WriteLine();
                        _bolFirstAdd = false;
                    }
                    sw.WriteLine(mtrlblSendResult.Text.Trim());
                }
            }
            catch
            {

            }
        }
        private void Serial_DataReceived(System.Object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (ReceivedText(spBarcodeScanner.ReadExisting().Trim()) == true)
            {
                spBarcodeScanner.Write(spBarcodeScanner.ReadExisting().Trim());
            }
        }
        private void tSmiNew_Click(object sender, EventArgs a)
        {
            try
            {
                String newFolder = Application.StartupPath + "\\LogSaves";
                String _newFileNameTimeDate = DateTime.Now.ToString("MMddyyyyHHmm");
                String _newFile = newFolder + "\\" + _newFileNameTimeDate;
                _filePath = _newFile + ".txt";

                if (!Directory.Exists(newFolder))
                {
                    Directory.CreateDirectory(newFolder);
                }

                StreamWriter file = new StreamWriter(_filePath);
                file.WriteLine(String.Empty);
                file.Close();
                System.Diagnostics.Process.Start(_filePath);
                Thread.Sleep(10000);
                DialogResult dialogResult = MessageBox.Show("Save your file then Click Yes to Open " + _newFileNameTimeDate, "System Check", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialogResult == DialogResult.Yes)
                {
                    file.Close();
                    file.Dispose();
                    this.tSmiSaveConfig.PerformClick();
                    preInitialize();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void tSmiClear_Click(object sender, EventArgs a)
        {
            preInitialize();
        }
        private void tSmiAbout_Click(object sender, EventArgs e)
        {
            String _descriptionAbout = "";
            _descriptionAbout = "Application Owner : SMART AUTOMATION" + System.Environment.NewLine +
                "Application Name  : SMART SERIAL WRITER" + System.Environment.NewLine +
                "Version and Date  : 2.0v / Dec 1,2016" + System.Environment.NewLine +
                "Contact Person    : icychill29@yahoo.com";
            frmMessageBox messageBox = new frmMessageBox(_descriptionAbout);
            messageBox.Show();
        }
        private void tSmiSaveConfig_Click(object sender, EventArgs e)
        {
            savedConfiguration(_styleColor, _themeColor, _filePath);
        }
        private void tSmiScreenshot_Click(object sender, EventArgs e)
        {
            String newFolder = Application.StartupPath + "\\Screenshot";
            String _newPicNameTimeDate = DateTime.Now.ToString("MMddyyyyHHmmss");
            String _newFile = newFolder + "\\" + _newPicNameTimeDate;

            if (!Directory.Exists(newFolder))
            {
                Directory.CreateDirectory(newFolder);
            }

            Size sz = Screen.PrimaryScreen.Bounds.Size;
            IntPtr hDesk = GetDesktopWindow();
            IntPtr hSrce = GetWindowDC(hDesk);
            IntPtr hDest = CreateCompatibleDC(hSrce);
            IntPtr hBmp = CreateCompatibleBitmap(hSrce, sz.Width, sz.Height);
            IntPtr hOldBmp = SelectObject(hDest, hBmp);
            bool b = BitBlt(hDest, 0, 0, sz.Width, sz.Height, hSrce, 0, 0, CopyPixelOperation.SourceCopy | CopyPixelOperation.CaptureBlt);
            Bitmap bmp = Bitmap.FromHbitmap(hBmp);
            SelectObject(hDest, hOldBmp);
            DeleteObject(hBmp);
            DeleteDC(hDest);
            ReleaseDC(hDesk, hSrce);
            bmp.Save(@_newFile + ".png");
            bmp.Dispose();
            this.mtrlblSendResult.Text = "ScreenCapture " + _newPicNameTimeDate;
        }
        #region ColorStyle
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Blue);
            this._styleColor = MetroFramework.MetroColorStyle.Blue;
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Green);
            _styleColor = MetroFramework.MetroColorStyle.Green;
        }
        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Magenta);
            _styleColor = MetroFramework.MetroColorStyle.Magenta;
        }
        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Orange);
            _styleColor = MetroFramework.MetroColorStyle.Orange;
        }
        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Red);
            _styleColor = MetroFramework.MetroColorStyle.Red;
        }
        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Pink);
            _styleColor = MetroFramework.MetroColorStyle.Pink;
        }
        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Teal);
            _styleColor = MetroFramework.MetroColorStyle.Teal;
        }
        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Yellow);
            _styleColor = MetroFramework.MetroColorStyle.Yellow;
        }
        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.colorStyle(MetroFramework.MetroColorStyle.Brown);
            _styleColor = MetroFramework.MetroColorStyle.Brown;
        }
        private void tSmiLight_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this._themeColor = MetroFramework.MetroThemeStyle.Light;
            this.Refresh();
        }
        private void tSmiDark_Click(object sender, EventArgs e)
        {
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._themeColor = MetroFramework.MetroThemeStyle.Dark;
            this.Refresh();
        }
        #endregion
        #endregion

        #region Util/Helper
        //private void addItem()
        //{
        //    thread

        //}
        private void colorStyle(MetroFramework.MetroColorStyle styleColor)
        {
            MetroFramework.MetroColorStyle s = styleColor;
            this.Style = s;
            this.mtrcboComPort.Style = s;
            this.mtrlblSendResult.Style = s;
            this.mtrlblItems.Style = s;
            this.mtrLSend.Style = s;
            this.mtrLAdd.Style = s;
            this.Refresh();
        }
        private void savedConfiguration(MetroFramework.MetroColorStyle metroStyle, MetroFramework.MetroThemeStyle metroTheme, String pathFile)
        {
            String newConfigFolder = Application.StartupPath + "\\Config";
            String newConfigFile = newConfigFolder + "\\" + "Settings";

            if (!Directory.Exists(newConfigFolder))
            {
                Directory.CreateDirectory(newConfigFolder);
            }

            StreamWriter file = new StreamWriter(newConfigFile + ".txt");
            file.WriteLine(metroStyle + "|" + metroTheme + "|" + pathFile);
            file.Close();
        }
        private void ThreadJob()
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(ThreadJob));
            }
            else
            {
                //Thread.Sleep(1000);
                FileStream fs = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string strTemp = sr.ReadToEnd().Replace('\r', ' ');
                String[] subStrings = strTemp.Split('\n');
                int i = 0;
                for (string s = ""; subStrings.Length > i; i++)
                {
                    s = subStrings.GetValue(i).ToString();
                    if (s.Trim() != "")
                    {
                        lbItemScan.Items.Add(s.Trim());
                    }
                }
                frmLoading.CloseLoadingScreen();

                fs.Close();
                fs.Dispose();
            }

        }
        // P/Invoke declarations
        [DllImport("gdi32.dll")]
        static extern bool BitBlt(IntPtr hdcDest, int xDest, int yDest, int
        wDest, int hDest, IntPtr hdcSource, int xSrc, int ySrc, CopyPixelOperation rop);
        [DllImport("user32.dll")]
        static extern bool ReleaseDC(IntPtr hWnd, IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteDC(IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr DeleteObject(IntPtr hDc);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleBitmap(IntPtr hdc, int nWidth, int nHeight);
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateCompatibleDC(IntPtr hdc);
        [DllImport("gdi32.dll")]
        static extern IntPtr SelectObject(IntPtr hdc, IntPtr bmp);
        [DllImport("user32.dll")]
        public static extern IntPtr GetDesktopWindow();
        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowDC(IntPtr ptr);
        #endregion
                
    }
}