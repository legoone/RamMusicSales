
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
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lblSongName = new Label();
            txtSongName = new TextBox();
            rbtnPop = new RadioButton();
            rbtnRock = new RadioButton();
            rbtnHipHop = new RadioButton();
            groupBox1 = new GroupBox();
            rbtnTechno = new RadioButton();
            rbtnJazz = new RadioButton();
            rbtnCountry = new RadioButton();
            btnsettings = new Button();
            btnDisplayLog = new Button();
            groupBox1.SuspendLayout();
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
            lblPlays.Location = new Point(86, 233);
            lblPlays.Name = "lblPlays";
            lblPlays.Size = new Size(191, 32);
            lblPlays.TabIndex = 1;
            lblPlays.Text = "Number of Plays";
            // 
            // lblSong
            // 
            lblSong.AutoSize = true;
            lblSong.Location = new Point(86, 303);
            lblSong.Name = "lblSong";
            lblSong.Size = new Size(152, 32);
            lblSong.TabIndex = 2;
            lblSong.Text = "Cost of Song";
            // 
            // txtPlays
            // 
            txtPlays.Location = new Point(330, 233);
            txtPlays.Name = "txtPlays";
            txtPlays.Size = new Size(317, 39);
            txtPlays.TabIndex = 1;
            txtPlays.Enter += txtPlays_Enter;
            txtPlays.Leave += txtPlays_Leave;
            // 
            // txtSong
            // 
            txtSong.Location = new Point(330, 303);
            txtSong.Name = "txtSong";
            txtSong.Size = new Size(317, 39);
            txtSong.TabIndex = 2;
            txtSong.TextChanged += txtSong_TextChanged;
            txtSong.Enter += txtSong_Enter;
            txtSong.Leave += txtSong_Leave;
            // 
            // lstCalc
            // 
            lstCalc.FormattingEnabled = true;
            lstCalc.Location = new Point(374, 390);
            lstCalc.Name = "lstCalc";
            lstCalc.Size = new Size(733, 452);
            lstCalc.TabIndex = 5;
            lstCalc.TabStop = false;
            lstCalc.SelectedIndexChanged += lstCalc_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(104, 966);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(191, 92);
            btnCalc.TabIndex = 7;
            btnCalc.Text = "Calculate &Music Sales";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(476, 962);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(228, 100);
            btnClear.TabIndex = 8;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(856, 958);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(233, 100);
            btnQuit.TabIndex = 9;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblSongName
            // 
            lblSongName.AutoSize = true;
            lblSongName.Location = new Point(86, 149);
            lblSongName.Name = "lblSongName";
            lblSongName.Size = new Size(140, 32);
            lblSongName.TabIndex = 12;
            lblSongName.Text = "Song Name";
            // 
            // txtSongName
            // 
            txtSongName.Location = new Point(330, 149);
            txtSongName.Name = "txtSongName";
            txtSongName.Size = new Size(320, 39);
            txtSongName.TabIndex = 0;
            txtSongName.TextChanged += txtSongName_TextChanged;
            txtSongName.Enter += txtSongName_Enter;
            txtSongName.Leave += txtSongName_Leave;
            // 
            // rbtnPop
            // 
            rbtnPop.AutoSize = true;
            rbtnPop.Location = new Point(0, 101);
            rbtnPop.Name = "rbtnPop";
            rbtnPop.Size = new Size(85, 36);
            rbtnPop.TabIndex = 6;
            rbtnPop.TabStop = true;
            rbtnPop.Text = "Pop";
            rbtnPop.UseVisualStyleBackColor = true;
            rbtnPop.CheckedChanged += rbtnPop_CheckedChanged;
            // 
            // rbtnRock
            // 
            rbtnRock.AutoSize = true;
            rbtnRock.Location = new Point(0, 59);
            rbtnRock.Name = "rbtnRock";
            rbtnRock.Size = new Size(95, 36);
            rbtnRock.TabIndex = 5;
            rbtnRock.TabStop = true;
            rbtnRock.Text = "Rock";
            rbtnRock.UseVisualStyleBackColor = true;
            rbtnRock.CheckedChanged += rbtnRock_CheckedChanged;
            // 
            // rbtnHipHop
            // 
            rbtnHipHop.AutoSize = true;
            rbtnHipHop.Location = new Point(0, 17);
            rbtnHipHop.Name = "rbtnHipHop";
            rbtnHipHop.Size = new Size(137, 36);
            rbtnHipHop.TabIndex = 4;
            rbtnHipHop.TabStop = true;
            rbtnHipHop.Text = "Hip-Hop";
            rbtnHipHop.UseVisualStyleBackColor = true;
            rbtnHipHop.CheckedChanged += rbtnGenre1_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtnTechno);
            groupBox1.Controls.Add(rbtnJazz);
            groupBox1.Controls.Add(rbtnCountry);
            groupBox1.Controls.Add(rbtnRock);
            groupBox1.Controls.Add(rbtnHipHop);
            groupBox1.Controls.Add(rbtnPop);
            groupBox1.Location = new Point(45, 390);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(262, 279);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // rbtnTechno
            // 
            rbtnTechno.AutoSize = true;
            rbtnTechno.Location = new Point(0, 222);
            rbtnTechno.Name = "rbtnTechno";
            rbtnTechno.Size = new Size(122, 36);
            rbtnTechno.TabIndex = 9;
            rbtnTechno.TabStop = true;
            rbtnTechno.Text = "Techno";
            rbtnTechno.UseVisualStyleBackColor = true;
            rbtnTechno.CheckedChanged += rbtnTechno_CheckedChanged;
            // 
            // rbtnJazz
            // 
            rbtnJazz.AutoSize = true;
            rbtnJazz.Location = new Point(-1, 180);
            rbtnJazz.Name = "rbtnJazz";
            rbtnJazz.Size = new Size(88, 36);
            rbtnJazz.TabIndex = 8;
            rbtnJazz.TabStop = true;
            rbtnJazz.Text = "Jazz";
            rbtnJazz.UseVisualStyleBackColor = true;
            rbtnJazz.CheckedChanged += rbtnJazz_CheckedChanged;
            // 
            // rbtnCountry
            // 
            rbtnCountry.AutoSize = true;
            rbtnCountry.Location = new Point(0, 143);
            rbtnCountry.Name = "rbtnCountry";
            rbtnCountry.Size = new Size(130, 36);
            rbtnCountry.TabIndex = 7;
            rbtnCountry.TabStop = true;
            rbtnCountry.Text = "Country";
            rbtnCountry.UseVisualStyleBackColor = true;
            rbtnCountry.CheckedChanged += rbtnCountry_CheckedChanged;
            // 
            // btnsettings
            // 
            btnsettings.Location = new Point(990, 86);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(149, 52);
            btnsettings.TabIndex = 13;
            btnsettings.Text = "&Settings";
            btnsettings.UseVisualStyleBackColor = true;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnDisplayLog
            // 
            btnDisplayLog.Location = new Point(989, 34);
            btnDisplayLog.Name = "btnDisplayLog";
            btnDisplayLog.Size = new Size(150, 46);
            btnDisplayLog.TabIndex = 14;
            btnDisplayLog.Text = "&Log";
            btnDisplayLog.UseVisualStyleBackColor = true;
            btnDisplayLog.Click += btnDisplayLog_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1166, 1175);
            Controls.Add(btnDisplayLog);
            Controls.Add(btnsettings);
            Controls.Add(groupBox1);
            Controls.Add(txtSongName);
            Controls.Add(lblSongName);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstCalc);
            Controls.Add(txtSong);
            Controls.Add(txtPlays);
            Controls.Add(lblSong);
            Controls.Add(lblPlays);
            Controls.Add(lblTitle);
            Name = "Form1";
            Text = "Ramcharan";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private Label lblTitle;
        private Label lblPlays;
        private Label lblSong;
        private TextBox txtPlays;
        private ListBox lstCalc;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private TextBox txtSong;
        private Label lblSongName;
        private TextBox txtSongName;
        private RadioButton rbtnPop;
        private RadioButton rbtnRock;
        private RadioButton rbtnHipHop;
        private GroupBox groupBox1;
        private RadioButton rbtnJazz;
        private RadioButton rbtnCountry;
        private RadioButton rbtnTechno;
        private Button btnsettings;
        private Button btnDisplayLog;
    }
}
