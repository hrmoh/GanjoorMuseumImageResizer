
namespace GanjoorMuseumImageResizer
{
    partial class MainForm
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
            this.lblInputFolder = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnInput = new System.Windows.Forms.Button();
            this.lblComment = new System.Windows.Forms.Label();
            this.lblImageNamePrefix = new System.Windows.Forms.Label();
            this.txtImageNamePrefix = new System.Windows.Forms.TextBox();
            this.lblMaxWidth = new System.Windows.Forms.Label();
            this.txtMaxWidth = new System.Windows.Forms.TextBox();
            this.txtMaxHeight = new System.Windows.Forms.TextBox();
            this.lblMaxHeight = new System.Windows.Forms.Label();
            this.btnResetSize = new System.Windows.Forms.Button();
            this.btnTargetFolder = new System.Windows.Forms.Button();
            this.txtTargetFolder = new System.Windows.Forms.TextBox();
            this.lblTargetFolder = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.lstUnsorted = new System.Windows.Forms.ListBox();
            this.lstSorted = new System.Windows.Forms.ListBox();
            this.lblAddPrefixToTarget = new System.Windows.Forms.Label();
            this.txtAddPrefixToTarget = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblInputFolder
            // 
            this.lblInputFolder.AutoSize = true;
            this.lblInputFolder.Location = new System.Drawing.Point(32, 28);
            this.lblInputFolder.Name = "lblInputFolder";
            this.lblInputFolder.Size = new System.Drawing.Size(295, 19);
            this.lblInputFolder.TabIndex = 0;
            this.lblInputFolder.Text = "Input Directory (containing jpg images):";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(333, 25);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(703, 27);
            this.txtInput.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(1042, 18);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(68, 39);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(32, 72);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(705, 19);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "It is assumed that input folder contains images named sequentially as Image1.jpg," +
    " Image2.jpg, ...";
            // 
            // lblImageNamePrefix
            // 
            this.lblImageNamePrefix.AutoSize = true;
            this.lblImageNamePrefix.Location = new System.Drawing.Point(32, 116);
            this.lblImageNamePrefix.Name = "lblImageNamePrefix";
            this.lblImageNamePrefix.Size = new System.Drawing.Size(194, 19);
            this.lblImageNamePrefix.TabIndex = 4;
            this.lblImageNamePrefix.Text = "Input Image Name Prefix:";
            // 
            // txtImageNamePrefix
            // 
            this.txtImageNamePrefix.Location = new System.Drawing.Point(232, 113);
            this.txtImageNamePrefix.Name = "txtImageNamePrefix";
            this.txtImageNamePrefix.Size = new System.Drawing.Size(100, 27);
            this.txtImageNamePrefix.TabIndex = 5;
            this.txtImageNamePrefix.Text = "Image";
            this.txtImageNamePrefix.TextChanged += new System.EventHandler(this.txtImageNamePrefix_TextChanged);
            // 
            // lblMaxWidth
            // 
            this.lblMaxWidth.AutoSize = true;
            this.lblMaxWidth.Location = new System.Drawing.Point(32, 163);
            this.lblMaxWidth.Name = "lblMaxWidth";
            this.lblMaxWidth.Size = new System.Drawing.Size(190, 19);
            this.lblMaxWidth.TabIndex = 6;
            this.lblMaxWidth.Text = "Target Image Max Width:";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(232, 160);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(100, 27);
            this.txtMaxWidth.TabIndex = 7;
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(560, 160);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(100, 27);
            this.txtMaxHeight.TabIndex = 9;
            // 
            // lblMaxHeight
            // 
            this.lblMaxHeight.AutoSize = true;
            this.lblMaxHeight.Location = new System.Drawing.Point(360, 163);
            this.lblMaxHeight.Name = "lblMaxHeight";
            this.lblMaxHeight.Size = new System.Drawing.Size(195, 19);
            this.lblMaxHeight.TabIndex = 8;
            this.lblMaxHeight.Text = "Target Image Max Height:";
            // 
            // btnResetSize
            // 
            this.btnResetSize.Location = new System.Drawing.Point(677, 150);
            this.btnResetSize.Name = "btnResetSize";
            this.btnResetSize.Size = new System.Drawing.Size(75, 44);
            this.btnResetSize.TabIndex = 10;
            this.btnResetSize.Text = "Reset";
            this.btnResetSize.UseVisualStyleBackColor = true;
            this.btnResetSize.Click += new System.EventHandler(this.btnResetSize_Click);
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(870, 202);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(59, 41);
            this.btnTargetFolder.TabIndex = 13;
            this.btnTargetFolder.Text = "...";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(161, 210);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(703, 27);
            this.txtTargetFolder.TabIndex = 12;
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(32, 213);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(110, 19);
            this.lblTargetFolder.TabIndex = 11;
            this.lblTargetFolder.Text = "Target Folder:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(36, 298);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(493, 46);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(32, 359);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(91, 19);
            this.lblCurrentFile.TabIndex = 15;
            this.lblCurrentFile.Text = "Current File";
            // 
            // lstUnsorted
            // 
            this.lstUnsorted.FormattingEnabled = true;
            this.lstUnsorted.ItemHeight = 19;
            this.lstUnsorted.Location = new System.Drawing.Point(36, 402);
            this.lstUnsorted.Name = "lstUnsorted";
            this.lstUnsorted.Size = new System.Drawing.Size(563, 270);
            this.lstUnsorted.TabIndex = 16;
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.ItemHeight = 19;
            this.lstSorted.Location = new System.Drawing.Point(632, 402);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(614, 270);
            this.lstSorted.TabIndex = 17;
            // 
            // lblAddPrefixToTarget
            // 
            this.lblAddPrefixToTarget.AutoSize = true;
            this.lblAddPrefixToTarget.Location = new System.Drawing.Point(32, 256);
            this.lblAddPrefixToTarget.Name = "lblAddPrefixToTarget";
            this.lblAddPrefixToTarget.Size = new System.Drawing.Size(231, 19);
            this.lblAddPrefixToTarget.TabIndex = 18;
            this.lblAddPrefixToTarget.Text = "Add prefix to target file names:";
            // 
            // txtAddPrefixToTarget
            // 
            this.txtAddPrefixToTarget.Location = new System.Drawing.Point(269, 253);
            this.txtAddPrefixToTarget.Name = "txtAddPrefixToTarget";
            this.txtAddPrefixToTarget.Size = new System.Drawing.Size(100, 27);
            this.txtAddPrefixToTarget.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1280, 719);
            this.Controls.Add(this.txtAddPrefixToTarget);
            this.Controls.Add(this.lblAddPrefixToTarget);
            this.Controls.Add(this.lstSorted);
            this.Controls.Add(this.lstUnsorted);
            this.Controls.Add(this.lblCurrentFile);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnTargetFolder);
            this.Controls.Add(this.txtTargetFolder);
            this.Controls.Add(this.lblTargetFolder);
            this.Controls.Add(this.btnResetSize);
            this.Controls.Add(this.txtMaxHeight);
            this.Controls.Add(this.lblMaxHeight);
            this.Controls.Add(this.txtMaxWidth);
            this.Controls.Add(this.lblMaxWidth);
            this.Controls.Add(this.txtImageNamePrefix);
            this.Controls.Add(this.lblImageNamePrefix);
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblInputFolder);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "MainForm";
            this.Text = "Ganjoor Museum Image Resizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInputFolder;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.Label lblImageNamePrefix;
        private System.Windows.Forms.TextBox txtImageNamePrefix;
        private System.Windows.Forms.Label lblMaxWidth;
        private System.Windows.Forms.TextBox txtMaxWidth;
        private System.Windows.Forms.TextBox txtMaxHeight;
        private System.Windows.Forms.Label lblMaxHeight;
        private System.Windows.Forms.Button btnResetSize;
        private System.Windows.Forms.Button btnTargetFolder;
        private System.Windows.Forms.TextBox txtTargetFolder;
        private System.Windows.Forms.Label lblTargetFolder;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.ListBox lstUnsorted;
        private System.Windows.Forms.ListBox lstSorted;
        private System.Windows.Forms.Label lblAddPrefixToTarget;
        private System.Windows.Forms.TextBox txtAddPrefixToTarget;
    }
}

