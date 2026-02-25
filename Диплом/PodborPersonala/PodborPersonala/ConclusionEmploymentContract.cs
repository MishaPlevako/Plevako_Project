using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodborPersonala
{
    public partial class ConclusionEmploymentContract : Form
    {
        public int id;
        public ConclusionEmploymentContract(int _id)
        {
            InitializeComponent();
            id = _id; 
            loadCombobox();
        }

        private void loadCombobox()
        {
            string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT * " +
                "FROM Собеседования, Кандидаты " +
                "WHERE Собеседования.Код_Кандидата = Кандидаты.Код_Кандидата AND Собеседования.Код_Статуса = 1", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);

            CandidatescomboBox.DataSource = table;
            CandidatescomboBox.DisplayMember = "ФИО";
            CandidatescomboBox.ValueMember = "Код_Кандидата";
            connection.Close();

            string connectionString1 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection1 = new SqlConnection(connectionString1);
            connection1.Open();
            SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                ("SELECT * " +
                "FROM Сотрудники " +
                "WHERE Код_Сотрудника = 26", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            EmployeecomboBox.DataSource = table1;
            EmployeecomboBox.DisplayMember = "ФИО";
            EmployeecomboBox.ValueMember = "Код_Сотрудника";
            connection1.Close();

            string connectionString2 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection2 = new SqlConnection(connectionString2);
            connection2.Open();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                ("SELECT * FROM Отдел ", connection2);
            DataTable table2 = new DataTable();
            dataAdapter2.Fill(table2);

            DepartmentcomboBox.DataSource = table2;
            DepartmentcomboBox.DisplayMember = "Название_Отдела";
            DepartmentcomboBox.ValueMember = "Код_Отдела";
            connection2.Close();

            string connectionString3 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection3 = new SqlConnection(connectionString3);
            connection3.Open();
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                ("SELECT * FROM Должность", connection3);
            DataTable table3 = new DataTable();
            dataAdapter3.Fill(table3);

            PostcomboBox.DataSource = table3;
            PostcomboBox.DisplayMember = "Название_Должности";
            PostcomboBox.ValueMember = "Код_Должности";
            connection3.Close();
        }

        private void ConcludeButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("INSERT INTO Трудовой_Договор (Дата_Подписания_Договора, Город_Заключения_Договора, Код_Кандидата, Серия_Паспорта, Номер_Паспорта, Код_Сотрудника, Код_Отдела, Код_Должности, Дата_Начала_Работы, Время_Начала_Работы) " +
                " VALUES ('" + DateСonclusionPicker.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + CityDetentiontextBox.Text + "'," +
                "'" + CandidatescomboBox.SelectedValue + "'," +
                "'" + PassportSeriestextBox.Text + "'," +
                "'" + PassportNumbertextBox.Text + "'," +
                "'" + EmployeecomboBox.SelectedValue + "'," +
                "'" + DepartmentcomboBox.SelectedValue + "'," +
                "'" + PostcomboBox.SelectedValue + "'," +
                "'" + StartDatePicker.Value.ToString("yyyy-MM-dd") + "'," +
                "'" + StartTimePicker.Value.ToString("HH:mm") + "')", connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            Close();
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

        private void ConcludeButton_MouseEnter(object sender, EventArgs e)
        {
            ConcludeButton.ForeColor = Color.White;
        }

        private void ConcludeButton_MouseLeave(object sender, EventArgs e)
        {
            ConcludeButton.ForeColor = Color.Black;
        }
    }
}
