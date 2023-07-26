using BackGammonProject.Properties;

namespace BackGammonProject
{
    partial class gameWindow
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
            this.die1Picture = new System.Windows.Forms.PictureBox();
            this.die2Picture = new System.Windows.Forms.PictureBox();
            this.player1Label = new System.Windows.Forms.Label();
            this.player2Label = new System.Windows.Forms.Label();
            this.rollBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.pieseAlbeScoaseImg = new System.Windows.Forms.PictureBox();
            this.pieseNegreScoaseImg = new System.Windows.Forms.PictureBox();
            this.pieseNegreEliminateImg = new System.Windows.Forms.PictureBox();
            this.pieseAlbeEliminateImg = new System.Windows.Forms.PictureBox();
            this.pieseNegreScoaseLabel = new System.Windows.Forms.Label();
            this.pieseAlbeScoaseLabel = new System.Windows.Forms.Label();
            this.pieseNegreEliminateLabel = new System.Windows.Forms.Label();
            this.pieseAlbeEliminateLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.die1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAlbeScoaseImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseNegreScoaseImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseNegreEliminateImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAlbeEliminateImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // die1Picture
            // 
            this.die1Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.die1Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.die1Picture.Image = global::BackGammonProject.Properties.Resources.Die6;
            this.die1Picture.Location = new System.Drawing.Point(1231, 374);
            this.die1Picture.Margin = new System.Windows.Forms.Padding(4);
            this.die1Picture.Name = "die1Picture";
            this.die1Picture.Size = new System.Drawing.Size(87, 84);
            this.die1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die1Picture.TabIndex = 0;
            this.die1Picture.TabStop = false;
            // 
            // die2Picture
            // 
            this.die2Picture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.die2Picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.die2Picture.Image = global::BackGammonProject.Properties.Resources.Die6;
            this.die2Picture.Location = new System.Drawing.Point(1128, 374);
            this.die2Picture.Margin = new System.Windows.Forms.Padding(4);
            this.die2Picture.Name = "die2Picture";
            this.die2Picture.Size = new System.Drawing.Size(88, 84);
            this.die2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.die2Picture.TabIndex = 1;
            this.die2Picture.TabStop = false;
            // 
            // player1Label
            // 
            this.player1Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player1Label.AutoSize = true;
            this.player1Label.BackColor = System.Drawing.Color.Yellow;
            this.player1Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.Color.Black;
            this.player1Label.Location = new System.Drawing.Point(1144, 130);
            this.player1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(163, 23);
            this.player1Label.TabIndex = 2;
            this.player1Label.Text = "PLAYER2(Negre)";
            // 
            // player2Label
            // 
            this.player2Label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.player2Label.AutoSize = true;
            this.player2Label.BackColor = System.Drawing.Color.Yellow;
            this.player2Label.Cursor = System.Windows.Forms.Cursors.Default;
            this.player2Label.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.Location = new System.Drawing.Point(1144, 624);
            this.player2Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(150, 23);
            this.player2Label.TabIndex = 3;
            this.player2Label.Text = "PLAYER1(Albe)";
            // 
            // rollBtn
            // 
            this.rollBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rollBtn.Location = new System.Drawing.Point(1156, 306);
            this.rollBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rollBtn.Name = "rollBtn";
            this.rollBtn.Size = new System.Drawing.Size(125, 44);
            this.rollBtn.TabIndex = 6;
            this.rollBtn.Text = "Roll Dice!";
            this.rollBtn.UseVisualStyleBackColor = true;
            this.rollBtn.Click += new System.EventHandler(this.RollBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.exitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitBtn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exitBtn.Location = new System.Drawing.Point(1207, 733);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(100, 38);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "E&xit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // pieseAlbeScoaseImg
            // 
            this.pieseAlbeScoaseImg.BackColor = System.Drawing.Color.Transparent;
            this.pieseAlbeScoaseImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieseAlbeScoaseImg.Location = new System.Drawing.Point(505, 449);
            this.pieseAlbeScoaseImg.Margin = new System.Windows.Forms.Padding(4);
            this.pieseAlbeScoaseImg.MaximumSize = new System.Drawing.Size(83, 63);
            this.pieseAlbeScoaseImg.MinimumSize = new System.Drawing.Size(83, 63);
            this.pieseAlbeScoaseImg.Name = "pieseAlbeScoaseImg";
            this.pieseAlbeScoaseImg.Size = new System.Drawing.Size(83, 63);
            this.pieseAlbeScoaseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pieseAlbeScoaseImg.TabIndex = 8;
            this.pieseAlbeScoaseImg.TabStop = false;
            this.pieseAlbeScoaseImg.Click += new System.EventHandler(this.PieseAlbeScoaseImg_Click);
            // 
            // pieseNegreScoaseImg
            // 
            this.pieseNegreScoaseImg.BackColor = System.Drawing.Color.Transparent;
            this.pieseNegreScoaseImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieseNegreScoaseImg.Location = new System.Drawing.Point(505, 326);
            this.pieseNegreScoaseImg.Margin = new System.Windows.Forms.Padding(4);
            this.pieseNegreScoaseImg.MaximumSize = new System.Drawing.Size(83, 63);
            this.pieseNegreScoaseImg.MinimumSize = new System.Drawing.Size(83, 63);
            this.pieseNegreScoaseImg.Name = "pieseNegreScoaseImg";
            this.pieseNegreScoaseImg.Size = new System.Drawing.Size(83, 63);
            this.pieseNegreScoaseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pieseNegreScoaseImg.TabIndex = 9;
            this.pieseNegreScoaseImg.TabStop = false;
            this.pieseNegreScoaseImg.Click += new System.EventHandler(this.PieseNegreScoaseImg_Click);
            // 
            // pieseNegreEliminateImg
            // 
            this.pieseNegreEliminateImg.BackColor = System.Drawing.Color.Transparent;
            this.pieseNegreEliminateImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieseNegreEliminateImg.Location = new System.Drawing.Point(1175, 174);
            this.pieseNegreEliminateImg.Margin = new System.Windows.Forms.Padding(4);
            this.pieseNegreEliminateImg.MaximumSize = new System.Drawing.Size(83, 63);
            this.pieseNegreEliminateImg.MinimumSize = new System.Drawing.Size(83, 63);
            this.pieseNegreEliminateImg.Name = "pieseNegreEliminateImg";
            this.pieseNegreEliminateImg.Size = new System.Drawing.Size(83, 63);
            this.pieseNegreEliminateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pieseNegreEliminateImg.TabIndex = 10;
            this.pieseNegreEliminateImg.TabStop = false;
            this.pieseNegreEliminateImg.Click += new System.EventHandler(this.PieseNegreEliminateImg_Click);
            // 
            // pieseAlbeEliminateImg
            // 
            this.pieseAlbeEliminateImg.BackColor = System.Drawing.Color.Transparent;
            this.pieseAlbeEliminateImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pieseAlbeEliminateImg.Location = new System.Drawing.Point(1175, 662);
            this.pieseAlbeEliminateImg.Margin = new System.Windows.Forms.Padding(4);
            this.pieseAlbeEliminateImg.MaximumSize = new System.Drawing.Size(83, 63);
            this.pieseAlbeEliminateImg.MinimumSize = new System.Drawing.Size(83, 63);
            this.pieseAlbeEliminateImg.Name = "pieseAlbeEliminateImg";
            this.pieseAlbeEliminateImg.Size = new System.Drawing.Size(83, 63);
            this.pieseAlbeEliminateImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pieseAlbeEliminateImg.TabIndex = 11;
            this.pieseAlbeEliminateImg.TabStop = false;
            this.pieseAlbeEliminateImg.Click += new System.EventHandler(this.PieseAlbeEliminateImg_Click);
            // 
            // pieseNegreScoaseLabel
            // 
            this.pieseNegreScoaseLabel.AutoSize = true;
            this.pieseNegreScoaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pieseNegreScoaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieseNegreScoaseLabel.ForeColor = System.Drawing.Color.White;
            this.pieseNegreScoaseLabel.Location = new System.Drawing.Point(535, 306);
            this.pieseNegreScoaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pieseNegreScoaseLabel.Name = "pieseNegreScoaseLabel";
            this.pieseNegreScoaseLabel.Size = new System.Drawing.Size(0, 17);
            this.pieseNegreScoaseLabel.TabIndex = 12;
            // 
            // pieseAlbeScoaseLabel
            // 
            this.pieseAlbeScoaseLabel.AutoSize = true;
            this.pieseAlbeScoaseLabel.BackColor = System.Drawing.Color.Transparent;
            this.pieseAlbeScoaseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieseAlbeScoaseLabel.ForeColor = System.Drawing.Color.White;
            this.pieseAlbeScoaseLabel.Location = new System.Drawing.Point(535, 430);
            this.pieseAlbeScoaseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pieseAlbeScoaseLabel.Name = "pieseAlbeScoaseLabel";
            this.pieseAlbeScoaseLabel.Size = new System.Drawing.Size(0, 17);
            this.pieseAlbeScoaseLabel.TabIndex = 13;
            // 
            // pieseNegreEliminateLabel
            // 
            this.pieseNegreEliminateLabel.AutoSize = true;
            this.pieseNegreEliminateLabel.BackColor = System.Drawing.Color.Transparent;
            this.pieseNegreEliminateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieseNegreEliminateLabel.ForeColor = System.Drawing.Color.White;
            this.pieseNegreEliminateLabel.Location = new System.Drawing.Point(1108, 74);
            this.pieseNegreEliminateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pieseNegreEliminateLabel.Name = "pieseNegreEliminateLabel";
            this.pieseNegreEliminateLabel.Size = new System.Drawing.Size(0, 17);
            this.pieseNegreEliminateLabel.TabIndex = 14;
            // 
            // pieseAlbeEliminateLabel
            // 
            this.pieseAlbeEliminateLabel.AutoSize = true;
            this.pieseAlbeEliminateLabel.BackColor = System.Drawing.Color.Transparent;
            this.pieseAlbeEliminateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pieseAlbeEliminateLabel.ForeColor = System.Drawing.Color.White;
            this.pieseAlbeEliminateLabel.Location = new System.Drawing.Point(1108, 430);
            this.pieseAlbeEliminateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pieseAlbeEliminateLabel.Name = "pieseAlbeEliminateLabel";
            this.pieseAlbeEliminateLabel.Size = new System.Drawing.Size(0, 17);
            this.pieseAlbeEliminateLabel.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(1079, 609);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(57, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Location = new System.Drawing.Point(1079, 116);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // gameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BackGammonProject.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1344, 838);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pieseAlbeEliminateLabel);
            this.Controls.Add(this.pieseNegreEliminateLabel);
            this.Controls.Add(this.pieseAlbeScoaseLabel);
            this.Controls.Add(this.pieseNegreScoaseLabel);
            this.Controls.Add(this.pieseAlbeEliminateImg);
            this.Controls.Add(this.pieseNegreEliminateImg);
            this.Controls.Add(this.pieseNegreScoaseImg);
            this.Controls.Add(this.pieseAlbeScoaseImg);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.rollBtn);
            this.Controls.Add(this.player2Label);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.die2Picture);
            this.Controls.Add(this.die1Picture);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::BackGammonProject.Properties.Resources.logoICO;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "gameWindow";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.gameWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.die1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.die2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAlbeScoaseImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseNegreScoaseImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseNegreEliminateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pieseAlbeEliminateImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox die1Picture;
        private System.Windows.Forms.PictureBox die2Picture;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Button rollBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.PictureBox pieseAlbeScoaseImg;
        private System.Windows.Forms.PictureBox pieseNegreScoaseImg;
        private System.Windows.Forms.PictureBox pieseNegreEliminateImg;
        private System.Windows.Forms.PictureBox pieseAlbeEliminateImg;
        private System.Windows.Forms.Label pieseNegreScoaseLabel;
        private System.Windows.Forms.Label pieseAlbeScoaseLabel;
        private System.Windows.Forms.Label pieseNegreEliminateLabel;
        private System.Windows.Forms.Label pieseAlbeEliminateLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}