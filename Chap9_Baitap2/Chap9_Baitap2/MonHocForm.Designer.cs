namespace Chap9_Baitap2
{
    partial class MonHocForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonHocForm));
            System.Windows.Forms.Label maMHLabel;
            System.Windows.Forms.Label tenMHLabel;
            System.Windows.Forms.Label soTietLabel;
            this.chap9_Baitap2DataSet = new Chap9_Baitap2.Chap9_Baitap2DataSet();
            this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monHocTableAdapter = new Chap9_Baitap2.Chap9_Baitap2DataSetTableAdapters.MonHocTableAdapter();
            this.tableAdapterManager = new Chap9_Baitap2.Chap9_Baitap2DataSetTableAdapters.TableAdapterManager();
            this.monHocBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.monHocBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.monHocDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maMHTextBox = new System.Windows.Forms.TextBox();
            this.tenMHTextBox = new System.Windows.Forms.TextBox();
            this.soTietTextBox = new System.Windows.Forms.TextBox();
            maMHLabel = new System.Windows.Forms.Label();
            tenMHLabel = new System.Windows.Forms.Label();
            soTietLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chap9_Baitap2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingNavigator)).BeginInit();
            this.monHocBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chap9_Baitap2DataSet
            // 
            this.chap9_Baitap2DataSet.DataSetName = "Chap9_Baitap2DataSet";
            this.chap9_Baitap2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monHocBindingSource
            // 
            this.monHocBindingSource.DataMember = "MonHoc";
            this.monHocBindingSource.DataSource = this.chap9_Baitap2DataSet;
            // 
            // monHocTableAdapter
            // 
            this.monHocTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KetQuaTableAdapter = null;
            this.tableAdapterManager.KhoaTableAdapter = null;
            this.tableAdapterManager.MonHocTableAdapter = this.monHocTableAdapter;
            this.tableAdapterManager.SinhVienTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Chap9_Baitap2.Chap9_Baitap2DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // monHocBindingNavigator
            // 
            this.monHocBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.monHocBindingNavigator.BindingSource = this.monHocBindingSource;
            this.monHocBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.monHocBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.monHocBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.monHocBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.monHocBindingNavigatorSaveItem});
            this.monHocBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.monHocBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.monHocBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.monHocBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.monHocBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.monHocBindingNavigator.Name = "monHocBindingNavigator";
            this.monHocBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.monHocBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.monHocBindingNavigator.TabIndex = 0;
            this.monHocBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 20);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // monHocBindingNavigatorSaveItem
            // 
            this.monHocBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.monHocBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("monHocBindingNavigatorSaveItem.Image")));
            this.monHocBindingNavigatorSaveItem.Name = "monHocBindingNavigatorSaveItem";
            this.monHocBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.monHocBindingNavigatorSaveItem.Text = "Save Data";
            this.monHocBindingNavigatorSaveItem.Click += new System.EventHandler(this.monHocBindingNavigatorSaveItem_Click);
            // 
            // monHocDataGridView
            // 
            this.monHocDataGridView.AutoGenerateColumns = false;
            this.monHocDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.monHocDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.monHocDataGridView.DataSource = this.monHocBindingSource;
            this.monHocDataGridView.Location = new System.Drawing.Point(12, 153);
            this.monHocDataGridView.Name = "monHocDataGridView";
            this.monHocDataGridView.RowHeadersWidth = 51;
            this.monHocDataGridView.RowTemplate.Height = 24;
            this.monHocDataGridView.Size = new System.Drawing.Size(559, 285);
            this.monHocDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaMH";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaMH";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenMH";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenMH";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SoTiet";
            this.dataGridViewTextBoxColumn3.HeaderText = "SoTiet";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(soTietLabel);
            this.panel1.Controls.Add(this.soTietTextBox);
            this.panel1.Controls.Add(maMHLabel);
            this.panel1.Controls.Add(this.maMHTextBox);
            this.panel1.Controls.Add(tenMHLabel);
            this.panel1.Controls.Add(this.tenMHTextBox);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 97);
            this.panel1.TabIndex = 2;
            // 
            // maMHLabel
            // 
            maMHLabel.AutoSize = true;
            maMHLabel.Location = new System.Drawing.Point(32, 41);
            maMHLabel.Name = "maMHLabel";
            maMHLabel.Size = new System.Drawing.Size(53, 16);
            maMHLabel.TabIndex = 0;
            maMHLabel.Text = "Ma MH:";
            // 
            // maMHTextBox
            // 
            this.maMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "MaMH", true));
            this.maMHTextBox.Location = new System.Drawing.Point(105, 38);
            this.maMHTextBox.Name = "maMHTextBox";
            this.maMHTextBox.Size = new System.Drawing.Size(100, 22);
            this.maMHTextBox.TabIndex = 1;
            // 
            // tenMHLabel
            // 
            tenMHLabel.AutoSize = true;
            tenMHLabel.Location = new System.Drawing.Point(261, 41);
            tenMHLabel.Name = "tenMHLabel";
            tenMHLabel.Size = new System.Drawing.Size(58, 16);
            tenMHLabel.TabIndex = 2;
            tenMHLabel.Text = "Ten MH:";
            // 
            // tenMHTextBox
            // 
            this.tenMHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "TenMH", true));
            this.tenMHTextBox.Location = new System.Drawing.Point(325, 38);
            this.tenMHTextBox.Name = "tenMHTextBox";
            this.tenMHTextBox.Size = new System.Drawing.Size(234, 22);
            this.tenMHTextBox.TabIndex = 3;
            // 
            // soTietLabel
            // 
            soTietLabel.AutoSize = true;
            soTietLabel.Location = new System.Drawing.Point(602, 41);
            soTietLabel.Name = "soTietLabel";
            soTietLabel.Size = new System.Drawing.Size(53, 16);
            soTietLabel.TabIndex = 6;
            soTietLabel.Text = "So Tiet:";
            // 
            // soTietTextBox
            // 
            this.soTietTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.monHocBindingSource, "SoTiet", true));
            this.soTietTextBox.Location = new System.Drawing.Point(666, 38);
            this.soTietTextBox.Name = "soTietTextBox";
            this.soTietTextBox.Size = new System.Drawing.Size(100, 22);
            this.soTietTextBox.TabIndex = 7;
            // 
            // MonHocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.monHocDataGridView);
            this.Controls.Add(this.monHocBindingNavigator);
            this.Name = "MonHocForm";
            this.Text = "MonHocForm";
            this.Load += new System.EventHandler(this.MonHocForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chap9_Baitap2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monHocBindingNavigator)).EndInit();
            this.monHocBindingNavigator.ResumeLayout(false);
            this.monHocBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.monHocDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Chap9_Baitap2DataSet chap9_Baitap2DataSet;
        private System.Windows.Forms.BindingSource monHocBindingSource;
        private Chap9_Baitap2DataSetTableAdapters.MonHocTableAdapter monHocTableAdapter;
        private Chap9_Baitap2DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator monHocBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton monHocBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView monHocDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox soTietTextBox;
        private System.Windows.Forms.TextBox maMHTextBox;
        private System.Windows.Forms.TextBox tenMHTextBox;
    }
}