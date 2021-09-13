namespace os_form
{
    partial class Game
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
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.sci = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rock.Location = new System.Drawing.Point(41, 227);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(65, 65);
            this.rock.TabIndex = 0;
            this.rock.Text = "Taş";
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_click);
            // 
            // paper
            // 
            this.paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paper.Location = new System.Drawing.Point(112, 227);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(65, 65);
            this.paper.TabIndex = 1;
            this.paper.Text = "Kağıt";
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // sci
            // 
            this.sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sci.Location = new System.Drawing.Point(183, 227);
            this.sci.Name = "sci";
            this.sci.Size = new System.Drawing.Size(65, 65);
            this.sci.TabIndex = 2;
            this.sci.Text = "Makas";
            this.sci.UseVisualStyleBackColor = true;
            this.sci.Click += new System.EventHandler(this.sci_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.messageLabel.Location = new System.Drawing.Point(35, 73);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(187, 25);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "Seçiminizi Yapınız";
            this.messageLabel.Click += new System.EventHandler(this.messageLabel_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 461);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sci);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.rock);
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button rock;
        private System.Windows.Forms.Button paper;
        private System.Windows.Forms.Button sci;
        private System.Windows.Forms.Label messageLabel;
    }
}