namespace AsyncrnousApp
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
            this.saaButton1 = new SaaUI.SaaButton();
            this.fileName = new SaaUI.SaaFlatTextBox();
            this.listOfItems = new System.Windows.Forms.ListBox();
            this.saaButton2 = new SaaUI.SaaButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // saaButton1
            // 
            this.saaButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saaButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton1.BackColorAngle = 90F;
            this.saaButton1.Border = 1;
            this.saaButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.BorderColorAngle = 0;
            this.saaButton1.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton1.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.EnableDoubleBuffering = true;
            this.saaButton1.ForeColor = System.Drawing.Color.White;
            this.saaButton1.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton1.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton1.Icon = null;
            this.saaButton1.IconOffsetX = 5F;
            this.saaButton1.IconOffsetY = 5F;
            this.saaButton1.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton1.Location = new System.Drawing.Point(12, 24);
            this.saaButton1.Name = "saaButton1";
            this.saaButton1.Radius.BottomLeft = 2;
            this.saaButton1.Radius.BottomRight = 2;
            this.saaButton1.Radius.TopLeft = 2;
            this.saaButton1.Radius.TopRight = 2;
            this.saaButton1.Size = new System.Drawing.Size(188, 54);
            this.saaButton1.TabIndex = 0;
            this.saaButton1.TextOffsetX = 0F;
            this.saaButton1.TextOffsetY = 0F;
            this.saaButton1.Value = "Read Items";
            this.saaButton1.Click += new System.EventHandler(this.LoadDataAsync);
            // 
            // fileName
            // 
            this.fileName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fileName.BackColor = System.Drawing.Color.White;
            this.fileName.Border = true;
            this.fileName.BorderActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.fileName.BorderColor = System.Drawing.Color.Gainsboro;
            this.fileName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fileName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fileName.Hint = "";
            this.fileName.Location = new System.Drawing.Point(13, 85);
            this.fileName.MaxLength = 32767;
            this.fileName.Multiline = false;
            this.fileName.Name = "fileName";
            this.fileName.PasswordChar = '\0';
            this.fileName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fileName.SelectedText = "";
            this.fileName.SelectionLength = 0;
            this.fileName.SelectionStart = 0;
            this.fileName.Size = new System.Drawing.Size(558, 43);
            this.fileName.TabIndex = 1;
            this.fileName.TabStop = false;
            this.fileName.UseSystemPasswordChar = false;
            // 
            // listOfItems
            // 
            this.listOfItems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listOfItems.FormattingEnabled = true;
            this.listOfItems.ItemHeight = 16;
            this.listOfItems.Location = new System.Drawing.Point(12, 144);
            this.listOfItems.Name = "listOfItems";
            this.listOfItems.Size = new System.Drawing.Size(559, 292);
            this.listOfItems.TabIndex = 2;
            // 
            // saaButton2
            // 
            this.saaButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saaButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton2.BackColorAngle = 90F;
            this.saaButton2.Border = 1;
            this.saaButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton2.BorderColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton2.BorderColorAngle = 0;
            this.saaButton2.ClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            this.saaButton2.ClickColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton2.EnableDoubleBuffering = true;
            this.saaButton2.ForeColor = System.Drawing.Color.White;
            this.saaButton2.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.saaButton2.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.saaButton2.Icon = null;
            this.saaButton2.IconOffsetX = 5F;
            this.saaButton2.IconOffsetY = 5F;
            this.saaButton2.IconSize = new System.Drawing.Size(20, 20);
            this.saaButton2.Location = new System.Drawing.Point(206, 24);
            this.saaButton2.Name = "saaButton2";
            this.saaButton2.Radius.BottomLeft = 2;
            this.saaButton2.Radius.BottomRight = 2;
            this.saaButton2.Radius.TopLeft = 2;
            this.saaButton2.Radius.TopRight = 2;
            this.saaButton2.Size = new System.Drawing.Size(188, 54);
            this.saaButton2.TabIndex = 0;
            this.saaButton2.TextOffsetX = 0F;
            this.saaButton2.TextOffsetY = 0F;
            this.saaButton2.Value = "Open";
            this.saaButton2.Click += new System.EventHandler(this.Open);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 454);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(559, 47);
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 578);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listOfItems);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.saaButton2);
            this.Controls.Add(this.saaButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SaaUI.SaaButton saaButton1;
        private SaaUI.SaaFlatTextBox fileName;
        private System.Windows.Forms.ListBox listOfItems;
        private SaaUI.SaaButton saaButton2;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

