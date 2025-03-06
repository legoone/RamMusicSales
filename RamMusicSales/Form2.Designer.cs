namespace RamMusicSales
{
    partial class Form2
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
            lblHipHop = new Label();
            lblRock = new Label();
            lblPop = new Label();
            lblJazz = new Label();
            lblCountry = new Label();
            lblTechno = new Label();
            btnSetReturn = new Button();
            txtHipHop = new TextBox();
            txtRock = new TextBox();
            txtPop = new TextBox();
            txtJazz = new TextBox();
            txtTechno = new TextBox();
            txtCountry = new TextBox();
            SuspendLayout();
            // 
            // lblHipHop
            // 
            lblHipHop.AutoSize = true;
            lblHipHop.Location = new Point(115, 161);
            lblHipHop.Name = "lblHipHop";
            lblHipHop.Size = new Size(106, 32);
            lblHipHop.TabIndex = 11;
            lblHipHop.Text = "Hip-Hop";
            // 
            // lblRock
            // 
            lblRock.AutoSize = true;
            lblRock.Location = new Point(115, 226);
            lblRock.Name = "lblRock";
            lblRock.Size = new Size(64, 32);
            lblRock.TabIndex = 12;
            lblRock.Text = "Rock";
            // 
            // lblPop
            // 
            lblPop.AutoSize = true;
            lblPop.Location = new Point(115, 287);
            lblPop.Name = "lblPop";
            lblPop.Size = new Size(54, 32);
            lblPop.TabIndex = 13;
            lblPop.Text = "Pop";
            // 
            // lblJazz
            // 
            lblJazz.AutoSize = true;
            lblJazz.Location = new Point(115, 347);
            lblJazz.Name = "lblJazz";
            lblJazz.Size = new Size(57, 32);
            lblJazz.TabIndex = 14;
            lblJazz.Text = "Jazz";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Location = new Point(115, 476);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(99, 32);
            lblCountry.TabIndex = 15;
            lblCountry.Text = "Country";
            // 
            // lblTechno
            // 
            lblTechno.AutoSize = true;
            lblTechno.Location = new Point(115, 408);
            lblTechno.Name = "lblTechno";
            lblTechno.Size = new Size(91, 32);
            lblTechno.TabIndex = 16;
            lblTechno.Text = "Techno";
            // 
            // btnSetReturn
            // 
            btnSetReturn.Location = new Point(254, 722);
            btnSetReturn.Name = "btnSetReturn";
            btnSetReturn.Size = new Size(263, 110);
            btnSetReturn.TabIndex = 17;
            btnSetReturn.Text = "Set Return";
            btnSetReturn.UseVisualStyleBackColor = true;
            btnSetReturn.Click += button1_Click;
            // 
            // txtHipHop
            // 
            txtHipHop.Location = new Point(306, 158);
            txtHipHop.Name = "txtHipHop";
            txtHipHop.Size = new Size(200, 39);
            txtHipHop.TabIndex = 19;
            // 
            // txtRock
            // 
            txtRock.Location = new Point(306, 219);
            txtRock.Name = "txtRock";
            txtRock.Size = new Size(200, 39);
            txtRock.TabIndex = 21;
            // 
            // txtPop
            // 
            txtPop.Location = new Point(306, 280);
            txtPop.Name = "txtPop";
            txtPop.Size = new Size(200, 39);
            txtPop.TabIndex = 22;
            // 
            // txtJazz
            // 
            txtJazz.Location = new Point(306, 343);
            txtJazz.Name = "txtJazz";
            txtJazz.Size = new Size(200, 39);
            txtJazz.TabIndex = 23;
            // 
            // txtTechno
            // 
            txtTechno.Location = new Point(306, 408);
            txtTechno.Name = "txtTechno";
            txtTechno.Size = new Size(200, 39);
            txtTechno.TabIndex = 24;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(306, 476);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(200, 39);
            txtCountry.TabIndex = 25;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(736, 908);
            Controls.Add(txtCountry);
            Controls.Add(txtTechno);
            Controls.Add(txtJazz);
            Controls.Add(txtPop);
            Controls.Add(txtRock);
            Controls.Add(txtHipHop);
            Controls.Add(btnSetReturn);
            Controls.Add(lblTechno);
            Controls.Add(lblCountry);
            Controls.Add(lblJazz);
            Controls.Add(lblPop);
            Controls.Add(lblRock);
            Controls.Add(lblHipHop);
            Name = "Form2";
            Text = "Settings";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblHipHop;
        private Label lblRock;
        private Label lblPop;
        private Label lblJazz;
        private Label lblCountry;
        private Label lblTechno;
        private Button btnSetReturn;
        public TextBox txtHipHop;
        public TextBox txtRock;
        public TextBox txtPop;
        public TextBox txtJazz;
        public TextBox txtTechno;
        public TextBox txtCountry;
    }
}