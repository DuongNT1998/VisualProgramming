namespace MenuStrip_ContextMenu_Chap7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cntmnuRed_Click(object sender, EventArgs e)
        {
            Label lb = contextMenuStrip1.SourceControl as Label;
            lb.ForeColor = Color.Red;
            //lbTestContextMenuStrip.BackColor = Color.Red;
        }

        private void ctmnuBlue_Click(object sender, EventArgs e)
        {
            Label lb = contextMenuStrip1.SourceControl as Label;
            lb.ForeColor = Color.Blue;
            //lbTestContextMenuStrip.BackColor = Color.Red;
        }

        private void ctmnuGreen_Click(object sender, EventArgs e)
        {
            Label lb = contextMenuStrip1.SourceControl as Label;
            lb.ForeColor = Color.Green;
            //lbTestContextMenuStrip.BackColor = Color.Red;
        }
    }
}
