namespace Mod2_Bai6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtMessage = new TextBox();
            txtName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            chkVisible = new CheckBox();
            picSmall = new PictureBox();
            picBig = new PictureBox();
            panel1 = new Panel();
            lblMessage = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(3, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(678, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input Name & Message";
            // 
            // txtMessage
            // 
            txtMessage.BackColor = Color.FromArgb(255, 192, 192);
            txtMessage.Location = new Point(120, 88);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(552, 27);
            txtMessage.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.BackColor = Color.FromArgb(255, 192, 192);
            txtName.ForeColor = Color.FromArgb(64, 64, 64);
            txtName.Location = new Point(120, 42);
            txtName.Name = "txtName";
            txtName.Size = new Size(552, 27);
            txtName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(35, 88);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 1;
            label2.Text = "Message";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(45, 17);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(radBlack);
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radRed);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(26, 179);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(184, 198);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(22, 159);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += new EventHandler(radBlack_CheckedChanged);

            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.ForeColor = Color.FromArgb(0, 0, 192);
            radBlue.Location = new Point(22, 117);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += new EventHandler(radBlue_CheckedChanged);

            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.BackColor = SystemColors.GradientInactiveCaption;
            radGreen.ForeColor = Color.FromArgb(0, 192, 0);
            radGreen.Location = new Point(22, 77);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = false;
            radGreen.CheckedChanged += new EventHandler(radGreen_CheckedChanged);

            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(22, 34);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += new EventHandler(radRed_CheckedChanged);
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.GradientInactiveCaption;
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDisplay);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(512, 182);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(163, 180);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Light", 9F);
            btnExit.Location = new Point(18, 145);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Light", 9F);
            btnClear.Location = new Point(18, 87);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Font = new Font("Segoe UI Light", 9F);
            btnDisplay.Location = new Point(18, 31);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // chkVisible
            // 
            chkVisible.AutoSize = true;
            chkVisible.Location = new Point(290, 179);
            chkVisible.Name = "chkVisible";
            chkVisible.Size = new Size(137, 24);
            chkVisible.TabIndex = 3;
            chkVisible.Text = "Message Visible";
            chkVisible.UseVisualStyleBackColor = true;
            chkVisible.CheckedChanged += chkVisible_CheckedChanged;
            // 
            // picSmall
            // 
            picSmall.Image = (Image)resources.GetObject("picSmall.Image");
            picSmall.Location = new Point(313, 278);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(61, 62);
            picSmall.TabIndex = 4;
            picSmall.TabStop = false;
            // 
            // picBig
            // 
            picBig.Image = (Image)resources.GetObject("picBig.Image");
            picBig.Location = new Point(273, 266);
            picBig.Name = "picBig";
            picBig.Size = new Size(140, 96);
            picBig.TabIndex = 5;
            picBig.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.Controls.Add(lblMessage);
            panel1.Location = new Point(3, 383);
            panel1.Name = "panel1";
            panel1.Size = new Size(693, 67);
            panel1.TabIndex = 1;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(9, 20);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(50, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 450);
            Controls.Add(panel1);
            Controls.Add(picBig);
            Controls.Add(picSmall);
            Controls.Add(chkVisible);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Message Formatter";
            FormClosing += Form1_FormClosing;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMessage;
        private TextBox txtName;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private GroupBox groupBox3;
        private Button btnExit;
        private Button btnClear;
        private Button btnDisplay;
        private CheckBox chkVisible;
        private PictureBox picSmall;
        private PictureBox picBig;
        private Panel panel1;
        private Label lblMessage;
    }
}
