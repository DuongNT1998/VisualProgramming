namespace Chuong4_Phan2_B1
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
            label1 = new Label();
            txtText = new TextBox();
            rbTimesNewRoman = new RadioButton();
            rbArial = new RadioButton();
            rbTahoma = new RadioButton();
            rbVerdana = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 21);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhập văn bản";
            // 
            // txtText
            // 
            txtText.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtText.Location = new Point(70, 60);
            txtText.Name = "txtText";
            txtText.Size = new Size(194, 114);
            txtText.TabIndex = 1;
            // 
            // rbTimesNewRoman
            // 
            rbTimesNewRoman.AutoSize = true;
            rbTimesNewRoman.Location = new Point(381, 47);
            rbTimesNewRoman.Name = "rbTimesNewRoman";
            rbTimesNewRoman.Size = new Size(154, 24);
            rbTimesNewRoman.TabIndex = 2;
            rbTimesNewRoman.TabStop = true;
            rbTimesNewRoman.Text = "Times New Roman";
            rbTimesNewRoman.UseVisualStyleBackColor = true;
            // 
            // rbArial
            // 
            rbArial.AutoSize = true;
            rbArial.Location = new Point(381, 92);
            rbArial.Name = "rbArial";
            rbArial.Size = new Size(61, 24);
            rbArial.TabIndex = 3;
            rbArial.TabStop = true;
            rbArial.Text = "Arial";
            rbArial.UseVisualStyleBackColor = true;
            // 
            // rbTahoma
            // 
            rbTahoma.AutoSize = true;
            rbTahoma.Location = new Point(381, 140);
            rbTahoma.Name = "rbTahoma";
            rbTahoma.Size = new Size(82, 24);
            rbTahoma.TabIndex = 4;
            rbTahoma.TabStop = true;
            rbTahoma.Text = "Tahoma";
            rbTahoma.UseVisualStyleBackColor = true;
            // 
            // rbVerdana
            // 
            rbVerdana.AutoSize = true;
            rbVerdana.Location = new Point(381, 197);
            rbVerdana.Name = "rbVerdana";
            rbVerdana.Size = new Size(84, 24);
            rbVerdana.TabIndex = 5;
            rbVerdana.TabStop = true;
            rbVerdana.Text = "Verdana";
            rbVerdana.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 253);
            Controls.Add(rbVerdana);
            Controls.Add(rbTahoma);
            Controls.Add(rbArial);
            Controls.Add(rbTimesNewRoman);
            Controls.Add(txtText);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtText;
        private RadioButton rbTimesNewRoman;
        private RadioButton rbArial;
        private RadioButton rbTahoma;
        private RadioButton rbVerdana;
    }
}
