namespace Space_Race
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.player2Label = new System.Windows.Forms.Label();
            this.player1Label = new System.Windows.Forms.Label();
            this.countTimer = new System.Windows.Forms.Timer(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.startPreTimer = new System.Windows.Forms.Timer(this.components);
            this.yesButton = new System.Windows.Forms.Button();
            this.noButton = new System.Windows.Forms.Button();
            this.player1bomb_Pic = new System.Windows.Forms.PictureBox();
            this.player2bomb_Pic = new System.Windows.Forms.PictureBox();
            this.player1bombTimer = new System.Windows.Forms.Timer(this.components);
            this.player2bombTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player1bomb_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2bomb_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 35;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // player2Label
            // 
            this.player2Label.AutoSize = true;
            this.player2Label.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player2Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player2Label.Location = new System.Drawing.Point(652, 446);
            this.player2Label.Name = "player2Label";
            this.player2Label.Size = new System.Drawing.Size(58, 56);
            this.player2Label.TabIndex = 0;
            this.player2Label.Text = "0";
            this.player2Label.Visible = false;
            // 
            // player1Label
            // 
            this.player1Label.AutoSize = true;
            this.player1Label.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player1Label.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.player1Label.Location = new System.Drawing.Point(3, 446);
            this.player1Label.Name = "player1Label";
            this.player1Label.Size = new System.Drawing.Size(58, 56);
            this.player1Label.TabIndex = 1;
            this.player1Label.Text = "0";
            this.player1Label.Visible = false;
            // 
            // countTimer
            // 
            this.countTimer.Interval = 500;
            this.countTimer.Tick += new System.EventHandler(this.countTimer_Tick);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.titleLabel.Location = new System.Drawing.Point(174, 320);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(353, 34);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "Press “SPACE” to start the game";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yesButton
            // 
            this.yesButton.Enabled = false;
            this.yesButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yesButton.Location = new System.Drawing.Point(206, 397);
            this.yesButton.Name = "yesButton";
            this.yesButton.Size = new System.Drawing.Size(118, 28);
            this.yesButton.TabIndex = 4;
            this.yesButton.Text = "YES";
            this.yesButton.UseVisualStyleBackColor = true;
            this.yesButton.Visible = false;
            this.yesButton.Click += new System.EventHandler(this.yesButton_Click);
            // 
            // noButton
            // 
            this.noButton.Enabled = false;
            this.noButton.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noButton.Location = new System.Drawing.Point(377, 397);
            this.noButton.Name = "noButton";
            this.noButton.Size = new System.Drawing.Size(118, 28);
            this.noButton.TabIndex = 5;
            this.noButton.Text = "NO";
            this.noButton.UseVisualStyleBackColor = true;
            this.noButton.Visible = false;
            this.noButton.Click += new System.EventHandler(this.noButton_Click);
            // 
            // player1bomb_Pic
            // 
            this.player1bomb_Pic.BackColor = System.Drawing.Color.Transparent;
            this.player1bomb_Pic.BackgroundImage = global::Space_Race.Properties.Resources.bomb_Image;
            this.player1bomb_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player1bomb_Pic.Location = new System.Drawing.Point(195, 96);
            this.player1bomb_Pic.Name = "player1bomb_Pic";
            this.player1bomb_Pic.Size = new System.Drawing.Size(28, 35);
            this.player1bomb_Pic.TabIndex = 6;
            this.player1bomb_Pic.TabStop = false;
            this.player1bomb_Pic.Visible = false;
            // 
            // player2bomb_Pic
            // 
            this.player2bomb_Pic.BackColor = System.Drawing.Color.Transparent;
            this.player2bomb_Pic.BackgroundImage = global::Space_Race.Properties.Resources.bomb_Image;
            this.player2bomb_Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.player2bomb_Pic.Location = new System.Drawing.Point(238, 96);
            this.player2bomb_Pic.Name = "player2bomb_Pic";
            this.player2bomb_Pic.Size = new System.Drawing.Size(28, 35);
            this.player2bomb_Pic.TabIndex = 7;
            this.player2bomb_Pic.TabStop = false;
            this.player2bomb_Pic.Visible = false;
            // 
            // player1bombTimer
            // 
            this.player1bombTimer.Tick += new System.EventHandler(this.player1bombTimer_Tick);
            // 
            // player2bombTimer
            // 
            this.player2bombTimer.Tick += new System.EventHandler(this.player2bombTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Space_Race.Properties.Resources.menu_Image;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.Controls.Add(this.player2bomb_Pic);
            this.Controls.Add(this.player1bomb_Pic);
            this.Controls.Add(this.noButton);
            this.Controls.Add(this.yesButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.player1Label);
            this.Controls.Add(this.player2Label);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player1bomb_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2bomb_Pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label player2Label;
        private System.Windows.Forms.Label player1Label;
        private System.Windows.Forms.Timer countTimer;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Timer startPreTimer;
        private System.Windows.Forms.Button yesButton;
        private System.Windows.Forms.Button noButton;
        private System.Windows.Forms.PictureBox player1bomb_Pic;
        private System.Windows.Forms.PictureBox player2bomb_Pic;
        private System.Windows.Forms.Timer player1bombTimer;
        private System.Windows.Forms.Timer player2bombTimer;
    }
}

