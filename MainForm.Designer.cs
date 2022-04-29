
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
            this.lblReplace1 = new System.Windows.Forms.Label();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.lblReplace2 = new System.Windows.Forms.Label();
            this.txtReplaceWith = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblInputFolder
            // 
            this.lblInputFolder.AutoSize = true;
            this.lblInputFolder.Location = new System.Drawing.Point(21, 19);
            this.lblInputFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInputFolder.Name = "lblInputFolder";
            this.lblInputFolder.Size = new System.Drawing.Size(198, 13);
            this.lblInputFolder.TabIndex = 0;
            this.lblInputFolder.Text = "Input Directory (containing jpg images):";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(222, 17);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(470, 20);
            this.txtInput.TabIndex = 1;
            // 
            // btnInput
            // 
            this.btnInput.Location = new System.Drawing.Point(695, 12);
            this.btnInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(45, 26);
            this.btnInput.TabIndex = 2;
            this.btnInput.Text = "...";
            this.btnInput.UseVisualStyleBackColor = true;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(21, 71);
            this.lblComment.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(478, 13);
            this.lblComment.TabIndex = 3;
            this.lblComment.Text = "It is assumed that input folder contains images named sequentially as Image1.jpg," +
    " Image2.jpg, ...";
            // 
            // lblImageNamePrefix
            // 
            this.lblImageNamePrefix.AutoSize = true;
            this.lblImageNamePrefix.Location = new System.Drawing.Point(21, 100);
            this.lblImageNamePrefix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblImageNamePrefix.Name = "lblImageNamePrefix";
            this.lblImageNamePrefix.Size = new System.Drawing.Size(131, 13);
            this.lblImageNamePrefix.TabIndex = 4;
            this.lblImageNamePrefix.Text = "Input Image Name Prefix:";
            // 
            // txtImageNamePrefix
            // 
            this.txtImageNamePrefix.Location = new System.Drawing.Point(155, 98);
            this.txtImageNamePrefix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtImageNamePrefix.Name = "txtImageNamePrefix";
            this.txtImageNamePrefix.Size = new System.Drawing.Size(68, 20);
            this.txtImageNamePrefix.TabIndex = 5;
            this.txtImageNamePrefix.Text = "Image";
            this.txtImageNamePrefix.TextChanged += new System.EventHandler(this.txtImageNamePrefix_TextChanged);
            // 
            // lblMaxWidth
            // 
            this.lblMaxWidth.AutoSize = true;
            this.lblMaxWidth.Location = new System.Drawing.Point(21, 132);
            this.lblMaxWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxWidth.Name = "lblMaxWidth";
            this.lblMaxWidth.Size = new System.Drawing.Size(130, 13);
            this.lblMaxWidth.TabIndex = 6;
            this.lblMaxWidth.Text = "Target Image Max Width:";
            // 
            // txtMaxWidth
            // 
            this.txtMaxWidth.Location = new System.Drawing.Point(155, 130);
            this.txtMaxWidth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxWidth.Name = "txtMaxWidth";
            this.txtMaxWidth.Size = new System.Drawing.Size(68, 20);
            this.txtMaxWidth.TabIndex = 7;
            // 
            // txtMaxHeight
            // 
            this.txtMaxHeight.Location = new System.Drawing.Point(373, 130);
            this.txtMaxHeight.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaxHeight.Name = "txtMaxHeight";
            this.txtMaxHeight.Size = new System.Drawing.Size(68, 20);
            this.txtMaxHeight.TabIndex = 9;
            // 
            // lblMaxHeight
            // 
            this.lblMaxHeight.AutoSize = true;
            this.lblMaxHeight.Location = new System.Drawing.Point(240, 132);
            this.lblMaxHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxHeight.Name = "lblMaxHeight";
            this.lblMaxHeight.Size = new System.Drawing.Size(133, 13);
            this.lblMaxHeight.TabIndex = 8;
            this.lblMaxHeight.Text = "Target Image Max Height:";
            // 
            // btnResetSize
            // 
            this.btnResetSize.Location = new System.Drawing.Point(451, 123);
            this.btnResetSize.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnResetSize.Name = "btnResetSize";
            this.btnResetSize.Size = new System.Drawing.Size(50, 29);
            this.btnResetSize.TabIndex = 10;
            this.btnResetSize.Text = "Reset";
            this.btnResetSize.UseVisualStyleBackColor = true;
            this.btnResetSize.Click += new System.EventHandler(this.btnResetSize_Click);
            // 
            // btnTargetFolder
            // 
            this.btnTargetFolder.Location = new System.Drawing.Point(580, 158);
            this.btnTargetFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTargetFolder.Name = "btnTargetFolder";
            this.btnTargetFolder.Size = new System.Drawing.Size(39, 27);
            this.btnTargetFolder.TabIndex = 13;
            this.btnTargetFolder.Text = "...";
            this.btnTargetFolder.UseVisualStyleBackColor = true;
            this.btnTargetFolder.Click += new System.EventHandler(this.btnTargetFolder_Click);
            // 
            // txtTargetFolder
            // 
            this.txtTargetFolder.Location = new System.Drawing.Point(107, 163);
            this.txtTargetFolder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTargetFolder.Name = "txtTargetFolder";
            this.txtTargetFolder.Size = new System.Drawing.Size(470, 20);
            this.txtTargetFolder.TabIndex = 12;
            // 
            // lblTargetFolder
            // 
            this.lblTargetFolder.AutoSize = true;
            this.lblTargetFolder.Location = new System.Drawing.Point(21, 165);
            this.lblTargetFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTargetFolder.Name = "lblTargetFolder";
            this.lblTargetFolder.Size = new System.Drawing.Size(76, 13);
            this.lblTargetFolder.TabIndex = 11;
            this.lblTargetFolder.Text = "Target Folder:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(24, 222);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(329, 31);
            this.btnRun.TabIndex = 14;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(21, 262);
            this.lblCurrentFile.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(63, 13);
            this.lblCurrentFile.TabIndex = 15;
            this.lblCurrentFile.Text = "Current File";
            // 
            // lstUnsorted
            // 
            this.lstUnsorted.FormattingEnabled = true;
            this.lstUnsorted.Location = new System.Drawing.Point(24, 291);
            this.lstUnsorted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstUnsorted.Name = "lstUnsorted";
            this.lstUnsorted.Size = new System.Drawing.Size(377, 173);
            this.lstUnsorted.TabIndex = 16;
            // 
            // lstSorted
            // 
            this.lstSorted.FormattingEnabled = true;
            this.lstSorted.Location = new System.Drawing.Point(421, 291);
            this.lstSorted.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstSorted.Name = "lstSorted";
            this.lstSorted.Size = new System.Drawing.Size(411, 173);
            this.lstSorted.TabIndex = 17;
            // 
            // lblAddPrefixToTarget
            // 
            this.lblAddPrefixToTarget.AutoSize = true;
            this.lblAddPrefixToTarget.Location = new System.Drawing.Point(21, 194);
            this.lblAddPrefixToTarget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddPrefixToTarget.Name = "lblAddPrefixToTarget";
            this.lblAddPrefixToTarget.Size = new System.Drawing.Size(158, 13);
            this.lblAddPrefixToTarget.TabIndex = 18;
            this.lblAddPrefixToTarget.Text = "Add prefix to target file names:";
            // 
            // txtAddPrefixToTarget
            // 
            this.txtAddPrefixToTarget.Location = new System.Drawing.Point(179, 192);
            this.txtAddPrefixToTarget.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddPrefixToTarget.Name = "txtAddPrefixToTarget";
            this.txtAddPrefixToTarget.Size = new System.Drawing.Size(68, 20);
            this.txtAddPrefixToTarget.TabIndex = 19;
            // 
            // lblReplace1
            // 
            this.lblReplace1.AutoSize = true;
            this.lblReplace1.Location = new System.Drawing.Point(21, 45);
            this.lblReplace1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplace1.Name = "lblReplace1";
            this.lblReplace1.Size = new System.Drawing.Size(143, 13);
            this.lblReplace1.TabIndex = 20;
            this.lblReplace1.Text = "Batch replace in filesnames :";
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.Location = new System.Drawing.Point(168, 42);
            this.txtSearchFor.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(68, 20);
            this.txtSearchFor.TabIndex = 21;
            this.txtSearchFor.Text = "b0001";
            // 
            // lblReplace2
            // 
            this.lblReplace2.AutoSize = true;
            this.lblReplace2.Location = new System.Drawing.Point(240, 45);
            this.lblReplace2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReplace2.Name = "lblReplace2";
            this.lblReplace2.Size = new System.Drawing.Size(27, 13);
            this.lblReplace2.TabIndex = 22;
            this.lblReplace2.Text = "with";
            // 
            // txtReplaceWith
            // 
            this.txtReplaceWith.Location = new System.Drawing.Point(271, 42);
            this.txtReplaceWith.Margin = new System.Windows.Forms.Padding(2);
            this.txtReplaceWith.Name = "txtReplaceWith";
            this.txtReplaceWith.Size = new System.Drawing.Size(68, 20);
            this.txtReplaceWith.TabIndex = 23;
            this.txtReplaceWith.Text = "e";
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(343, 41);
            this.btnReplace.Margin = new System.Windows.Forms.Padding(2);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(58, 25);
            this.btnReplace.TabIndex = 24;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(853, 536);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.txtReplaceWith);
            this.Controls.Add(this.lblReplace2);
            this.Controls.Add(this.txtSearchFor);
            this.Controls.Add(this.lblReplace1);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label lblReplace1;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.Label lblReplace2;
        private System.Windows.Forms.TextBox txtReplaceWith;
        private System.Windows.Forms.Button btnReplace;
    }
}

