namespace uchebkaPZ1tt
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvRequests;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.CheckBox chkAsc;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void InitializeComponent()
        {
            dgvRequests = new DataGridView();
            cmbSort = new ComboBox();
            chkAsc = new CheckBox();
            btnAdd = new Button();
            btnRefresh = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(11, 79);
            dgvRequests.Margin = new Padding(3, 4, 3, 4);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.ReadOnly = true;
            dgvRequests.RowHeadersWidth = 51;
            dgvRequests.RowTemplate.Height = 24;
            dgvRequests.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRequests.Size = new Size(1160, 588);
            dgvRequests.TabIndex = 0;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Сначала новые", "Сначала старые" });
            cmbSort.Location = new Point(110, 27);
            cmbSort.Margin = new Padding(3, 4, 3, 4);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(190, 28);
            cmbSort.TabIndex = 1;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // chkAsc
            // 
            chkAsc.AutoSize = true;
            chkAsc.Checked = true;
            chkAsc.CheckState = CheckState.Checked;
            chkAsc.Location = new Point(320, 29);
            chkAsc.Margin = new Padding(3, 4, 3, 4);
            chkAsc.Name = "chkAsc";
            chkAsc.Size = new Size(147, 24);
            chkAsc.TabIndex = 2;
            chkAsc.Text = "По возрастанию";
            chkAsc.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(997, 23);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(175, 36);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(816, 23);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(160, 36);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Обновить";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 29);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 5;
            label1.Text = "Сортировать:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            label2.Location = new Point(11, 683);
            label2.Name = "label2";
            label2.Size = new Size(499, 25);
            label2.TabIndex = 6;
            label2.Text = "Учет заявок на ремонт компьютерной техники";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 737);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRefresh);
            Controls.Add(btnAdd);
            Controls.Add(chkAsc);
            Controls.Add(cmbSort);
            Controls.Add(dgvRequests);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Список заявок";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}