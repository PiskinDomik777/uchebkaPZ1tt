using System;
using System.Linq;
using System.Windows.Forms;
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
            using (var context = new Ispr2524LinkovNIUchebkaContext())
            {
                var data = context.InputDataRequests
                    .Select(x => new
                    {
                        Номер_заявки = x.RequestId,
                        Дата_начала = x.StartDate,
                        Тип_техники = x.ComputerTechType,
                        Модель = x.ComputerTechModel,
                        Описание = x.ProblemDescryption,
                        Статус = x.RequestStatus
                    })
                    .ToList();

                dgvRequests.DataSource = data;

                // Включаем возможность сортировки для каждого столбца вручную
                foreach (DataGridViewColumn column in dgvRequests.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
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

            using (var context = new Ispr2524LinkovNIUchebkaContext())
            {
                var query = context.InputDataRequests.AsQueryable();
                string sort = cmbSort.SelectedItem.ToString();

                if (sort == "Сначала новые")
                {
                    query = query.OrderByDescending(x => x.StartDate);
                }
                else if (sort == "Сначала старые")
                {
                    query = query.OrderBy(x => x.StartDate);
                }
                else if (sort == "По номеру (возр.)")
                {
                    query = query.OrderBy(x => x.RequestId);
                }

                var data = query.Select(x => new
                {
                    Номер_заявки = x.RequestId,
                    Дата_начала = x.StartDate,
                    Тип_техники = x.ComputerTechType,
                    Модель = x.ComputerTechModel,
                    Описание = x.ProblemDescryption,
                    Статус = x.RequestStatus
                }).ToList();

                dgvRequests.DataSource = data;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadRequests();
        }
    }
}