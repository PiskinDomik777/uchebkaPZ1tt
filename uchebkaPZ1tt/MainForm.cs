using uchebkaPZ1tt.Models;

namespace uchebkaPZ1tt
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadRequests();
        }

        private void LoadRequests()
        {
            try
            {
                using (var context = new Ispr2524LinkovNIUchebkaContext())
                {
                    // Получаем данные из БД
                    var data = context.InputDataRequests
                        .Select(x => new
                        {
                            Id = x.RequestId,
                            Date = x.StartDate,
                            Type = x.ComputerTechType,
                            Model = x.ComputerTechModel,
                            Problem = x.ProblemDescryption,
                            Status = x.RequestStatus
                        })
                        .ToList();

                    // Очищаем и настраиваем таблицу
                    dgvRequests.AutoGenerateColumns = true;
                    dgvRequests.Columns.Clear();
                    dgvRequests.DataSource = data;

                    // Настраиваем заголовки
                    dgvRequests.Columns["Id"].HeaderText = "Номер заявки";
                    dgvRequests.Columns["Date"].HeaderText = "Дата начала";
                    dgvRequests.Columns["Type"].HeaderText = "Тип техники";
                    dgvRequests.Columns["Model"].HeaderText = "Модель";
                    dgvRequests.Columns["Problem"].HeaderText = "Описание";
                    dgvRequests.Columns["Status"].HeaderText = "Статус";

                    // Формат даты
                    dgvRequests.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}\n\n{ex.StackTrace}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddForm form = new AddForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadRequests();
            }
        }

        private void dgvRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSort.SelectedItem == null)
                return;

            try
            {
                using (var context = new Ispr2524LinkovNIUchebkaContext())
                {
                    var query = context.InputDataRequests.AsQueryable();
                    string sort = cmbSort.SelectedItem.ToString();

                    if (sort == "Сначала новые")
                        query = query.OrderByDescending(x => x.StartDate);
                    else if (sort == "Сначала старые")
                        query = query.OrderBy(x => x.StartDate);
                    else if (sort == "По номеру (возр.)")
                        query = query.OrderBy(x => x.RequestId);

                    var data = query.Select(x => new
                    {
                        Id = x.RequestId,
                        Date = x.StartDate,
                        Type = x.ComputerTechType,
                        Model = x.ComputerTechModel,
                        Problem = x.ProblemDescryption,
                        Status = x.RequestStatus
                    }).ToList();

                    dgvRequests.AutoGenerateColumns = true;
                    dgvRequests.Columns.Clear();
                    dgvRequests.DataSource = data;

                    dgvRequests.Columns["Id"].HeaderText = "Номер заявки";
                    dgvRequests.Columns["Date"].HeaderText = "Дата начала";
                    dgvRequests.Columns["Type"].HeaderText = "Тип техники";
                    dgvRequests.Columns["Model"].HeaderText = "Модель";
                    dgvRequests.Columns["Problem"].HeaderText = "Описание";
                    dgvRequests.Columns["Status"].HeaderText = "Статус";

                    dgvRequests.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сортировки: {ex.Message}");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }

        private void chkAsc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {

        }

        private void dgvRequests_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}