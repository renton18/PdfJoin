using Spire.Pdf;
using Spire.Pdf.Graphics;
using System;
using System.Windows.Forms;
using System.Configuration;
using PdfJoin.Properties;

namespace PdfJoin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbMImg1.Text = Settings.Default.MImg1;
            tbMImg1X.Text = Settings.Default.MImg1X;
            tbMImg1Y.Text = Settings.Default.MImg1Y;
            tbMImg2.Text = Settings.Default.MImg2;
            tbMImg2X.Text = Settings.Default.MImg2X;
            tbMImg2Y.Text = Settings.Default.MImg2Y;
            tbMSaveFile.Text = Settings.Default.MSaveFile;
            tbHImg.Text = Settings.Default.HImg;
            tbHImgX.Text = Settings.Default.HImgX;
            tbHImgY.Text = Settings.Default.HImgY;
            tbHSaveFile.Text = Settings.Default.HSaveFile;      
        }

        private void btnOpenPdf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbHattyuFile.Text = openFileDialog1.FileName;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbHattyuFile.Text = openFileDialog1.FileName;
            }
        }

        private void Join(string baseFileName, string image1, float img1X, float img1Y, string image2, float img2X, float img2Y, string saveFileName)
        {
            try
            {
                //PdfDocument オブジェクトを作成する
                PdfDocument pdf = new PdfDocument();
                //PDFファイルを読み込む
                pdf.LoadFromFile(baseFileName);
                //ドキュメントの最初のページを取得する
                PdfPageBase page = pdf.Pages[0];
                //画像を読み込む
                PdfImage temp1 = PdfImage.FromFile(image1);
                page.Canvas.DrawImage(temp1, img1X, img1Y, temp1.Width, temp1.Height);
                if (image2 != "")
                {
                    PdfImage temp2 = PdfImage.FromFile(image1);
                    page.Canvas.DrawImage(temp2, img2X, img2Y, temp2.Width, temp2.Height);
                }
                //ドキュメントを保存する
                pdf.SaveToFile(saveFileName, FileFormat.PDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            var baseMFileName = tbMtumoriFile.Text;
            var tbMImg1T = tbMImg1.Text;
            var tbMImg1XT = float.Parse(tbMImg1X.Text);
            var tbMImg1YT = float.Parse(tbMImg1Y.Text);
            var tbMImg2T = tbMImg2.Text;
            var tbMImg2XT = float.Parse(tbMImg2X.Text);
            var tbMImg2YT = float.Parse(tbMImg2Y.Text);
            var tbMSaveFileT = tbMSaveFile.Text;

            var baseHFileName = tbHattyuFile.Text;
            var tbHImgT = tbHImg.Text;
            var tbHImgXT = float.Parse(tbHImgX.Text);
            var tbHImgYT = float.Parse(tbHImgY.Text);
            var tbHSaveFileT = tbHSaveFile.Text;

            if (tbMtumoriFile.Text.Trim() != "")
            {
                Join(baseMFileName, tbMImg1T, tbMImg1XT, tbMImg1YT, tbMImg2T, tbMImg2XT, tbMImg2YT, tbMSaveFileT);
            }
            if (tbHattyuFile.Text.Trim() != "")
            {
                Join(baseHFileName, tbHImgT, tbHImgXT, tbHImgYT, "", 0, 0, tbHSaveFileT);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Settings.Default.MImg1 = tbMImg1.Text;
            Settings.Default.MImg1X = tbMImg1X.Text;
            Settings.Default.MImg1Y = tbMImg1Y.Text;
            Settings.Default.MImg2 = tbMImg2.Text;
            Settings.Default.MImg2X = tbMImg2X.Text;
            Settings.Default.MImg2Y = tbMImg2Y.Text;
            Settings.Default.MSaveFile = tbMSaveFile.Text;
            Settings.Default.HImg = tbHImg.Text;
            Settings.Default.HImgX = tbHImgX.Text;
            Settings.Default.HImgY = tbHImgY.Text;
            Settings.Default.HSaveFile = tbHSaveFile.Text;
            Settings.Default.Save();
        }
    }
}
