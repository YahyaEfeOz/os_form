namespace os_form
{
    partial class menu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.clock = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.btnRockgame = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clock.Location = new System.Drawing.Point(234, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(55, 20);
            this.clock.TabIndex = 0;
            this.clock.Text = "SAAT";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.date.Location = new System.Drawing.Point(129, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(99, 20);
            this.date.TabIndex = 1;
            this.date.Text = "11 09 2021";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // btnRockgame
            // 
            this.btnRockgame.BackColor = System.Drawing.SystemColors.Control;
            this.btnRockgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRockgame.BackgroundImage")));
            this.btnRockgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRockgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockgame.Location = new System.Drawing.Point(184, 178);
            this.btnRockgame.Name = "btnRockgame";
            this.btnRockgame.Size = new System.Drawing.Size(64, 64);
            this.btnRockgame.TabIndex = 4;
            this.btnRockgame.UseVisualStyleBackColor = false;
            this.btnRockgame.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectory.BackgroundImage")));
            this.btnDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectory.Location = new System.Drawing.Point(114, 178);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(64, 64);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.UseVisualStyleBackColor = true;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.BackgroundImage")));
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.Location = new System.Drawing.Point(44, 178);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(64, 64);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.UseVisualStyleBackColor = true;
            this.btnCalculator.Click += new System.EventHandler(this.button1_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(299, 461);
            this.Controls.Add(this.btnRockgame);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.date);
            this.Controls.Add(this.clock);
            this.Name = "menu";
            this.Text = "OS";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnRockgame;
    }
}

