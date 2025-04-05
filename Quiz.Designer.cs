
namespace EDP_MusicQuiz
{
    partial class Quiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quiz));
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblSongNo = new System.Windows.Forms.Label();
            this.lblArtist = new System.Windows.Forms.Label();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCheckAnswer = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.rtbInstructions = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(46, 36);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(155, 31);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Heading Here";
            // 
            // lblSongNo
            // 
            this.lblSongNo.AutoSize = true;
            this.lblSongNo.BackColor = System.Drawing.Color.Transparent;
            this.lblSongNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSongNo.Location = new System.Drawing.Point(54, 78);
            this.lblSongNo.Name = "lblSongNo";
            this.lblSongNo.Size = new System.Drawing.Size(90, 28);
            this.lblSongNo.TabIndex = 2;
            this.lblSongNo.Text = "Song No";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.BackColor = System.Drawing.Color.Transparent;
            this.lblArtist.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArtist.Location = new System.Drawing.Point(54, 122);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(68, 28);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "Artist: ";
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAnswer.Location = new System.Drawing.Point(57, 223);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(572, 34);
            this.txtAnswer.TabIndex = 4;
            this.txtAnswer.Text = "Enter Song Title Here";
            this.txtAnswer.Click += new System.EventHandler(this.AnswerClicked);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(54, 173);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(126, 28);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title (Initials):";
            // 
            // btnCheckAnswer
            // 
            this.btnCheckAnswer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCheckAnswer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCheckAnswer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCheckAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCheckAnswer.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckAnswer.Location = new System.Drawing.Point(635, 223);
            this.btnCheckAnswer.Name = "btnCheckAnswer";
            this.btnCheckAnswer.Size = new System.Drawing.Size(125, 29);
            this.btnCheckAnswer.TabIndex = 6;
            this.btnCheckAnswer.Text = "Check Answer";
            this.btnCheckAnswer.UseVisualStyleBackColor = false;
            this.btnCheckAnswer.Visible = false;
            this.btnCheckAnswer.Click += new System.EventHandler(this.CheckAnswer);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.Color.Transparent;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.White;
            this.lblResult.Location = new System.Drawing.Point(57, 276);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(68, 28);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Result:";
            this.lblResult.Visible = false;
            // 
            // btnNextSong
            // 
            this.btnNextSong.BackColor = System.Drawing.Color.LimeGreen;
            this.btnNextSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNextSong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNextSong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextSong.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextSong.Location = new System.Drawing.Point(635, 274);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(125, 29);
            this.btnNextSong.TabIndex = 9;
            this.btnNextSong.Text = "Next Song";
            this.btnNextSong.UseVisualStyleBackColor = false;
            this.btnNextSong.Visible = false;
            this.btnNextSong.Click += new System.EventHandler(this.NextSong);
            // 
            // rtbInstructions
            // 
            this.rtbInstructions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rtbInstructions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbInstructions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInstructions.Location = new System.Drawing.Point(501, 17);
            this.rtbInstructions.Name = "rtbInstructions";
            this.rtbInstructions.Size = new System.Drawing.Size(268, 183);
            this.rtbInstructions.TabIndex = 10;
            this.rtbInstructions.Text = resources.GetString("rtbInstructions.Text");
            // 
            // Quiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.rtbInstructions);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCheckAnswer);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.lblArtist);
            this.Controls.Add(this.lblSongNo);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI Historic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(54, 22);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Quiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblSongNo;
        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCheckAnswer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.RichTextBox rtbInstructions;
    }
}