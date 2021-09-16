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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.rock = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Button();
            this.sci = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rock
            // 
            this.rock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rock.BackgroundImage")));
            this.rock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.rock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rock.Location = new System.Drawing.Point(41, 227);
            this.rock.Name = "rock";
            this.rock.Size = new System.Drawing.Size(65, 65);
            this.rock.TabIndex = 0;
            this.rock.UseVisualStyleBackColor = true;
            this.rock.Click += new System.EventHandler(this.rock_click);
            // 
            // paper
            // 
            this.paper.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paper.BackgroundImage")));
            this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paper.Location = new System.Drawing.Point(112, 227);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(65, 65);
            this.paper.TabIndex = 1;
            this.paper.UseVisualStyleBackColor = true;
            this.paper.Click += new System.EventHandler(this.paper_Click);
            // 
            // sci
            // 
            this.sci.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sci.BackgroundImage")));
            this.sci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sci.Location = new System.Drawing.Point(183, 227);
            this.sci.Name = "sci";
            this.sci.Size = new System.Drawing.Size(65, 65);
            this.sci.TabIndex = 2;
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