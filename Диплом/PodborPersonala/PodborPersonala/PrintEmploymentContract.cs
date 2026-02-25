using Microsoft.Office.Interop.Word;
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
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;

namespace PodborPersonala
{
    public partial class PrintEmploymentContract : Form
    {
        private readonly string fail = @"C:/Users/User/Desktop/TrudovoyDogovor.docx";

        public int id;
        public PrintEmploymentContract(int _id)
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
                 ("SELECT Трудовой_Договор.Код_Трудового_Договора, Трудовой_Договор.Дата_Подписания_Договора, Трудовой_Договор.Город_Заключения_Договора, " +
                        "Кандидаты.ФИО AS ФИО_Кандидата, Трудовой_Договор.Серия_Паспорта, Трудовой_Договор.Номер_Паспорта, Сотрудники.ФИО AS ФИО_Сотрудника, Отдел.Название_Отдела, " +
                        "Должность.Название_Должности, Трудовой_Договор.Дата_Начала_Работы, Трудовой_Договор.Время_Начала_Работы " +
                        "FROM Трудовой_Договор, Кандидаты, Сотрудники, Отдел, Должность " +
                        "WHERE Трудовой_Договор.Код_Кандидата = Кандидаты.Код_Кандидата AND Трудовой_Договор.Код_Сотрудника = Сотрудники.Код_Сотрудника " +
                        "AND Трудовой_Договор.Код_Отдела = Отдел.Код_Отдела AND Трудовой_Договор.Код_Должности = Должность.Код_Должности AND Трудовой_Договор.Код_Трудового_Договора =" + id, connection);
            System.Data.DataTable table = new System.Data.DataTable();
            dataAdapter.Fill(table);
            connection.Close();
            NomertextBox.Text = table.Rows[0][0].ToString();
            DateСonclusiontextBox.Text = table.Rows[0][1].ToString();
            CityDetentiontextBox.Text = table.Rows[0][2].ToString();
            CandidatestextBox.Text = table.Rows[0][3].ToString();
            PassportSeriestextBox.Text = table.Rows[0][4].ToString();
            PassportNumbertextBox.Text = table.Rows[0][5].ToString();
            EmployeetextBox.Text = table.Rows[0][6].ToString();
            DepartmenttextBox.Text = table.Rows[0][7].ToString();
            PosttextBox.Text = table.Rows[0][8].ToString();
            StartDatetextBox.Text = table.Rows[0][9].ToString();
            StartTimetextBox.Text = table.Rows[0][10].ToString();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            var nomertextBox = NomertextBox.Text;
            var cityDetentiontextBox = CityDetentiontextBox.Text;
            var dateСonclusiontextBox = DateСonclusiontextBox.Text;
            var candidatestextBox = CandidatestextBox.Text;
            var passportSeriestextBox = PassportSeriestextBox.Text;
            var passportNumbertextBox = PassportNumbertextBox.Text;
            var employeetextBox = EmployeetextBox.Text;
            var departmenttextBox = DepartmenttextBox.Text;
            var posttextBox = PosttextBox.Text;
            var startDatetextBox = StartDatetextBox.Text;
            var startTimetextBox = StartTimetextBox.Text;
            var wordap = new Word.Application();

            wordap.Visible = false;

            var worddoc = wordap.Documents.Open(fail);

            ReplaceWord("{nomertextBox}", nomertextBox, worddoc);
            ReplaceWord("{cityDetentiontextBox}", cityDetentiontextBox, worddoc);
            ReplaceWord("{dateСonclusiontextBox}", dateСonclusiontextBox, worddoc);
            ReplaceWord("{candidatestextBox}", candidatestextBox, worddoc);
            ReplaceWord("{passportSeriestextBox}", passportSeriestextBox, worddoc);
            ReplaceWord("{passportNumbertextBox}", passportNumbertextBox, worddoc);
            ReplaceWord("{employeetextBox}", employeetextBox, worddoc);
            ReplaceWord("{departmenttextBox}", departmenttextBox, worddoc);
            ReplaceWord("{posttextBox}", posttextBox, worddoc);
            ReplaceWord("{startDatetextBox}", startDatetextBox, worddoc);
            ReplaceWord("{startTimetextBox}", startTimetextBox, worddoc);

            worddoc.SaveAs("C:/Users/User/Desktop/TrudovoyDogovor1.docx");

            worddoc.Close();
        }

        private void ReplaceWord(string stubreplace, string text, Word.Document worddoc)
        {
            var range = worddoc.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubreplace, ReplaceWith: text);
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

        private void PrintButton_MouseEnter(object sender, EventArgs e)
        {
            PrintButton.ForeColor = Color.White;
        }

        private void PrintButton_MouseLeave(object sender, EventArgs e)
        {
            PrintButton.ForeColor = Color.Black;
        }
    }
}
