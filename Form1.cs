using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WIA;
using System.Runtime.InteropServices;

using System.IO;
using AForge.Imaging.Filters;
using System.Drawing.Imaging;

namespace SimpleScan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Image ZoomPicture(Image img, double a, double b)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * a), Convert.ToInt32(img.Height * b));            
            //Graphics gpu = Graphics.FromImage(bm);
            //gpu.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Low;

            return bm;
        }

        PictureBox org;
        List<PictureBox> pictureBoxList = new List<PictureBox>();
        DeviceManager deviceManager = new DeviceManager();
        DeviceInfo AvailableScanner = null;

        string pictureSavePath = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                trackBar1.Minimum = -6;
                trackBar1.Maximum = 0;
                trackBar1.SmallChange = 1;
                trackBar1.LargeChange = 1;
                trackBar1.UseWaitCursor = false;

                this.DoubleBuffered = true;
                org = new PictureBox();
                org.Image = pictureBoxScan.Image;

                // Version anzeigen
                lblVersionValue.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

                for (int i = 1; i <= deviceManager.DeviceInfos.Count; i++)
                {
                    if (deviceManager.DeviceInfos[i].Type != WiaDeviceType.ScannerDeviceType)
                    {
                        continue;
                    }
                    else
                    {
                        lstListOfScanner.Items.Add(deviceManager.DeviceInfos[i].Properties["Name"].get_Value());
                    }                                                     
                }
                
            }
            catch (COMException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            if (trackBar1.Value != 0)
            {
                pictureBoxScan.Image = null;
                double zoom = 0.0; ;
                if (trackBar1.Value == 0) zoom = 1;
                if (trackBar1.Value == -1) zoom = 0.75;
                if (trackBar1.Value == -2) zoom = 0.5;
                if (trackBar1.Value == -3) zoom = 0.4;
                if (trackBar1.Value == -4) zoom = 0.35;
                if (trackBar1.Value == -5) zoom = 0.25;
                if (trackBar1.Value == -6) zoom = 0.2;

                pictureBoxScan.Image = ZoomPicture(org.Image, zoom, zoom);
                btnRotateRight.Enabled = false;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            if (lstListOfScanner.SelectedItem == null)
            {
                MessageBox.Show("No Scanner selected");                
                return;
            }else
            {
                try
                {
                    Cursor = Cursors.WaitCursor;
                    AvailableScanner = deviceManager.DeviceInfos[1];
                    var device = AvailableScanner.Connect();
                    var ScannerItem = device.Items[1];
                    var imgFile = (ImageFile)ScannerItem.Transfer(FormatID.wiaFormatJPEG);

                    var Path = @"D:\ScanImg.jpg";

                    if (File.Exists(Path))
                    {
                        File.Delete(Path);
                    }

                    imgFile.SaveFile(Path);
                    org.ImageLocation = Path;
                    pictureBoxScan.ImageLocation = Path;
                }
                catch (COMException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Cursor = Cursors.Default;
                }
            }            
        }

        private void btnRotateLeft_Click(object sender, EventArgs e)
        {
            Bitmap image = (Bitmap)pictureBoxScan.Image;
            RotateBilinear ro = new RotateBilinear(180, true);
            Bitmap image2 = ro.Apply(image);
            pictureBoxScan.Image = image2;
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                org.Image = System.Drawing.Image.FromFile(op.FileName);
                pictureBoxScan.Image = org.Image;
            }
        }

        private void btnSelectArea_Click(object sender, EventArgs e)
        {
            pictureBoxScan.MouseDown += new MouseEventHandler(pictureBoxScan_MouseDown);

            pictureBoxScan.MouseMove += new MouseEventHandler(pictureBoxScan_MouseMove);

            pictureBoxScan.MouseEnter += new EventHandler(pictureBoxScan_MouseEnter);
            
            //Controls.Add(pictureBoxScan);
        }

        int crpX, crpY, rectW, rectH;
        public Pen crpPen = new Pen(Color.White);
        private void pictureBoxScan_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Cursor = Cursors.Cross;
                crpPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                crpX = e.X;
                crpY = e.Y;
            }

        }

        private void btnTake_Click(object sender, EventArgs e)
        {            
            pictureBoxList.Add(pictureBoxReview);
            btnTake.Text = "Take (" + pictureBoxList.Count().ToString() + ")";
            btnTake.Enabled = false;
            dataGridView1.Rows.Add(new object[] { true, pictureBoxReview.Image, String.Empty });
        }

        private void pictureBoxScan_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnGetPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog browser = new FolderBrowserDialog();

            if (browser.ShowDialog() == DialogResult.OK)
            {
                pictureSavePath = browser.SelectedPath + "\\";
                lblPath.Text = pictureSavePath;
            }
        }

        private void pictureBoxScan_MouseEnter(object sender, EventArgs e)
        {
            base.OnMouseEnter(e);
            Cursor = Cursors.Cross;
        }

        private void pictureBoxScan_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                pictureBoxReview.Refresh();
                rectW = e.X - crpX;
                rectH = e.Y - crpY;

                Graphics g = pictureBoxScan.CreateGraphics();
                g.DrawRectangle(crpPen, crpX, crpY, rectW, rectH);
                g.Dispose();
            } 
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool _save = false;
            Image _img;
            string _filename = string.Empty;

            if(pictureSavePath.Length == 0)
            {
                MessageBox.Show("No Save Path");
                return;
            }
            if(dataGridView1.Rows.Count==0)
            {
                MessageBox.Show("No save data found");
                return;
            }
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                // dgv Daten lesen
                _save = (bool)row.Cells[0].Value;
                _img = (Image)row.Cells[1].Value;
                _filename = row.Cells[2].Value.ToString();

                if (_save & _img != null & !String.IsNullOrEmpty(_filename) )
                {
                    _img.Save(pictureSavePath+_filename+".jpg", ImageFormat.Jpeg);
                    // Wenn alles gespeichert wurde row entfernen
                    dataGridView1.Rows.RemoveAt(row.Index);
                }                
            }
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            lblDimensions.Text = "Dimensions:" + rectW + ", " + rectH;
            Cursor = Cursors.Default;

            Bitmap bmp2 = new Bitmap(pictureBoxScan.Width, pictureBoxScan.Height);
            pictureBoxScan.DrawToBitmap(bmp2, pictureBoxScan.ClientRectangle);

            Bitmap crpImg = new Bitmap(rectW, rectH);

            for (int i = 0; i < rectW; i++)
            {
                for (int y = 0; y < rectH; y++)
                {
                    Color pxlclr = bmp2.GetPixel(crpX + i, crpY + y);
                    crpImg.SetPixel(i, y, pxlclr);
                }
            }

            pictureBoxReview.Image = (Image)crpImg;
            pictureBoxReview.SizeMode = PictureBoxSizeMode.CenterImage;
            btnTake.Enabled = true;
            pictureBoxReview.Refresh();
        }


        /// <summary>
        /// Ändert die Größe eines Bildes und setzt eine Hintergrundfarbe.
        /// </summary>
        /// <param name="Source">Originalbild als Image</param>
        /// <param name="Width">Neue Breite in Pixel</param>
        /// <param name="Height">Neue Höhe in Pixel</param>
        /// <param name="Absolut">Wenn true wird ein Image mit exakt den angegebenen Maßen erstellt. Das Bild wird mittig plaziert und mit der angegebenen Farbe gefüllt. Seitenverhältnisse des Bildes selbst bleiben erhalten. Wenn False dann wird entsprechend dem kleinem Faktor das neue Bild berechnet (neues Bild hat dann aber ggfs. NICHT die angegebenen Maße!)</param>
        /// <param name="Fill">Füllfarbe für Hintergrund (vorallem wichtig bei Absolut = true oder Transparenten Bildern (PNG)</param>
        /// <param name="MaxFactorX">Maximaler Vergrößerungsfaktor X-Achse. Wenn aus Width = 10 z.B. 1000 werden soll, so kann der Wert 2 ein maximales verdoppeln ermöglichen. Das Bild hat dann Width = 20. -1 bedeutet kein Mindestfaktor</param>
        /// <param name="MaxFactorY">Maximaler Vergrößerungsfaktor Y-Achse. Wenn aus Height = 10 z.B. 1000 werden soll, so kann der Wert 2 ein maximales verdoppeln ermöglichen. Das Bild hat dann Height = 20. -1 bedeutet kein Mindestfaktor</param>
        /// <returns>Bitmap / Image</returns>
        private static Image ResizePic(Image Source, int Width, int Height, bool Absolut, Color Fill, double MaxFactorX, double MaxFactorY)
            {
                if (Source != null)
                {
                    // Faktoren für X und Y Achse berechnen
                    double dblFaktorX = (double)Width / (double)Source.Width;
                    if (dblFaktorX > MaxFactorX & MaxFactorX > -1)
                    {
                        Width = (int)((double)Source.Width * MaxFactorX);
                        dblFaktorX = MaxFactorX;
                    }

                    double dblFaxtorY = (double)Height / (double)Source.Height;
                    if (dblFaxtorY > MaxFactorY & MaxFactorY > -1)
                    {
                        Height = (int)((double)Source.Height * MaxFactorY);
                        dblFaxtorY = MaxFactorY;
                    }

                    // kleinern Faktor benutzen
                    double dblFaktorUse;
                    if (dblFaktorX < dblFaxtorY)
                        dblFaktorUse = dblFaktorX;
                    else
                        dblFaktorUse = dblFaxtorY;

                    int intNewX = (int)((double)Source.Width * dblFaktorUse);
                    int intNewY = (int)((double)Source.Height * dblFaktorUse);

                    Bitmap objNewImage;
                    int intPosX, intPosY;

                    if (Absolut)
                    {
                        objNewImage = new Bitmap(Width, Height);
                        intPosX = (Width - intNewX) / 2;
                        intPosY = (Height - intNewY) / 2;
                    }
                    else
                    {
                        objNewImage = new Bitmap(intNewX, intNewY);
                        intPosX = 0;
                        intPosY = 0;
                    }

                    using (Graphics objGfx = Graphics.FromImage(objNewImage))
                    {
                        objGfx.FillRectangle(new SolidBrush(Fill), 0, 0, objNewImage.Width, objNewImage.Height);
                        objGfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                        objGfx.DrawImage(Source, new Rectangle(intPosX, intPosY, intNewX, intNewY));
                    }
                    return objNewImage;
                }
                else
                    return null;
            }

        // Thumbnails generieren 75x75
        public Bitmap Generate75x75Pixel(Bitmap image)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            Bitmap bmp = null;
            Bitmap crapped = null;
            int x = 0, y = 0;
            double prop = 0;

            if (image.Width > 75)
            {
                // compute proportation
                prop = (double)image.Width / (double)image.Height;

                if (image.Width > image.Height)
                {
                    x = (int)Math.Round(75 * prop, 0);
                    y = 75;
                }
                else
                {
                    x = 75;
                    y = (int)Math.Round(75 / prop, 0);
                }

                bmp = new Bitmap((Image)image, new Size(x, y));

                crapped = new Bitmap(75, 75);
                Graphics g = Graphics.FromImage(crapped);
                g.DrawImage(bmp,
                    new Rectangle(0, 0, 75, 75),
                    new Rectangle(0, 0, 75, 75),
                    GraphicsUnit.Pixel);

                bmp = crapped;
            }
            else
            {
                crapped = image;
            }

            return bmp;
        }
    }    
}
