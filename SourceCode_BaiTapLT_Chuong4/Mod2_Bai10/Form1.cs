using System;
using System.Diagnostics;

namespace Mod2_Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lklblWeb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://www.windowsform.com");  // Thay đổi URL theo nhu cầu của bạn
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening website: " + ex.Message);
            }
        }

        private void lklblCalcu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("calc.exe");  // Mở Calculator
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening Calculator: " + ex.Message);
            }
        }

        private void lklblCDrive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("explorer.exe", "C:\\");  // Mở ổ đĩa C
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening C: Drive: " + ex.Message);
            }
        }
    }
}
