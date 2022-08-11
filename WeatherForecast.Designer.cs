namespace os_form
{
    partial class WeatherForecast
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
            this.lblTemperature = new System.Windows.Forms.Label();
            this.cbxCityName = new System.Windows.Forms.ComboBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTemperature.Location = new System.Drawing.Point(31, 214);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(159, 25);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "İstanbul derece";
            // 
            // cbxCityName
            // 
            this.cbxCityName.FormattingEnabled = true;
            this.cbxCityName.Location = new System.Drawing.Point(36, 148);
            this.cbxCityName.Name = "cbxCityName";
            this.cbxCityName.Size = new System.Drawing.Size(186, 21);
            this.cbxCityName.TabIndex = 2;
            this.cbxCityName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWind.Location = new System.Drawing.Point(31, 248);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(154, 25);
            this.lblWind.TabIndex = 3;
            this.lblWind.Text = "İstanbul rüzgar";
            // 
            // WeatherForecast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 461);
            this.Controls.Add(this.lblWind);
            this.Controls.Add(this.cbxCityName);
            this.Controls.Add(this.lblTemperature);
            this.Name = "WeatherForecast";
            this.Text = "WeatherForecast";
            this.Load += new System.EventHandler(this.WeatherForecast_Load);
            this.Leave += new System.EventHandler(this.WeatherForecast_Leave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.ComboBox cbxCityName;
        private System.Windows.Forms.Label lblWind;
    }
}