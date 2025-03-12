namespace MagicEightBall
{
    partial class MagicEightBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MagicEightBall));
            this.txtBoxUser = new System.Windows.Forms.TextBox();
            this.pbMagicBall = new System.Windows.Forms.PictureBox();
            this.lbViewChat = new System.Windows.Forms.ListBox();
            this.btnEnter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicBall)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxUser
            // 
            this.txtBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxUser.Location = new System.Drawing.Point(242, 185);
            this.txtBoxUser.Multiline = true;
            this.txtBoxUser.Name = "txtBoxUser";
            this.txtBoxUser.Size = new System.Drawing.Size(285, 50);
            this.txtBoxUser.TabIndex = 0;
            this.txtBoxUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBoxUser_KeyPress);
            // 
            // pbMagicBall
            // 
            this.pbMagicBall.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbMagicBall.BackgroundImage")));
            this.pbMagicBall.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbMagicBall.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbMagicBall.InitialImage")));
            this.pbMagicBall.Location = new System.Drawing.Point(28, 12);
            this.pbMagicBall.Name = "pbMagicBall";
            this.pbMagicBall.Size = new System.Drawing.Size(157, 151);
            this.pbMagicBall.TabIndex = 3;
            this.pbMagicBall.TabStop = false;
            // 
            // lbViewChat
            // 
            this.lbViewChat.FormattingEnabled = true;
            this.lbViewChat.Location = new System.Drawing.Point(242, 12);
            this.lbViewChat.Name = "lbViewChat";
            this.lbViewChat.Size = new System.Drawing.Size(356, 147);
            this.lbViewChat.TabIndex = 4;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(534, 185);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(64, 50);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // MagicEightBall
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 256);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lbViewChat);
            this.Controls.Add(this.pbMagicBall);
            this.Controls.Add(this.txtBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MagicEightBall";
            this.Text = "Magic 8 Ball";
            ((System.ComponentModel.ISupportInitialize)(this.pbMagicBall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxUser;
        private System.Windows.Forms.PictureBox pbMagicBall;
        private System.Windows.Forms.ListBox lbViewChat;
        private System.Windows.Forms.Button btnEnter;
    }
}

