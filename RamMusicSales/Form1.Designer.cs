namespace RamMusicSales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblPlays = new Label();
            lblSong = new Label();
            txtPlays = new TextBox();
            txtSong = new TextBox();
            lstCalc = new ListBox();
            rbtnGenre1 = new RadioButton();
            rbtnGenre2 = new RadioButton();
            rbtnGenre3 = new RadioButton();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(374, 31);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(479, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Streaming Numbers Calculator";
            lblTitle.Click += label1_Click;
            // 
            // lblPlays
            // 
            lblPlays.AutoSize = true;
            lblPlays.Location = new Point(74, 149);
            lblPlays.Name = "lblPlays";
            lblPlays.Size = new Size(191, 32);
            lblPlays.TabIndex = 1;
            lblPlays.Text = "Number of Plays";
            // 
            // lblSong
            // 
            lblSong.AutoSize = true;
            lblSong.Location = new Point(77, 243);
            lblSong.Name = "lblSong";
            lblSong.Size = new Size(152, 32);
            lblSong.TabIndex = 2;
            lblSong.Text = "Cost of Song";
            // 
            // txtPlays
            // 
            txtPlays.Location = new Point(330, 142);
            txtPlays.Name = "txtPlays";
            txtPlays.Size = new Size(317, 39);
            txtPlays.TabIndex = 3;
            // 
            // txtSong
            // 
            txtSong.Location = new Point(330, 236);
            txtSong.Name = "txtSong";
            txtSong.Size = new Size(317, 39);
            txtSong.TabIndex = 4;
            // 
            // lstCalc
            // 
            lstCalc.FormattingEnabled = true;
            lstCalc.Location = new Point(229, 461);
            lstCalc.Name = "lstCalc";
            lstCalc.Size = new Size(569, 100);
            lstCalc.TabIndex = 5;
            // 
            // rbtnGenre1
            // 
            rbtnGenre1.AutoSize = true;
            rbtnGenre1.Location = new Point(195, 309);
            rbtnGenre1.Name = "rbtnGenre1";
            rbtnGenre1.Size = new Size(122, 36);
            rbtnGenre1.TabIndex = 6;
            rbtnGenre1.TabStop = true;
            rbtnGenre1.Text = "Genre1";
            rbtnGenre1.UseVisualStyleBackColor = true;
            // 
            // rbtnGenre2
            // 
            rbtnGenre2.AutoSize = true;
            rbtnGenre2.Location = new Point(195, 351);
            rbtnGenre2.Name = "rbtnGenre2";
            rbtnGenre2.Size = new Size(122, 36);
            rbtnGenre2.TabIndex = 7;
            rbtnGenre2.TabStop = true;
            rbtnGenre2.Text = "Genre2";
            rbtnGenre2.UseVisualStyleBackColor = true;
            // 
            // rbtnGenre3
            // 
            rbtnGenre3.AutoSize = true;
            rbtnGenre3.Location = new Point(195, 393);
            rbtnGenre3.Name = "rbtnGenre3";
            rbtnGenre3.Size = new Size(122, 36);
            rbtnGenre3.TabIndex = 8;
            rbtnGenre3.TabStop = true;
            rbtnGenre3.Text = "Genre3";
            rbtnGenre3.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(61, 607);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(191, 92);
            btnCalc.TabIndex = 9;
            btnCalc.Text = "&Press to calculate Music Sales";
            btnCalc.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 599);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(228, 100);
            btnClear.TabIndex = 10;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(817, 599);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(233, 100);
            btnQuit.TabIndex = 11;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 779);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(rbtnGenre3);
            Controls.Add(rbtnGenre2);
            Controls.Add(rbtnGenre1);
            Controls.Add(lstCalc);
            Controls.Add(txtSong);
            Controls.Add(txtPlays);
            Controls.Add(lblSong);
            Controls.Add(lblPlays);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Ramcharan";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblPlays;
        private Label lblSong;
        private TextBox txtPlays;
        private TextBox txtSong;
        private ListBox lstCalc;
        private RadioButton rbtnGenre1;
        private RadioButton rbtnGenre2;
        private RadioButton rbtnGenre3;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
    }
}
