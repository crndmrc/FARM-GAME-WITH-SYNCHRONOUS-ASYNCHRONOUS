namespace UI
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl_skor = new System.Windows.Forms.Label();
            this.lbl_inek = new System.Windows.Forms.Label();
            this.lbl_sut = new System.Windows.Forms.Label();
            this.btn_inek = new System.Windows.Forms.Button();
            this.btn_sut = new System.Windows.Forms.Button();
            this.btn_async = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(183, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(63, 25);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(99, 81);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(333, 25);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(75, 25);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "SKOR";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_skor
            // 
            this.lbl_skor.AutoSize = true;
            this.lbl_skor.Location = new System.Drawing.Point(436, 34);
            this.lbl_skor.Name = "lbl_skor";
            this.lbl_skor.Size = new System.Drawing.Size(13, 13);
            this.lbl_skor.TabIndex = 3;
            this.lbl_skor.Text = "0";
            // 
            // lbl_inek
            // 
            this.lbl_inek.AutoSize = true;
            this.lbl_inek.Location = new System.Drawing.Point(60, 120);
            this.lbl_inek.Name = "lbl_inek";
            this.lbl_inek.Size = new System.Drawing.Size(13, 13);
            this.lbl_inek.TabIndex = 4;
            this.lbl_inek.Text = "0";
            // 
            // lbl_sut
            // 
            this.lbl_sut.AutoSize = true;
            this.lbl_sut.Location = new System.Drawing.Point(180, 120);
            this.lbl_sut.Name = "lbl_sut";
            this.lbl_sut.Size = new System.Drawing.Size(13, 13);
            this.lbl_sut.TabIndex = 5;
            this.lbl_sut.Text = "0";
            // 
            // btn_inek
            // 
            this.btn_inek.Location = new System.Drawing.Point(87, 120);
            this.btn_inek.Name = "btn_inek";
            this.btn_inek.Size = new System.Drawing.Size(75, 23);
            this.btn_inek.TabIndex = 6;
            this.btn_inek.Text = "İnek Satın Al";
            this.btn_inek.UseVisualStyleBackColor = true;
            this.btn_inek.Click += new System.EventHandler(this.btn_inek_Click);
            // 
            // btn_sut
            // 
            this.btn_sut.Location = new System.Drawing.Point(208, 120);
            this.btn_sut.Name = "btn_sut";
            this.btn_sut.Size = new System.Drawing.Size(75, 23);
            this.btn_sut.TabIndex = 7;
            this.btn_sut.Text = "Süt Sağ";
            this.btn_sut.UseVisualStyleBackColor = true;
            this.btn_sut.Click += new System.EventHandler(this.btn_sut_Click);
            // 
            // btn_async
            // 
            this.btn_async.Location = new System.Drawing.Point(338, 120);
            this.btn_async.Name = "btn_async";
            this.btn_async.Size = new System.Drawing.Size(111, 23);
            this.btn_async.TabIndex = 8;
            this.btn_async.Text = "Oyunu Kaydet";
            this.btn_async.UseVisualStyleBackColor = true;
            this.btn_async.Click += new System.EventHandler(this.btn_async_Click);
            // 
            // Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 167);
            this.Controls.Add(this.btn_async);
            this.Controls.Add(this.btn_sut);
            this.Controls.Add(this.btn_inek);
            this.Controls.Add(this.lbl_sut);
            this.Controls.Add(this.lbl_inek);
            this.Controls.Add(this.lbl_skor);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Anasayfa";
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.Anasayfa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl_skor;
        private System.Windows.Forms.Label lbl_inek;
        private System.Windows.Forms.Label lbl_sut;
        private System.Windows.Forms.Button btn_inek;
        private System.Windows.Forms.Button btn_sut;
        private System.Windows.Forms.Button btn_async;
    }
}