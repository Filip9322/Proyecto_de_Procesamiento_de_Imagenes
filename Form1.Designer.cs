namespace IMG_IIC_2016
{
    partial class V_Principal
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_load_image = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(146, 144);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // button_load_image
            // 
            this.button_load_image.Location = new System.Drawing.Point(180, 21);
            this.button_load_image.Name = "button_load_image";
            this.button_load_image.Size = new System.Drawing.Size(75, 23);
            this.button_load_image.TabIndex = 1;
            this.button_load_image.Text = "Abrir";
            this.button_load_image.UseVisualStyleBackColor = true;
            this.button_load_image.Click += new System.EventHandler(this.button_load_image_Click);
            // 
            // V_Principal
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.button_load_image);
            this.Controls.Add(this.pictureBox2);
            this.Name = "V_Principal";
            this.Text = "ProcessMg";
            this.Load += new System.EventHandler(this.V_Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button_load_image;
    }
}

