using System;
using System.Windows.Forms;
using uchebkaPZ1tt.Models;

namespace uchebkaPZ1tt
{
    public partial class AddForm : Form
    {
        public AddForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text) || string.IsNullOrWhiteSpace(txtType.Text))
            {
                MessageBox.Show("Заполните тип и модель техники!");
                return;
            }

            try
            {
                using (var context = new Ispr2524LinkovNIUchebkaContext())
                {
                    int nextId = context.InputDataRequests.Any()
                                 ? context.InputDataRequests.Max(x => x.RequestId) + 1
                                 : 1;

                    var request = new InputDataRequest
                    {
                        RequestId = nextId,
                        StartDate = DateTime.Now.ToString("yyyy-MM-dd"),

                        ComputerTechType = txtType.Text,
                        ComputerTechModel = txtModel.Text,
                        ProblemDescryption = txtProblem.Text,
                        RequestStatus = cmbStatus.Text,
                        ClientId = 7
                    };

                    context.InputDataRequests.Add(request);
                    context.SaveChanges();
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show($"Ошибка: {msg}");
            }
        }

        private void InitializeComponent()
        {
            txtType = new TextBox();
            txtModel = new TextBox();
            txtProblem = new TextBox();
            cmbStatus = new ComboBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.Location = new Point(220, 75);
            txtType.Name = "txtType";
            txtType.Size = new Size(100, 23);
            txtType.TabIndex = 0;
            // 
            // txtModel
            // 
            txtModel.Location = new Point(220, 104);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(100, 23);
            txtModel.TabIndex = 1;
            // 
            // txtProblem
            // 
            txtProblem.Location = new Point(220, 133);
            txtProblem.Name = "txtProblem";
            txtProblem.Size = new Size(100, 23);
            txtProblem.TabIndex = 2;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Новая заявка", "В процессе ремонта", "Готова к выдаче" });
            cmbStatus.Location = new Point(209, 162);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(234, 191);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddForm
            // 
            ClientSize = new Size(584, 440);
            Controls.Add(btnSave);
            Controls.Add(cmbStatus);
            Controls.Add(txtProblem);
            Controls.Add(txtModel);
            Controls.Add(txtType);
            Name = "AddForm";
            ResumeLayout(false);
            PerformLayout();

        }
    }
}