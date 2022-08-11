namespace os_form
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.clock = new System.Windows.Forms.Label();
            this.btnRockgame = new System.Windows.Forms.Button();
            this.btnDirectory = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnWeatherForecast = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clock
            // 
            this.clock.AutoSize = true;
            this.clock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clock.Location = new System.Drawing.Point(12, 9);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(55, 20);
            this.clock.TabIndex = 0;
            this.clock.Text = "SAAT";
            // 
            // btnRockgame
            // 
            this.btnRockgame.BackColor = System.Drawing.Color.White;
            this.btnRockgame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRockgame.BackgroundImage")));
            this.btnRockgame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRockgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRockgame.Location = new System.Drawing.Point(154, 239);
            this.btnRockgame.Name = "btnRockgame";
            this.btnRockgame.Size = new System.Drawing.Size(64, 64);
            this.btnRockgame.TabIndex = 4;
            this.btnRockgame.UseVisualStyleBackColor = false;
            this.btnRockgame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // btnDirectory
            // 
            this.btnDirectory.BackColor = System.Drawing.Color.White;
            this.btnDirectory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectory.BackgroundImage")));
            this.btnDirectory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDirectory.Location = new System.Drawing.Point(84, 239);
            this.btnDirectory.Name = "btnDirectory";
            this.btnDirectory.Size = new System.Drawing.Size(64, 64);
            this.btnDirectory.TabIndex = 3;
            this.btnDirectory.UseVisualStyleBackColor = false;
            this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackColor = System.Drawing.Color.White;
            this.btnCalculator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculator.BackgroundImage")));
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCalculator.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculator.Location = new System.Drawing.Point(50, 169);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(64, 64);
            this.btnCalculator.TabIndex = 2;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnWeatherForecast
            // 
            this.btnWeatherForecast.BackColor = System.Drawing.Color.White;
            this.btnWeatherForecast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnWeatherForecast.BackgroundImage")));
            this.btnWeatherForecast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnWeatherForecast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeatherForecast.Location = new System.Drawing.Point(190, 169);
            this.btnWeatherForecast.Name = "btnWeatherForecast";
            this.btnWeatherForecast.Size = new System.Drawing.Size(64, 64);
            this.btnWeatherForecast.TabIndex = 5;
            this.btnWeatherForecast.UseVisualStyleBackColor = false;
            this.btnWeatherForecast.Click += new System.EventHandler(this.btnWeatherForecast_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(120, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(299, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnWeatherForecast);
            this.Controls.Add(this.btnRockgame);
            this.Controls.Add(this.btnDirectory);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.clock);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clock;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.Button btnDirectory;
        private System.Windows.Forms.Button btnRockgame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnWeatherForecast;
        private System.Windows.Forms.Button button1;
    }
}

