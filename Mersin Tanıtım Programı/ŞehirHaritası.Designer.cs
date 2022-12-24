
namespace Mersin_Tanıtım_Programı
{
    partial class ŞehirHaritası
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ŞehirHaritası));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1038, 700);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button16
            // 
            this.button16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button16.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button16.BackColor = System.Drawing.SystemColors.Control;
            this.button16.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button16.BackgroundImage")));
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button16.Location = new System.Drawing.Point(29, 186);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(67, 38);
            this.button16.TabIndex = 24;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button15.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button15.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button15.BackgroundImage")));
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button15.Location = new System.Drawing.Point(29, 257);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(68, 48);
            this.button15.TabIndex = 25;
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // ŞehirHaritası
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 653);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ŞehirHaritası";
            this.Text = "Mersin Rehber Programı";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button button16;
        public System.Windows.Forms.Button button15;
    }
}