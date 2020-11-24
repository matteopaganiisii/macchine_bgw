namespace Esercizio2_BGW
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_start = new System.Windows.Forms.Button();
            this.pic_red = new System.Windows.Forms.PictureBox();
            this.pic_black = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(78, 234);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(274, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // pic_red
            // 
            this.pic_red.Image = global::Esercizio2_BGW.Properties.Resources.macchinarossa;
            this.pic_red.Location = new System.Drawing.Point(8, 142);
            this.pic_red.Name = "pic_red";
            this.pic_red.Size = new System.Drawing.Size(100, 50);
            this.pic_red.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_red.TabIndex = 3;
            this.pic_red.TabStop = false;
            // 
            // pic_black
            // 
            this.pic_black.Image = global::Esercizio2_BGW.Properties.Resources.macchinabianca;
            this.pic_black.Location = new System.Drawing.Point(8, 40);
            this.pic_black.Name = "pic_black";
            this.pic_black.Size = new System.Drawing.Size(100, 50);
            this.pic_black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_black.TabIndex = 2;
            this.pic_black.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esercizio2_BGW.Properties.Resources.road_trip_background_10864211;
            this.pictureBox1.Location = new System.Drawing.Point(-69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(520, 210);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 269);
            this.Controls.Add(this.pic_red);
            this.Controls.Add(this.pic_black);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_start);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Macchine";
            ((System.ComponentModel.ISupportInitialize)(this.pic_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pic_black;
        private System.Windows.Forms.PictureBox pic_red;
    }
}

