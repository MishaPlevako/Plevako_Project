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
    public partial class Decision : Form
    {
        public int id;
        public Decision(int _id)
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
                "FROM Кандидаты " +
                "WHERE Код_Кандидата =" + id, connection);
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
                ("SELECT * FROM Тип_Собеседования ", connection1);
            DataTable table1 = new DataTable();
            dataAdapter1.Fill(table1);

            TypeOfInterviewcomboBox.DataSource = table1;
            TypeOfInterviewcomboBox.DisplayMember = "Название_Типа_Собеседования";
            TypeOfInterviewcomboBox.ValueMember = "Код_Типа_Собеседования";
            connection1.Close();

            string connectionString2 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection2 = new SqlConnection(connectionString2);
            connection2.Open();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                ("SELECT * " +
                "FROM Сотрудники " +
                "WHERE Код_Сотрудника IN (1, 10)", connection2);
            DataTable table2 = new DataTable();
            dataAdapter2.Fill(table2);

            EmployeecomboBox.DataSource = table2;
            EmployeecomboBox.DisplayMember = "ФИО";
            EmployeecomboBox.ValueMember = "Код_Сотрудника";
            connection2.Close();

            string connectionString3 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection3 = new SqlConnection(connectionString3);
            connection3.Open();
            SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                ("SELECT * " +
                "FROM Статус_Собеседования " +
                "WHERE Код_Статуса IN (2, 3)", connection3);
            DataTable table3 = new DataTable();
            dataAdapter3.Fill(table3);

            InterviewStatuscomboBox.DataSource = table3;
            InterviewStatuscomboBox.DisplayMember = "Название_Статуса_Собеседования";
            InterviewStatuscomboBox.ValueMember = "Код_Статуса";
            connection3.Close();
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

        private void InsertButton_Appoint_Click(object sender, EventArgs e)
        {
            if (InterviewStatuscomboBox.SelectedValue != null && int.Parse(InterviewStatuscomboBox.SelectedValue.ToString()) == 3)
            {
                string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter
                    ("INSERT INTO Собеседования (Код_Кандидата, Дата_Собеседования, Время_Собеседования, Код_Типа_Собеседования, Код_Сотрудника, Код_Статуса) " +
                    " VALUES ('" + CandidatescomboBox.SelectedValue + "'," +
                    "'" + InterviewdatePicker.Value.ToString("yyyy-MM-dd") + "'," +
                    "'" + InterviewtimePicker.Value.ToString("HH:mm") + "'," +
                    "'" + TypeOfInterviewcomboBox.SelectedValue + "'," +
                    "'" + EmployeecomboBox.SelectedValue + "'," +
                    "'" + InterviewStatuscomboBox.SelectedValue + "')", connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                connection.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Для нажатия на эту кнопку необходимо выбрать статус 'Назначено'.", "Ошибка");
            }
        }

        private void InsertButton_Reject_Click(object sender, EventArgs e)
        {
            if (InterviewStatuscomboBox.SelectedValue != null && int.Parse(InterviewStatuscomboBox.SelectedValue.ToString()) == 2) 
            {
                string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter
                    ("INSERT INTO Собеседования (Код_Кандидата, Дата_Собеседования, Время_Собеседования, Код_Типа_Собеседования, Код_Сотрудника, Код_Статуса) " +
                    " VALUES ('" + CandidatescomboBox.SelectedValue + "'," +
                    "'" + InterviewdatePicker.Value.ToString("yyyy-MM-dd") + "'," +
                    "'" + InterviewtimePicker.Value.ToString("HH:mm") + "'," +
                    "'" + TypeOfInterviewcomboBox.SelectedValue + "'," +
                    "'" + EmployeecomboBox.SelectedValue + "'," +
                    "'" + InterviewStatuscomboBox.SelectedValue + "')", connection);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                connection.Close();
                Close();
            }
            else
            {
                MessageBox.Show("Для нажатия на эту кнопку необходимо выбрать статус 'Отклонено'.", "Ошибка");
            }
        }

        private void InsertButton_Appoint_MouseEnter(object sender, EventArgs e)
        {
            InsertButton_Appoint.ForeColor = Color.White;
        }

        private void InsertButton_Appoint_MouseLeave(object sender, EventArgs e)
        {
            InsertButton_Appoint.ForeColor = Color.Black;
        }

        private void InsertButton_Reject_MouseEnter(object sender, EventArgs e)
        {
            InsertButton_Reject.ForeColor = Color.White;
        }

        private void InsertButton_Reject_MouseLeave(object sender, EventArgs e)
        {
            InsertButton_Reject.ForeColor = Color.Black;
        }
    }
}
