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
    public partial class AcceptedInterviews : Form
    {
        public AcceptedInterviews()
        {
            InitializeComponent();
            refresh();
        }

        void refresh()
        {
            switch (Properties.Settings.Default.l)
            {
                case 20:
                    string connectionString18 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection18 = new SqlConnection(connectionString18);
                    connection18.Open();
                    SqlDataAdapter dataAdapter18 = new SqlDataAdapter
                        ("SELECT Собеседования.Код_Собеседования, Кандидаты.ФИО AS Кандидат, Собеседования.Дата_Собеседования, Собеседования.Время_Собеседования, Тип_Собеседования.Название_Типа_Собеседования AS Тип_Собеседования, " +
                        "Сотрудники.ФИО AS Сотрудник, Статус_Собеседования.Название_Статуса_Собеседования AS Статус_Собеседования " +
                        "FROM Собеседования, Кандидаты, Тип_Собеседования, Сотрудники, Статус_Собеседования " +
                        "WHERE Собеседования.Код_Кандидата = Кандидаты.Код_Кандидата AND Собеседования.Код_Типа_Собеседования = Тип_Собеседования.Код_Типа_Собеседования " +
                        "AND Собеседования.Код_Сотрудника = Сотрудники.Код_Сотрудника AND Собеседования.Код_Статуса = Статус_Собеседования.Код_Статуса AND Статус_Собеседования.Код_Статуса LIKE 1", connection18);
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
                        case 20:
                            {
                                ConclusionEmploymentContract conclusionEmploymentContract = new ConclusionEmploymentContract(id);
                                conclusionEmploymentContract.ShowDialog();
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
