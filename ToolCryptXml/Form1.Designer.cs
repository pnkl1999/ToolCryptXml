namespace ToolCryptXml
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnUncompress = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnCompress
            // 
            this.btnCompress.Location = new System.Drawing.Point(23, 12);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(129, 45);
            this.btnCompress.TabIndex = 0;
            this.btnCompress.Text = "Compress";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnUncompress
            // 
            this.btnUncompress.Location = new System.Drawing.Point(158, 12);
            this.btnUncompress.Name = "btnUncompress";
            this.btnUncompress.Size = new System.Drawing.Size(129, 45);
            this.btnUncompress.TabIndex = 1;
            this.btnUncompress.Text = "Uncompress";
            this.btnUncompress.UseVisualStyleBackColor = true;
            this.btnUncompress.Click += new System.EventHandler(this.btnUncompress_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(202, 63);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(120, 13);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.TabStop = true;
            this.lblInfo.Text = "Phạm Ngọc Khánh Lâm";
            this.lblInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInfo_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 81);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnUncompress);
            this.Controls.Add(this.btnCompress);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(337, 120);
            this.MinimumSize = new System.Drawing.Size(337, 120);
            this.Name = "Form1";
            this.Text = "Tool Crypt Xml - CYRUS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnUncompress;
        private System.Windows.Forms.LinkLabel lblInfo;
    }
}

