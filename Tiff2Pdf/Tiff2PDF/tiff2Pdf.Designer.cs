namespace Tiff2PDF
{
    partial class mainForm
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
            this.fbd_mainFBD = new System.Windows.Forms.FolderBrowserDialog();
            this.Rtb_output = new System.Windows.Forms.RichTextBox();
            this.btn_tiffDir = new System.Windows.Forms.Button();
            this.lbl_tiffDir = new System.Windows.Forms.Label();
            this.txt_tiffDir = new System.Windows.Forms.TextBox();
            this.lbx_tiffFiles = new System.Windows.Forms.ListBox();
            this.btn_convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Rtb_output
            // 
            this.Rtb_output.Location = new System.Drawing.Point(12, 300);
            this.Rtb_output.Name = "Rtb_output";
            this.Rtb_output.ReadOnly = true;
            this.Rtb_output.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Rtb_output.Size = new System.Drawing.Size(244, 138);
            this.Rtb_output.TabIndex = 0;
            this.Rtb_output.Text = "";
            // 
            // btn_tiffDir
            // 
            this.btn_tiffDir.Location = new System.Drawing.Point(16, 36);
            this.btn_tiffDir.Name = "btn_tiffDir";
            this.btn_tiffDir.Size = new System.Drawing.Size(121, 23);
            this.btn_tiffDir.TabIndex = 1;
            this.btn_tiffDir.Text = "Select Tiff Directory";
            this.btn_tiffDir.UseVisualStyleBackColor = true;
            this.btn_tiffDir.Click += new System.EventHandler(this.btn_tiffDir_Click);
            // 
            // lbl_tiffDir
            // 
            this.lbl_tiffDir.AutoSize = true;
            this.lbl_tiffDir.Location = new System.Drawing.Point(13, 13);
            this.lbl_tiffDir.Name = "lbl_tiffDir";
            this.lbl_tiffDir.Size = new System.Drawing.Size(70, 13);
            this.lbl_tiffDir.TabIndex = 2;
            this.lbl_tiffDir.Text = "Tiff Directory:";
            // 
            // txt_tiffDir
            // 
            this.txt_tiffDir.Enabled = false;
            this.txt_tiffDir.Location = new System.Drawing.Point(90, 10);
            this.txt_tiffDir.Name = "txt_tiffDir";
            this.txt_tiffDir.Size = new System.Drawing.Size(166, 20);
            this.txt_tiffDir.TabIndex = 3;
            // 
            // lbx_tiffFiles
            // 
            this.lbx_tiffFiles.Enabled = false;
            this.lbx_tiffFiles.FormattingEnabled = true;
            this.lbx_tiffFiles.Location = new System.Drawing.Point(12, 69);
            this.lbx_tiffFiles.Name = "lbx_tiffFiles";
            this.lbx_tiffFiles.Size = new System.Drawing.Size(244, 225);
            this.lbx_tiffFiles.TabIndex = 4;
            // 
            // btn_convert
            // 
            this.btn_convert.Location = new System.Drawing.Point(143, 36);
            this.btn_convert.Name = "btn_convert";
            this.btn_convert.Size = new System.Drawing.Size(113, 23);
            this.btn_convert.TabIndex = 5;
            this.btn_convert.Text = "Convert";
            this.btn_convert.UseVisualStyleBackColor = true;
            this.btn_convert.Click += new System.EventHandler(this.btn_convert_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 450);
            this.Controls.Add(this.btn_convert);
            this.Controls.Add(this.lbx_tiffFiles);
            this.Controls.Add(this.txt_tiffDir);
            this.Controls.Add(this.lbl_tiffDir);
            this.Controls.Add(this.btn_tiffDir);
            this.Controls.Add(this.Rtb_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.Text = "Tiff to PDF Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbd_mainFBD;
        private System.Windows.Forms.RichTextBox Rtb_output;
        private System.Windows.Forms.Button btn_tiffDir;
        private System.Windows.Forms.Label lbl_tiffDir;
        private System.Windows.Forms.TextBox txt_tiffDir;
        private System.Windows.Forms.ListBox lbx_tiffFiles;
        private System.Windows.Forms.Button btn_convert;
    }
}

