namespace SURF_Test
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.tbSrcImage = new System.Windows.Forms.TextBox();
            this.tbFndImage = new System.Windows.Forms.TextBox();
            this.btnSrcImage = new System.Windows.Forms.Button();
            this.btnFndImage = new System.Windows.Forms.Button();
            this.ofdSrcImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdFndImage = new System.Windows.Forms.OpenFileDialog();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbFnd = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFnd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.button1.Location = new System.Drawing.Point(400, 619);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(254, 60);
            this.button1.TabIndex = 0;
            this.button1.Text = "Perform Surf Detection";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BackColor = System.Drawing.Color.Transparent;
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(400, 57);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(949, 550);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // tbSrcImage
            // 
            this.tbSrcImage.Location = new System.Drawing.Point(224, 13);
            this.tbSrcImage.Margin = new System.Windows.Forms.Padding(4);
            this.tbSrcImage.Name = "tbSrcImage";
            this.tbSrcImage.Size = new System.Drawing.Size(68, 23);
            this.tbSrcImage.TabIndex = 3;
            this.tbSrcImage.Visible = false;
            // 
            // tbFndImage
            // 
            this.tbFndImage.Location = new System.Drawing.Point(300, 13);
            this.tbFndImage.Margin = new System.Windows.Forms.Padding(4);
            this.tbFndImage.Name = "tbFndImage";
            this.tbFndImage.Size = new System.Drawing.Size(68, 23);
            this.tbFndImage.TabIndex = 4;
            this.tbFndImage.Visible = false;
            this.tbFndImage.TextChanged += new System.EventHandler(this.tbFndImage_TextChanged);
            // 
            // btnSrcImage
            // 
            this.btnSrcImage.BackColor = System.Drawing.Color.Transparent;
            this.btnSrcImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSrcImage.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSrcImage.FlatAppearance.BorderSize = 2;
            this.btnSrcImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSrcImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSrcImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSrcImage.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSrcImage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSrcImage.Location = new System.Drawing.Point(16, 269);
            this.btnSrcImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnSrcImage.Name = "btnSrcImage";
            this.btnSrcImage.Size = new System.Drawing.Size(262, 58);
            this.btnSrcImage.TabIndex = 5;
            this.btnSrcImage.Text = "Browse Source Image ";
            this.btnSrcImage.UseVisualStyleBackColor = false;
            this.btnSrcImage.Click += new System.EventHandler(this.btnSrcImage_Click);
            // 
            // btnFndImage
            // 
            this.btnFndImage.BackColor = System.Drawing.Color.Transparent;
            this.btnFndImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFndImage.FlatAppearance.BorderSize = 2;
            this.btnFndImage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFndImage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFndImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFndImage.Font = new System.Drawing.Font("Algerian", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFndImage.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFndImage.Location = new System.Drawing.Point(16, 619);
            this.btnFndImage.Margin = new System.Windows.Forms.Padding(4);
            this.btnFndImage.Name = "btnFndImage";
            this.btnFndImage.Size = new System.Drawing.Size(262, 60);
            this.btnFndImage.TabIndex = 6;
            this.btnFndImage.Text = "Browse Detective Images";
            this.btnFndImage.UseVisualStyleBackColor = false;
            this.btnFndImage.Click += new System.EventHandler(this.btnFndImage_Click);
            // 
            // ofdSrcImage
            // 
            this.ofdSrcImage.FileName = "openFileDialog1";
            // 
            // ofdFndImage
            // 
            this.ofdFndImage.FileName = "openFileDialog2";
            // 
            // pbSource
            // 
            this.pbSource.BackColor = System.Drawing.Color.Transparent;
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSource.Location = new System.Drawing.Point(16, 13);
            this.pbSource.Margin = new System.Windows.Forms.Padding(4);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(333, 236);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 9;
            this.pbSource.TabStop = false;
            this.pbSource.Click += new System.EventHandler(this.pbSource_Click);
            // 
            // pbFnd
            // 
            this.pbFnd.BackColor = System.Drawing.Color.Transparent;
            this.pbFnd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFnd.Location = new System.Drawing.Point(16, 348);
            this.pbFnd.Margin = new System.Windows.Forms.Padding(4);
            this.pbFnd.Name = "pbFnd";
            this.pbFnd.Size = new System.Drawing.Size(333, 259);
            this.pbFnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFnd.TabIndex = 10;
            this.pbFnd.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Location = new System.Drawing.Point(395, 17);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 32);
            this.label5.TabIndex = 13;
            this.label5.Text = "SURF Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1206, 671);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pbFnd);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.btnFndImage);
            this.Controls.Add(this.btnSrcImage);
            this.Controls.Add(this.tbFndImage);
            this.Controls.Add(this.tbSrcImage);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Face Detector";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.TextBox tbSrcImage;
        private System.Windows.Forms.TextBox tbFndImage;
        private System.Windows.Forms.Button btnSrcImage;
        private System.Windows.Forms.Button btnFndImage;
        private System.Windows.Forms.OpenFileDialog ofdSrcImage;
        private System.Windows.Forms.OpenFileDialog ofdFndImage;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbFnd;
        private System.Windows.Forms.Label label5;
    }
}

