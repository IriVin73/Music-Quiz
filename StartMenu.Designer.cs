
namespace EDP_MusicQuiz
{
    partial class StartMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lstCategories = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(101, 48);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(631, 62);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Welcome to the Music Quiz";
            // 
            // lstCategories
            // 
            this.lstCategories.BackColor = System.Drawing.Color.AliceBlue;
            this.lstCategories.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCategories.FormattingEnabled = true;
            this.lstCategories.ItemHeight = 28;
            this.lstCategories.Items.AddRange(new object[] {
            "Christmas Music",
            "Country Music",
            "Indie Rock Music",
            "Pop Music",
            "RnB Music"});
            this.lstCategories.Location = new System.Drawing.Point(581, 231);
            this.lstCategories.Name = "lstCategories";
            this.lstCategories.Size = new System.Drawing.Size(199, 144);
            this.lstCategories.TabIndex = 1;
            this.lstCategories.SelectedIndexChanged += new System.EventHandler(this.CategorySelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(576, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a category of music";
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.LightCyan;
            this.btnStartQuiz.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartQuiz.Font = new System.Drawing.Font("Segoe UI Historic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartQuiz.ForeColor = System.Drawing.Color.Black;
            this.btnStartQuiz.Location = new System.Drawing.Point(348, 296);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(157, 65);
            this.btnStartQuiz.TabIndex = 3;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            this.btnStartQuiz.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartQuiz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstCategories);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ListBox lstCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartQuiz;
    }
}

