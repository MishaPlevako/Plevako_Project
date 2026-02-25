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
    public partial class Resume : Form
    {
        public int id;
        public Resume(int _id)
        {
            InitializeComponent();
            id = _id;
            loadString();
        }

        private void loadString()
        {
            switch (Properties.Settings.Default.l)
            {
                case 1:
                    string connectionString = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection = new SqlConnection(connectionString);
                    connection.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 3 AND Кандидаты.Код_Кандидата =" + id, connection);
                    DataTable table = new DataTable();
                    dataAdapter.Fill(table);
                    connection.Close();
                    FIOtextBox.Text = table.Rows[0][1].ToString();
                    byte[] photoBytes = (byte[])table.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table.Rows[0][3].ToString();
                    TelephonetextBox.Text = table.Rows[0][4].ToString();
                    AgetextBox.Text = table.Rows[0][5].ToString();
                    AddresstextBox.Text = table.Rows[0][6].ToString();
                    ScoretextBox.Text = table.Rows[0][7].ToString();
                    Id_Post.Text = table.Rows[0][8].ToString();
                    break;

                case 2:
                    string connectionString1 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection1 = new SqlConnection(connectionString1);
                    connection1.Open();
                    SqlDataAdapter dataAdapter1 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 4 AND Кандидаты.Код_Кандидата =" + id, connection1);
                    DataTable table1 = new DataTable();
                    dataAdapter1.Fill(table1);
                    connection1.Close();
                    FIOtextBox.Text = table1.Rows[0][1].ToString();
                    byte[] photoBytes1 = (byte[])table1.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes1))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table1.Rows[0][3].ToString();
                    TelephonetextBox.Text = table1.Rows[0][4].ToString();
                    AgetextBox.Text = table1.Rows[0][5].ToString();
                    AddresstextBox.Text = table1.Rows[0][6].ToString();
                    ScoretextBox.Text = table1.Rows[0][7].ToString();
                    Id_Post.Text = table1.Rows[0][8].ToString();
                    break;

                case 3:
                    string connectionString2 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection2 = new SqlConnection(connectionString2);
                    connection2.Open();
                    SqlDataAdapter dataAdapter2 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 5 AND Кандидаты.Код_Кандидата =" + id, connection2);
                    DataTable table2 = new DataTable();
                    dataAdapter2.Fill(table2);
                    connection2.Close();
                    FIOtextBox.Text = table2.Rows[0][1].ToString();
                    byte[] photoBytes2 = (byte[])table2.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes2))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table2.Rows[0][3].ToString();
                    TelephonetextBox.Text = table2.Rows[0][4].ToString();
                    AgetextBox.Text = table2.Rows[0][5].ToString();
                    AddresstextBox.Text = table2.Rows[0][6].ToString();
                    ScoretextBox.Text = table2.Rows[0][7].ToString();
                    Id_Post.Text = table2.Rows[0][8].ToString();
                    break;

                case 4:
                    string connectionString3 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection3 = new SqlConnection(connectionString3);
                    connection3.Open();
                    SqlDataAdapter dataAdapter3 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 9 AND Кандидаты.Код_Кандидата =" + id, connection3);
                    DataTable table3 = new DataTable();
                    dataAdapter3.Fill(table3);
                    connection3.Close();
                    FIOtextBox.Text = table3.Rows[0][1].ToString();
                    byte[] photoBytes3 = (byte[])table3.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes3))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table3.Rows[0][3].ToString();
                    TelephonetextBox.Text = table3.Rows[0][4].ToString();
                    AgetextBox.Text = table3.Rows[0][5].ToString();
                    AddresstextBox.Text = table3.Rows[0][6].ToString();
                    ScoretextBox.Text = table3.Rows[0][7].ToString();
                    Id_Post.Text = table3.Rows[0][8].ToString();
                    break;

                case 5:
                    string connectionString4 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection4 = new SqlConnection(connectionString4);
                    connection4.Open();
                    SqlDataAdapter dataAdapter4 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 8 AND Кандидаты.Код_Кандидата =" + id, connection4);
                    DataTable table4 = new DataTable();
                    dataAdapter4.Fill(table4);
                    connection4.Close();
                    FIOtextBox.Text = table4.Rows[0][1].ToString();
                    byte[] photoBytes4 = (byte[])table4.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes4))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table4.Rows[0][3].ToString();
                    TelephonetextBox.Text = table4.Rows[0][4].ToString();
                    AgetextBox.Text = table4.Rows[0][5].ToString();
                    AddresstextBox.Text = table4.Rows[0][6].ToString();
                    ScoretextBox.Text = table4.Rows[0][7].ToString();
                    Id_Post.Text = table4.Rows[0][8].ToString();
                    break;

                case 6:
                    string connectionString5 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection5 = new SqlConnection(connectionString5);
                    connection5.Open();
                    SqlDataAdapter dataAdapter5 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 23 AND Кандидаты.Код_Кандидата =" + id, connection5);
                    DataTable table5 = new DataTable();
                    dataAdapter5.Fill(table5);
                    connection5.Close();
                    FIOtextBox.Text = table5.Rows[0][1].ToString();
                    byte[] photoBytes5 = (byte[])table5.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes5))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table5.Rows[0][3].ToString();
                    TelephonetextBox.Text = table5.Rows[0][4].ToString();
                    AgetextBox.Text = table5.Rows[0][5].ToString();
                    AddresstextBox.Text = table5.Rows[0][6].ToString();
                    ScoretextBox.Text = table5.Rows[0][7].ToString();
                    Id_Post.Text = table5.Rows[0][8].ToString();
                    break;

                case 7:
                    string connectionString6 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection6 = new SqlConnection(connectionString6);
                    connection6.Open();
                    SqlDataAdapter dataAdapter6 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 24 AND Кандидаты.Код_Кандидата =" + id, connection6);
                    DataTable table6 = new DataTable();
                    dataAdapter6.Fill(table6);
                    connection6.Close();
                    FIOtextBox.Text = table6.Rows[0][1].ToString();
                    byte[] photoBytes6 = (byte[])table6.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes6))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table6.Rows[0][3].ToString();
                    TelephonetextBox.Text = table6.Rows[0][4].ToString();
                    AgetextBox.Text = table6.Rows[0][5].ToString();
                    AddresstextBox.Text = table6.Rows[0][6].ToString();
                    ScoretextBox.Text = table6.Rows[0][7].ToString();
                    Id_Post.Text = table6.Rows[0][8].ToString();
                    break;

                case 8:
                    string connectionString7 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection7 = new SqlConnection(connectionString7);
                    connection7.Open();
                    SqlDataAdapter dataAdapter7 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 26 AND Кандидаты.Код_Кандидата =" + id, connection7);
                    DataTable table7 = new DataTable();
                    dataAdapter7.Fill(table7);
                    connection7.Close();
                    FIOtextBox.Text = table7.Rows[0][1].ToString();
                    byte[] photoBytes7 = (byte[])table7.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes7))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table7.Rows[0][3].ToString();
                    TelephonetextBox.Text = table7.Rows[0][4].ToString();
                    AgetextBox.Text = table7.Rows[0][5].ToString();
                    AddresstextBox.Text = table7.Rows[0][6].ToString();
                    ScoretextBox.Text = table7.Rows[0][7].ToString();
                    Id_Post.Text = table7.Rows[0][8].ToString();
                    break;

                case 9:
                    string connectionString8 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection8 = new SqlConnection(connectionString8);
                    connection8.Open();
                    SqlDataAdapter dataAdapter8 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 10 AND Кандидаты.Код_Кандидата =" + id, connection8);
                    DataTable table8 = new DataTable();
                    dataAdapter8.Fill(table8);
                    connection8.Close();
                    FIOtextBox.Text = table8.Rows[0][1].ToString();
                    byte[] photoBytes8 = (byte[])table8.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes8))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table8.Rows[0][3].ToString();
                    TelephonetextBox.Text = table8.Rows[0][4].ToString();
                    AgetextBox.Text = table8.Rows[0][5].ToString();
                    AddresstextBox.Text = table8.Rows[0][6].ToString();
                    ScoretextBox.Text = table8.Rows[0][7].ToString();
                    Id_Post.Text = table8.Rows[0][8].ToString();
                    break;

                case 10:
                    string connectionString9 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection9 = new SqlConnection(connectionString9);
                    connection9.Open();
                    SqlDataAdapter dataAdapter9 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 11 AND Кандидаты.Код_Кандидата =" + id, connection9);
                    DataTable table9 = new DataTable();
                    dataAdapter9.Fill(table9);
                    connection9.Close();
                    FIOtextBox.Text = table9.Rows[0][1].ToString();
                    byte[] photoBytes9 = (byte[])table9.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes9))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table9.Rows[0][3].ToString();
                    TelephonetextBox.Text = table9.Rows[0][4].ToString();
                    AgetextBox.Text = table9.Rows[0][5].ToString();
                    AddresstextBox.Text = table9.Rows[0][6].ToString();
                    ScoretextBox.Text = table9.Rows[0][7].ToString();
                    Id_Post.Text = table9.Rows[0][8].ToString();
                    break;

                case 11:
                    string connectionString10 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection10 = new SqlConnection(connectionString10);
                    connection10.Open();
                    SqlDataAdapter dataAdapter10 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 12 AND Кандидаты.Код_Кандидата =" + id, connection10);
                    DataTable table10 = new DataTable();
                    dataAdapter10.Fill(table10);
                    connection10.Close();
                    FIOtextBox.Text = table10.Rows[0][1].ToString();
                    byte[] photoBytes10 = (byte[])table10.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes10))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table10.Rows[0][3].ToString();
                    TelephonetextBox.Text = table10.Rows[0][4].ToString();
                    AgetextBox.Text = table10.Rows[0][5].ToString();
                    AddresstextBox.Text = table10.Rows[0][6].ToString();
                    ScoretextBox.Text = table10.Rows[0][7].ToString();
                    Id_Post.Text = table10.Rows[0][8].ToString();
                    break;

                case 12:
                    string connectionString11 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection11 = new SqlConnection(connectionString11);
                    connection11.Open();
                    SqlDataAdapter dataAdapter11 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 13 AND Кандидаты.Код_Кандидата =" + id, connection11);
                    DataTable table11 = new DataTable();
                    dataAdapter11.Fill(table11);
                    connection11.Close();
                    FIOtextBox.Text = table11.Rows[0][1].ToString();
                    byte[] photoBytes11 = (byte[])table11.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes11))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table11.Rows[0][3].ToString();
                    TelephonetextBox.Text = table11.Rows[0][4].ToString();
                    AgetextBox.Text = table11.Rows[0][5].ToString();
                    AddresstextBox.Text = table11.Rows[0][6].ToString();
                    ScoretextBox.Text = table11.Rows[0][7].ToString();
                    Id_Post.Text = table11.Rows[0][8].ToString();
                    break;

                case 13:
                    string connectionString12 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection12 = new SqlConnection(connectionString12);
                    connection12.Open();
                    SqlDataAdapter dataAdapter12 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 14 AND Кандидаты.Код_Кандидата =" + id, connection12);
                    DataTable table12 = new DataTable();
                    dataAdapter12.Fill(table12);
                    connection12.Close();
                    FIOtextBox.Text = table12.Rows[0][1].ToString();
                    byte[] photoBytes12 = (byte[])table12.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes12))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table12.Rows[0][3].ToString();
                    TelephonetextBox.Text = table12.Rows[0][4].ToString();
                    AgetextBox.Text = table12.Rows[0][5].ToString();
                    AddresstextBox.Text = table12.Rows[0][6].ToString();
                    ScoretextBox.Text = table12.Rows[0][7].ToString();
                    Id_Post.Text = table12.Rows[0][8].ToString();
                    break;

                case 14:
                    string connectionString13 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection13 = new SqlConnection(connectionString13);
                    connection13.Open();
                    SqlDataAdapter dataAdapter13 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 15 AND Кандидаты.Код_Кандидата =" + id, connection13);
                    DataTable table13 = new DataTable();
                    dataAdapter13.Fill(table13);
                    connection13.Close();
                    FIOtextBox.Text = table13.Rows[0][1].ToString();
                    byte[] photoBytes13 = (byte[])table13.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes13))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table13.Rows[0][3].ToString();
                    TelephonetextBox.Text = table13.Rows[0][4].ToString();
                    AgetextBox.Text = table13.Rows[0][5].ToString();
                    AddresstextBox.Text = table13.Rows[0][6].ToString();
                    ScoretextBox.Text = table13.Rows[0][7].ToString();
                    Id_Post.Text = table13.Rows[0][8].ToString();
                    break;

                case 15:
                    string connectionString14 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection14 = new SqlConnection(connectionString14);
                    connection14.Open();
                    SqlDataAdapter dataAdapter14 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 16 AND Кандидаты.Код_Кандидата =" + id, connection14);
                    DataTable table14 = new DataTable();
                    dataAdapter14.Fill(table14);
                    connection14.Close();
                    FIOtextBox.Text = table14.Rows[0][1].ToString();
                    byte[] photoBytes14 = (byte[])table14.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes14))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table14.Rows[0][3].ToString();
                    TelephonetextBox.Text = table14.Rows[0][4].ToString();
                    AgetextBox.Text = table14.Rows[0][5].ToString();
                    AddresstextBox.Text = table14.Rows[0][6].ToString();
                    ScoretextBox.Text = table14.Rows[0][7].ToString();
                    Id_Post.Text = table14.Rows[0][8].ToString();
                    break;

                case 16:
                    string connectionString15 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection15 = new SqlConnection(connectionString15);
                    connection15.Open();
                    SqlDataAdapter dataAdapter15 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 17 AND Кандидаты.Код_Кандидата =" + id, connection15);
                    DataTable table15 = new DataTable();
                    dataAdapter15.Fill(table15);
                    connection15.Close();
                    FIOtextBox.Text = table15.Rows[0][1].ToString();
                    byte[] photoBytes15 = (byte[])table15.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes15))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table15.Rows[0][3].ToString();
                    TelephonetextBox.Text = table15.Rows[0][4].ToString();
                    AgetextBox.Text = table15.Rows[0][5].ToString();
                    AddresstextBox.Text = table15.Rows[0][6].ToString();
                    ScoretextBox.Text = table15.Rows[0][7].ToString();
                    Id_Post.Text = table15.Rows[0][8].ToString();
                    break;

                case 17:
                    string connectionString16 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection16 = new SqlConnection(connectionString16);
                    connection16.Open();
                    SqlDataAdapter dataAdapter16 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 18 AND Кандидаты.Код_Кандидата =" + id, connection16);
                    DataTable table16 = new DataTable();
                    dataAdapter16.Fill(table16);
                    connection16.Close();
                    FIOtextBox.Text = table16.Rows[0][1].ToString();
                    byte[] photoBytes16 = (byte[])table16.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes16))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table16.Rows[0][3].ToString();
                    TelephonetextBox.Text = table16.Rows[0][4].ToString();
                    AgetextBox.Text = table16.Rows[0][5].ToString();
                    AddresstextBox.Text = table16.Rows[0][6].ToString();
                    ScoretextBox.Text = table16.Rows[0][7].ToString();
                    Id_Post.Text = table16.Rows[0][8].ToString();
                    break;

                case 18:
                    string connectionString17 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection17 = new SqlConnection(connectionString17);
                    connection17.Open();
                    SqlDataAdapter dataAdapter17 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 19 AND Кандидаты.Код_Кандидата =" + id, connection17);
                    DataTable table17 = new DataTable();
                    dataAdapter17.Fill(table17);
                    connection17.Close();
                    FIOtextBox.Text = table17.Rows[0][1].ToString();
                    byte[] photoBytes17 = (byte[])table17.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes17))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table17.Rows[0][3].ToString();
                    TelephonetextBox.Text = table17.Rows[0][4].ToString();
                    AgetextBox.Text = table17.Rows[0][5].ToString();
                    AddresstextBox.Text = table17.Rows[0][6].ToString();
                    ScoretextBox.Text = table17.Rows[0][7].ToString();
                    Id_Post.Text = table17.Rows[0][8].ToString();
                    break;

                case 19:
                    string connectionString18 = "Data Source=HOME-PC\\SQLEXPRESS;Initial Catalog=PodborPersonala;Integrated Security=True";
                    SqlConnection connection18 = new SqlConnection(connectionString18);
                    connection18.Open();
                    SqlDataAdapter dataAdapter18 = new SqlDataAdapter
                        ("SELECT Кандидаты.Код_Кандидата, Кандидаты.ФИО, Кандидаты.Фото, Кандидаты.Почта, Кандидаты.Телефон, Кандидаты.Возраст, " +
                        "Кандидаты.Адрес, Кандидаты.Оценка_За_Тест, Должность.Название_Должности " +
                        "FROM Кандидаты, Должность " +
                        "WHERE Кандидаты.Код_Должности = Должность.Код_Должности AND Должность.Код_Должности LIKE 21 AND Кандидаты.Код_Кандидата =" + id, connection18);
                    DataTable table18 = new DataTable();
                    dataAdapter18.Fill(table18);
                    connection18.Close();
                    FIOtextBox.Text = table18.Rows[0][1].ToString();
                    byte[] photoBytes18 = (byte[])table18.Rows[0][2];
                    using (MemoryStream ms = new MemoryStream(photoBytes18))
                    {
                        Image photo = Image.FromStream(ms);
                        PhotopictureBox.Image = photo;
                    }
                    MailtextBox.Text = table18.Rows[0][3].ToString();
                    TelephonetextBox.Text = table18.Rows[0][4].ToString();
                    AgetextBox.Text = table18.Rows[0][5].ToString();
                    AddresstextBox.Text = table18.Rows[0][6].ToString();
                    ScoretextBox.Text = table18.Rows[0][7].ToString();
                    Id_Post.Text = table18.Rows[0][8].ToString();
                    break;
            }
        }

        private void DecisionButton_MouseEnter(object sender, EventArgs e)
        {
            DecisionButton.ForeColor = Color.White;
        }

        private void DecisionButton_MouseLeave(object sender, EventArgs e)
        {
            DecisionButton.ForeColor = Color.Black;
        }

        private void DecisionButton_Click(object sender, EventArgs e)
        {
            Decision decision = new Decision(id);
            decision.ShowDialog();
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
