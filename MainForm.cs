﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GanjoorMuseumImageResizer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            txtInput.Text = Properties.Settings.Default.InputFolder;

            txtImageNamePrefix.Text = Properties.Settings.Default.InputImageNamePrefix;

            txtMaxWidth.Text = Properties.Settings.Default.TargetImageMaxWidth.ToString();
            txtMaxHeight.Text = Properties.Settings.Default.TargetImageMaxHeight.ToString();

            txtTargetFolder.Text = Properties.Settings.Default.TargetFolder;
        }

        private void _UpdateImageNamePrefixLabel()
        {
            lblComment.Text = $"It is assumed that input folder contains images named sequentially as {txtImageNamePrefix.Text}1.jpg, {txtImageNamePrefix.Text}2.jpg, ...";
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if(!string.IsNullOrEmpty(txtInput.Text) && Directory.Exists(txtInput.Text))
                {
                    dlg.SelectedPath = txtInput.Text;
                }
                if(dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtInput.Text = dlg.SelectedPath;
                }
            }
        }

        private void txtImageNamePrefix_TextChanged(object sender, EventArgs e)
        {
            _UpdateImageNamePrefixLabel();
        }

        private void btnResetSize_Click(object sender, EventArgs e)
        {
            txtMaxWidth.Text = "800";
            txtMaxHeight.Text = "1350";
        }

        private void btnTargetFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                if (!string.IsNullOrEmpty(txtTargetFolder.Text) && Directory.Exists(txtTargetFolder.Text))
                {
                    dlg.SelectedPath = txtInput.Text;
                }
                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    txtTargetFolder.Text = dlg.SelectedPath;
                }
            }
        }

        int _inputImageNameCompare(string a, string b)
        {
            string prefix = txtImageNamePrefix.Text;
            a = Path.GetFileNameWithoutExtension(a).Substring(prefix.Length);
            b = Path.GetFileNameWithoutExtension(b).Substring(prefix.Length);
            return int.Parse(a).CompareTo(int.Parse(b));
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int NormalImageMaxWidth = int.Parse(txtMaxWidth.Text);
            int NormalImageMaxHeight = int.Parse(txtMaxHeight.Text);

            Properties.Settings.Default.TargetImageMaxWidth = NormalImageMaxWidth;
            Properties.Settings.Default.TargetImageMaxHeight = NormalImageMaxHeight;
            Properties.Settings.Default.InputFolder = txtInput.Text;
            Properties.Settings.Default.InputImageNamePrefix = txtImageNamePrefix.Text;
            Properties.Settings.Default.TargetFolder = txtTargetFolder.Text;
            Properties.Settings.Default.Save();


            string[] files = Directory.GetFiles(txtInput.Text, "*.jpg");
            Array.Sort(files, (a, b) => _inputImageNameCompare(a, b));
            for (int fIndex = 0; fIndex < files.Length; fIndex++)
            {
                string file = files[fIndex];
                lblCurrentFile.Text = file;
                Application.DoEvents();
                using (Image img = Image.FromFile(file))
                {
                    string targetFileName = Path.Combine(txtTargetFolder.Text, $"{fIndex.ToString().PadLeft(4, '0')}.jpg");
                    if (img.Width <= NormalImageMaxWidth && img.Height <= NormalImageMaxHeight)
                    {
                        File.Copy(file, targetFileName);
                    }
                    else
                    {
                        int pictureFileNormalSizeImageWidth = NormalImageMaxWidth;
                        int pictureFileNormalSizeImageHeight = NormalImageMaxWidth * img.Height / img.Width;

                        if (pictureFileNormalSizeImageHeight > NormalImageMaxHeight)
                        {
                            pictureFileNormalSizeImageHeight = NormalImageMaxHeight;
                            pictureFileNormalSizeImageWidth = NormalImageMaxHeight * img.Width / img.Height;
                        }
                        Image resized = new Bitmap(pictureFileNormalSizeImageWidth, pictureFileNormalSizeImageHeight);
                        using (Graphics gResized = Graphics.FromImage(resized))
                        {
                            gResized.DrawImage(img, 0, 0, pictureFileNormalSizeImageWidth, pictureFileNormalSizeImageHeight);
                        }
                        resized.Save(targetFileName, ImageFormat.Jpeg);

                    }
                }
            }

            MessageBox.Show("finished!");
        }
    }
}