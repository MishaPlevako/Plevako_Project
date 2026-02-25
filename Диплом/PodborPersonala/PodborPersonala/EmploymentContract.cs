    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodborPersonala
{
    public partial class EmploymentContract : Form
    {
        public EmploymentContract()
        {
            InitializeComponent();
            refresh();
        }

        void refresh()
        {
            switch (Properties.Settings.Default.l)
            {
                case 23:
                    string connectionString18 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection18 = new SqlConnection(connectionString18);
                    connection18.Open();
                    SqlDataAdapter dataAdapter18 = new SqlDataAdapter
                        ("SELECT Трудовой_Договор.Код_Трудового_Договора, Трудовой_Договор.Дата_Подписания_Договора, Трудовой_Договор.Город_Заключения_Договора, " +
                        "Кандидаты.ФИО AS ФИО_Кандидата, Трудовой_Договор.Серия_Паспорта, Трудовой_Договор.Номер_Паспорта, Сотрудники.ФИО AS ФИО_Сотрудника, Отдел.Название_Отдела, " +
                        "Должность.Название_Должности, Трудовой_Договор.Дата_Начала_Работы, Трудовой_Договор.Время_Начала_Работы " +
                        "FROM Трудовой_Договор, Кандидаты, Сотрудники, Отдел, Должность " +
                        "WHERE Трудовой_Договор.Код_Кандидата = Кандидаты.Код_Кандидата AND Трудовой_Договор.Код_Сотрудника = Сотрудники.Код_Сотрудника " +
                        "AND Трудовой_Договор.Код_Отдела = Отдел.Код_Отдела AND Трудовой_Договор.Код_Должности = Должность.Код_Должности", connection18);
                    DataTable table18 = new DataTable();
                    dataAdapter18.Fill(table18);
                    dataGridView1.DataSource = table18;
                    dataGridView1.Columns[0].Visible = false;
                    connection18.Close();
                    break;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                try
                {
                    int id = Convert.ToInt32(dataGridView1[0, dataGridView1.CurrentRow.Index].Value);
                    switch (Properties.Settings.Default.l)
                    {
                        case 23:
                            {
                                PrintEmploymentContract printEmploymentContract = new PrintEmploymentContract(id);
                                printEmploymentContract.ShowDialog();
                            }
                            break;
                    }

                    refresh();
                }
                catch
                {
                    MessageBox.Show("Нажата пустая ячейка!", "Ошибка!");
                }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Sort(dataGridView1.Columns[SortTextBox.Text], ListSortDirection.Ascending);
            }
            catch
            {
                MessageBox.Show("Введите имя столбца правильно!", "Неверное имя столбца.");
            }
        }

        private void labelClose_MouseEnter(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.Gray;
        }

        private void labelClose_MouseLeave(object sender, EventArgs e)
        {
            labelClose.ForeColor = Color.White;
        }

        private void labelClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
