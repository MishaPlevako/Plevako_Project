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
    public partial class DeleteInterviews : Form
    {
        public int id;
        public DeleteInterviews(int _id)
        {
            InitializeComponent();
            id = _id; 
            loadString();
        }

        private void loadString()
        {
            string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("SELECT Собеседования.Код_Собеседования, Кандидаты.ФИО, Собеседования.Дата_Собеседования, Собеседования.Время_Собеседования, Тип_Собеседования.Название_Типа_Собеседования, Сотрудники.ФИО, Статус_Собеседования.Название_Статуса_Собеседования " +
                "FROM Собеседования, Кандидаты, Тип_Собеседования, Сотрудники, Статус_Собеседования " +
                "WHERE Собеседования.Код_Кандидата = Кандидаты.Код_Кандидата AND Собеседования.Код_Типа_Собеседования = Тип_Собеседования.Код_Типа_Собеседования AND " +
                "Собеседования.Код_Сотрудника = Сотрудники.Код_Сотрудника AND Собеседования.Код_Статуса = Статус_Собеседования.Код_Статуса AND " +
                "Собеседования.Код_Собеседования =" + id, connection);
            DataTable table = new DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            CandidatetextBox.Text = table.Rows[0][1].ToString();
            DatetextBox.Text = table.Rows[0][2].ToString();
            TimetextBox.Text = table.Rows[0][3].ToString();
            TypeOfInterviewtextBox.Text = table.Rows[0][4].ToString();
            EmployeetextBox.Text = table.Rows[0][5].ToString();
            InterviewStatustextBox.Text = table.Rows[0][6].ToString();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter
                ("DELETE FROM Собеседования WHERE Код_Собеседования = " + id, connection);
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

        private void InsertButton_Appoint_MouseEnter(object sender, EventArgs e)
        {
            DeleteButton.ForeColor = Color.White;
        }

        private void InsertButton_Appoint_MouseLeave(object sender, EventArgs e)
        {
            DeleteButton.ForeColor = Color.Black;
        }
    }
}
