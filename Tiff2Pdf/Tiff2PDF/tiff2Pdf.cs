using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Tiff2PDF
{
    public partial class mainForm : Form
    {

        public String tiffDir = "";
        string[] tiffFiles;


        public mainForm()
        {
            InitializeComponent();
        }

        public void chooseTiffDir()
        {
            FolderBrowserDialog fbd_mainFBD = new FolderBrowserDialog();
            if (fbd_mainFBD.ShowDialog() == DialogResult.OK)
            {
                tiffDir = fbd_mainFBD.SelectedPath;

                tiffFiles = Directory.GetFiles(@tiffDir, "*.tif");
                if (tiffFiles.Length == 0)
                {
                    Rtb_output.AppendText("\nNo Tiff Files in" + tiffDir);
                    DialogResult dr = MessageBox.Show("Would you like to select another directory?", "No Tiff Files Found!", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            chooseTiffDir();
                            break;
                        case DialogResult.No:
                            return;
                    }
                }
                else
                {
                    Rtb_output.AppendText("\n" + tiffFiles.Length + " Tiff File(s) Found");
                    txt_tiffDir.Text = fbd_mainFBD.SelectedPath;
                    for(int i = 0; i < tiffFiles.Length; i++)
                    {
                        lbx_tiffFiles.Items.Add(tiffFiles[i].Substring(txt_tiffDir.Text.Length + 1));
                        Rtb_output.AppendText("\n"+ tiffFiles[i].Substring(txt_tiffDir.Text.Length + 1)+" found!");
                    }

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rtb_output.AppendText("Launch: Successful");
            
        }

        private void btn_tiffDir_Click(object sender, EventArgs e)
        {
            chooseTiffDir();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_PdfDir_Click(object sender, EventArgs e)
        {

        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < tiffFiles.Length; i++)
            {
                try
                {
                    ConvertTiffToPdf(tiffDir+"/"+lbx_tiffFiles.Items[i].ToString(), lbx_tiffFiles.Items[i].ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string ConvertTiffToPdf(string tiffFileName, string fileName)
        {
            //iTextSharp.text.Rectangle pgSize = PageSize.LETTER;
            iTextSharp.text.Rectangle pgSize = PageSize.LEGAL;
            string pdfFile;
            string[] FileName = fileName.Split('.');
            do
            {
                pdfFile = Path.GetDirectoryName(tiffFileName) + Path.DirectorySeparatorChar +
                    FileName[0] + ".pdf";
            } while (File.Exists(pdfFile));
            if (File.Exists(pdfFile))
            {
                File.Delete(pdfFile);
            }
            if (!File.Exists(tiffFileName))
            {
                return null;
            }

            Bitmap bmp = new Bitmap(tiffFileName);

            int totalPages = bmp.GetFrameCount(FrameDimension.Page);

            float margin = 0.0f;
            //float margin = 50.0f;
            Document document = new Document(pgSize, margin, margin, margin, margin);

            try
            {

                // creation of the different writers
                PdfWriter writer = PdfWriter.GetInstance(document,
                    new FileStream(pdfFile, FileMode.Create));

                // Which of the multiple images in the TIFF file do we want to load
                // 0 refers to the first, 1 to the second and so on.
                document.Open();
                PdfContentByte cb = writer.DirectContent;
                iTextSharp.text.Image img;

                for (int ii = 0; ii < totalPages; ii++)
                {
                    bmp.SelectActiveFrame(FrameDimension.Page, ii);
                    img = iTextSharp.text.Image.GetInstance(BitmapToBytes(bmp));
                    img.ScalePercent(72f / bmp.HorizontalResolution * 100);
                    img.SetAbsolutePosition(0, 0);
                    cb.AddImage(img);
                    document.NewPage();
                }

                document.Close();
                document = null;
                bmp.Dispose();
                bmp = null;
                Rtb_output.AppendText("\n"+FileName+" Converted");

            }
            catch (Exception ex)
            {
                this.Cursor = Cursors.Default;
                MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            return pdfFile;
        }
        private byte[] BitmapToBytes(Bitmap bmp)
        {
            byte[] data = new byte[0];
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                ms.Seek(0, 0);
                data = ms.ToArray();
            }
            return data;
        }


    }
}
