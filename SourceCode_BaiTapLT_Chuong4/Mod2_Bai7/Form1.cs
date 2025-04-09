namespace Mod2_Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void picTurnOn_Click(object sender, EventArgs e)
        {
            picTurnOn.Visible = false;
            picTurnOff.Visible = true;
            txtChangeLight.Text = "Jack. Turn On the Light, please!";
        }

        private void picTurnOff_Click(object sender, EventArgs e)
        {
            picTurnOff.Visible = false;
            picTurnOn.Visible = true;
            txtChangeLight.Text = "Jack. Turn Off the Light, please!";
        }

        private void picTurnOff_MouseHover(object sender, EventArgs e)
        {

            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
        }

        private void picTurnOn_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(picTurnOn, "Click me to Turn OFF the Light!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the application

        }
    }
}
