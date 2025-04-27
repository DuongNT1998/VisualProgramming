using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace Mod2_Bai8
{
    public partial class Form1 : Form
    {
        private Stack<Button> buttonStack = new Stack<Button>(); // Sử dụng Stack để quản lý các button động
        private int buttonTopPosition = 30; // Vị trí bắt đầu của các button động

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Tạo một button mới và đặt các thuộc tính cần thiết
            Button newButton = new Button();
            newButton.Text = "Element " + (buttonStack.Count + 1);
            newButton.Width = 100;
            newButton.Height = 40;
            newButton.Top = buttonTopPosition; // Đặt vị trí cho button
            newButton.Left = 130;
            newButton.Click += NewButton_Click; // Gắn sự kiện Click cho button

            // Thêm button vào form và vào stack
            this.Controls.Add(newButton);
            buttonStack.Push(newButton);

            buttonTopPosition += newButton.Height + 10;


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (buttonStack.Count > 0)
            {
                // Lấy button trên cùng của stack
                Button buttonToRemove = buttonStack.Pop();

                // Xóa button khỏi form
                this.Controls.Remove(buttonToRemove);

                // Cập nhật lại vị trí top cho các button còn lại (lùi lên trên)
                buttonTopPosition -= buttonToRemove.Height + 10;
            }
        }
        private void NewButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if (clickedButton != null)
            {
                // Hiển thị trạng thái của button lên label
                lbStatus.Text = "Clicked on: " + clickedButton.Text;
            }
        }
    }
}
