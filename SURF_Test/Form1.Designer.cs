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
            this.button1 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.tbSrcImage = new System.Windows.Forms.TextBox();
            this.tbFndImage = new System.Windows.Forms.TextBox();
            this.btnSrcImage = new System.Windows.Forms.Button();
            this.btnFndImage = new System.Windows.Forms.Button();
            this.ofdSrcImage = new System.Windows.Forms.OpenFileDialog();
            this.ofdFndImage = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pbSource = new System.Windows.Forms.PictureBox();
            this.pbFnd = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFnd)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(548, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 71);
            this.button1.TabIndex = 0;
            this.button1.Text = "Perform Surf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.imageBox1.Location = new System.Drawing.Point(312, 102);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(906, 476);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // tbSrcImage
            // 
            this.tbSrcImage.Location = new System.Drawing.Point(105, 28);
            this.tbSrcImage.Name = "tbSrcImage";
            this.tbSrcImage.Size = new System.Drawing.Size(377, 20);
            this.tbSrcImage.TabIndex = 3;
            // 
            // tbFndImage
            // 
            this.tbFndImage.Location = new System.Drawing.Point(105, 55);
            this.tbFndImage.Name = "tbFndImage";
            this.tbFndImage.Size = new System.Drawing.Size(377, 20);
            this.tbFndImage.TabIndex = 4;
            // 
            // btnSrcImage
            // 
            this.btnSrcImage.Location = new System.Drawing.Point(488, 26);
            this.btnSrcImage.Name = "btnSrcImage";
            this.btnSrcImage.Size = new System.Drawing.Size(27, 23);
            this.btnSrcImage.TabIndex = 5;
            this.btnSrcImage.Text = "...";
            this.btnSrcImage.UseVisualStyleBackColor = true;
            this.btnSrcImage.Click += new System.EventHandler(this.btnSrcImage_Click);
            // 
            // btnFndImage
            // 
            this.btnFndImage.Location = new System.Drawing.Point(488, 53);
            this.btnFndImage.Name = "btnFndImage";
            this.btnFndImage.Size = new System.Drawing.Size(27, 23);
            this.btnFndImage.TabIndex = 6;
            this.btnFndImage.Text = "...";
            this.btnFndImage.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Image To Track";
            // 
            // pbSource
            // 
            this.pbSource.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbSource.Location = new System.Drawing.Point(20, 102);
            this.pbSource.Name = "pbSource";
            this.pbSource.Size = new System.Drawing.Size(263, 217);
            this.pbSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSource.TabIndex = 9;
            this.pbSource.TabStop = false;
            // 
            // pbFnd
            // 
            this.pbFnd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFnd.Location = new System.Drawing.Point(20, 338);
            this.pbFnd.Name = "pbFnd";
            this.pbFnd.Size = new System.Drawing.Size(263, 230);
            this.pbFnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFnd.TabIndex = 10;
            this.pbFnd.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Source Image";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Image To find";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(309, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "SURF Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 602);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbFnd);
            this.Controls.Add(this.pbSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFndImage);
            this.Controls.Add(this.btnSrcImage);
            this.Controls.Add(this.tbFndImage);
            this.Controls.Add(this.tbSrcImage);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Channel Logo Finder";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbSource;
        private System.Windows.Forms.PictureBox pbFnd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

