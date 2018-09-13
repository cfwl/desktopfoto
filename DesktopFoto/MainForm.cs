using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DesktopFoto
{
    public partial class MainForm : Form
    {
        private string PathToStore;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshInputBoxes();

            FotoTimer.Interval = Properties.Settings.Default.TimerInterval*1000;  // input in seconds interval in  milli seconds
            // set path from properties if not available then to default (myPictures path)
            PathToStore = Properties.Settings.Default.PathToStore.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        // from properties to controls
        private void RefreshInputBoxes()
        {
            nudTimerIntervalInSeconds.Value = Properties.Settings.Default.TimerInterval;
            tbTargetDirectory.Text = Properties.Settings.Default.PathToStore.ToString(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // form controls to properties and save it
            Properties.Settings.Default.TimerInterval = Convert.ToInt32(nudTimerIntervalInSeconds.Value);
            Properties.Settings.Default.PathToStore = tbTargetDirectory.Text;
            Properties.Settings.Default.Save();

            this.WindowState = FormWindowState.Minimized;
            this.MainForm_Resize(this, new EventArgs());
        }

        private void FotoTimer_Tick(object sender, EventArgs e)
        {
            Bitmap memoryImage;
            //Set full width, height for 'empty' image
            memoryImage = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
                                   Screen.PrimaryScreen.Bounds.Height,
                                   PixelFormat.Format32bppArgb);

            Size sizeRectangle = new Size(memoryImage.Width, memoryImage.Height);

            // take graphics canvas from image to draw screen on (copy it on)
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, sizeRectangle);

            // generate filename from date and time
            string filename = DateTime.Now.ToString("yyyy-MM-ddTHH-mm-ss") + ".png";
            string str = "";
            try
            {
                str = Path.Combine(PathToStore, filename); //Set folder to save image
                memoryImage.Save(str); // save the image to file
            }
            catch { };
        }

        private void btnDirectoryBrowse_Click(object sender, EventArgs e)
        {
            
            if(fbdStoreDirectory.ShowDialog()==DialogResult.OK)
            {
                tbTargetDirectory.Text = fbdStoreDirectory.SelectedPath;
            }
        }

        // the problematic part
        // not sure it works always but what I checked it did.
        FormWindowState? LastWindowState = null;
        private void MainForm_Resize(object sender, EventArgs e)
        {
            // When window state changes
            if (WindowState != LastWindowState)
            {
                if (WindowState == FormWindowState.Minimized)
                {
                    // Minimized
                    // set working controls to property values and start timer
                    FotoTimer.Interval = Properties.Settings.Default.TimerInterval * 1000; // input in seconds interval in  milli seconds
                    PathToStore = Properties.Settings.Default.PathToStore;
                    FotoTimer.Start();
                }
                else
                {
                    // Window is restored or maximized
                    // stop timer and set input controls
                    FotoTimer.Stop();
                    RefreshInputBoxes();
                }
                LastWindowState = WindowState;
            }
        }
    }
}
