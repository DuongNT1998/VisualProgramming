namespace Mod3_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPTB1_Click(object sender, EventArgs e)
        {

            GiaiPTB1();
        }
        // Phương thức giải phương trình bậc 1: ax + b = 0
        private void GiaiPTB1()
        {
            txtHeSoThu3.ReadOnly = true;
            try
            {
                double a = Convert.ToDouble(txtHeSoThu1.Text);
                double b = Convert.ToDouble(txtHeSoThu2.Text);

                if (a == 0)
                {
                    txtKetQua.Text = (b == 0) ? "Phương trình vô số nghiệm" : "Phương trình vô nghiệm";
                }
                else
                {
                    double x = -b / a;
                    txtKetQua.Text = "Nghiệm: x = " + x;
                }
            }
            catch
            {
                txtKetQua.Text = "Lỗi nhập liệu!";
            }
        }

        private void btnPTB2_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(txtHeSoThu1.Text);
                double b = Convert.ToDouble(txtHeSoThu2.Text);
                double c = Convert.ToDouble(txtHeSoThu3.Text);

                if (a == 0)
                {
                    // Nếu a = 0, phương trình trở thành phương trình bậc 1: bx + c = 0
                    GiaiPTB1();
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        txtKetQua.Text = "Phương trình vô nghiệm";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        txtKetQua.Text = "Nghiệm kép: x = " + x;
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        txtKetQua.Text = "Nghiệm x1 = " + x1 + ", x2 = " + x2;
                    }
                }
            }
            catch
            {
                txtKetQua.Text = "Lỗi nhập liệu!";
            }
        }
    }
}
