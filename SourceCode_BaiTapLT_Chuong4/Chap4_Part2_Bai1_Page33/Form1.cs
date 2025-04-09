namespace Chuong4_Phan2_B1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rbTimesNewRoman.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbArial.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbTahoma.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
            rbVerdana.CheckedChanged += new EventHandler(RadioButton_CheckedChanged);
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTimesNewRoman.Checked)
            {
                txtText.Font = new Font("Times New Roman", 16);
            }
            else if (rbArial.Checked)
            {
                txtText.Font = new Font("Arial", 16);
            }
            else if (rbTahoma.Checked)
            {
                txtText.Font = new Font("Tahoma", 16);
            }
            else if (rbVerdana.Checked)
            {
                txtText.Font = new Font("Verdana", 16);
            }
        }
    }
}
