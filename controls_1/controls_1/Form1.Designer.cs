namespace controls_1
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
            this.btngoodbye = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnhello = new System.Windows.Forms.Button();
            this.label1Greeting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngoodbye
            // 
            this.btngoodbye.BackColor = System.Drawing.Color.Fuchsia;
            this.btngoodbye.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngoodbye.ForeColor = System.Drawing.Color.White;
            this.btngoodbye.Location = new System.Drawing.Point(373, 341);
            this.btngoodbye.Name = "btngoodbye";
            this.btngoodbye.Size = new System.Drawing.Size(118, 49);
            this.btngoodbye.TabIndex = 1;
            this.btngoodbye.Text = "GoodBye";
            this.btngoodbye.UseVisualStyleBackColor = false;
            this.btngoodbye.Click += new System.EventHandler(this.btngoodbye_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.Teal;
            this.btnclose.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.ForeColor = System.Drawing.Color.White;
            this.btnclose.Location = new System.Drawing.Point(709, 341);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(111, 49);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnhello
            // 
            this.btnhello.BackColor = System.Drawing.Color.Green;
            this.btnhello.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhello.ForeColor = System.Drawing.Color.White;
            this.btnhello.Location = new System.Drawing.Point(57, 341);
            this.btnhello.Name = "btnhello";
            this.btnhello.Size = new System.Drawing.Size(130, 49);
            this.btnhello.TabIndex = 0;
            this.btnhello.Text = "Hello";
            this.btnhello.UseVisualStyleBackColor = false;
            this.btnhello.Click += new System.EventHandler(this.btnhello_Click);
            // 
            // label1Greeting
            // 
            this.label1Greeting.AutoSize = true;
            this.label1Greeting.BackColor = System.Drawing.Color.Red;
            this.label1Greeting.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1Greeting.ForeColor = System.Drawing.Color.White;
            this.label1Greeting.Location = new System.Drawing.Point(375, 102);
            this.label1Greeting.Name = "label1Greeting";
            this.label1Greeting.Size = new System.Drawing.Size(0, 42);
            this.label1Greeting.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(895, 468);
            this.Controls.Add(this.label1Greeting);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btngoodbye);
            this.Controls.Add(this.btnhello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngoodbye;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Button btnhello;
        private System.Windows.Forms.Label label1Greeting;

    }
}

