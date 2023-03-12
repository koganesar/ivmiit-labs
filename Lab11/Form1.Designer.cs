namespace Lab11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            heartPictureBox1 = new HeartPictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)heartPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // heartPictureBox1
            // 
            heartPictureBox1.BackColor = Color.Red;
            heartPictureBox1.Location = new Point(250, 90);
            heartPictureBox1.Name = "heartPictureBox1";
            heartPictureBox1.Size = new Size(234, 244);
            heartPictureBox1.TabIndex = 0;
            heartPictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(heartPictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Paint += Form1_Paint;
            ((System.ComponentModel.ISupportInitialize)heartPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HeartPictureBox heartPictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}