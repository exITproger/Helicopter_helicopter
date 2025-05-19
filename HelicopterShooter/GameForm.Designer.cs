namespace HelicopterShooter
{
    partial class GameForm
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
            this.txtScore = new System.Windows.Forms.Label();
            this.pillar2 = new System.Windows.Forms.PictureBox();
            this.pillar1 = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.BackColor = System.Drawing.Color.Transparent;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtScore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtScore.Location = new System.Drawing.Point(43, 33);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(136, 37);
            this.txtScore.TabIndex = 5;
            this.txtScore.Text = "Score: 0";
            // 
            // pillar2
            // 
            this.pillar2.Image = global::HelicopterShooter.Properties.Resources.стенка;
            this.pillar2.Location = new System.Drawing.Point(1817, 649);
            this.pillar2.Name = "pillar2";
            this.pillar2.Size = new System.Drawing.Size(105, 433);
            this.pillar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar2.TabIndex = 8;
            this.pillar2.TabStop = false;
            this.pillar2.Tag = "pillar";
            // 
            // pillar1
            // 
            this.pillar1.BackColor = System.Drawing.Color.Transparent;
            this.pillar1.Image = global::HelicopterShooter.Properties.Resources.стенка;
            this.pillar1.Location = new System.Drawing.Point(952, -1);
            this.pillar1.Name = "pillar1";
            this.pillar1.Size = new System.Drawing.Size(105, 442);
            this.pillar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pillar1.TabIndex = 7;
            this.pillar1.TabStop = false;
            this.pillar1.Tag = "pillar";
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.Image = global::HelicopterShooter.Properties.Resources.Helicopter;
            this.picPlayer.Location = new System.Drawing.Point(5, 540);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(200, 90);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 6;
            this.picPlayer.TabStop = false;
            this.picPlayer.Tag = "player";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelicopterShooter.Properties.Resources.BackGroundMainInGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.ControlBox = false;
            this.Controls.Add(this.pillar2);
            this.Controls.Add(this.pillar1);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.txtScore);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.SkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameForm";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pillar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox pillar1;
        private System.Windows.Forms.PictureBox pillar2;
    }
}