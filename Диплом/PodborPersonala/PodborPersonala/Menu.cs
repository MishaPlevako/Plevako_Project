using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PodborPersonala
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void художникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 1;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void дизайнерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 2;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void программистыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 3;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void техническиеПисателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 4;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void менеджерыПроектаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 5;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void специалистыПоБезопасностиТестированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 6;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void тестировщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 7;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void аналитикиТестированияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 8;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void бухгалтераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 9;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void финансовыеАналитикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 10;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void менеджерыПоПодборуПерсоналаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 11;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void менеджерыПоОбучениюИРазвитиюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 12;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void инспекторыПоКадрамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 13;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void менеджерыПоПродажамToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 14;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void менеджерыПоРаботеСПартнёрамиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 15;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void маркетологиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 16;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void специалистыПоСоциальнымСетямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 17;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void переводчикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 18;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void редакторыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 19;
            SelectedCandidates WorkSpace = new SelectedCandidates();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void принятыеСобеседованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 20;
            AcceptedInterviews WorkSpace = new AcceptedInterviews();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void назначенныеСобеседованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 21;
            ExpectedInterviews WorkSpace = new ExpectedInterviews();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void отклонённыеСобеседованияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 22;
            RejectedInterviews WorkSpace = new RejectedInterviews();
            WorkSpace.Owner = this;
            WorkSpace.Show();
        }

        private void трудовойДоговорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.l = 23;
            EmploymentContract WorkSpace = new EmploymentContract();
            WorkSpace.Owner = this;
            WorkSpace.Show();
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

        private void вакансииToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            вакансииToolStripMenuItem.ForeColor = Color.White;
        }

        private void вакансииToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            вакансииToolStripMenuItem.ForeColor = Color.Black;
        }

        private void собеседованияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            собеседованияToolStripMenuItem.ForeColor = Color.White;
        }

        private void собеседованияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            собеседованияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void принятыеСобеседованияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            принятыеСобеседованияToolStripMenuItem.ForeColor = Color.White;
        }

        private void принятыеСобеседованияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            принятыеСобеседованияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void назначенныеСобеседованияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            назначенныеСобеседованияToolStripMenuItem.ForeColor = Color.White;
        }

        private void назначенныеСобеседованияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            назначенныеСобеседованияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отклонённыеСобеседованияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отклонённыеСобеседованияToolStripMenuItem.ForeColor = Color.White;
        }

        private void отклонённыеСобеседованияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отклонённыеСобеседованияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void документыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            документыToolStripMenuItem.ForeColor = Color.White;
        }

        private void документыToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            документыToolStripMenuItem.ForeColor = Color.Black;
        }

        private void трудовойДоговорToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            трудовойДоговорToolStripMenuItem.ForeColor = Color.White;
        }

        private void трудовойДоговорToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            трудовойДоговорToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделРазработкиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделРазработкиToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделРазработкиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделРазработкиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделТестированияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделТестированияToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделТестированияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделТестированияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделБухгалтерииToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделБухгалтерииToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделБухгалтерииToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделБухгалтерииToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделКадровToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделКадровToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделКадровToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделКадровToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделПродажToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделПродажToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделПродажToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделПродажToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделМаркетингаToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделМаркетингаToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделМаркетингаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделМаркетингаToolStripMenuItem.ForeColor = Color.Black;
        }

        private void отделЛокализацииToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            отделЛокализацииToolStripMenuItem.ForeColor = Color.White;
        }

        private void отделЛокализацииToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            отделЛокализацииToolStripMenuItem.ForeColor = Color.Black;
        }

        private void художникиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            художникиToolStripMenuItem.ForeColor = Color.White;
        }

        private void художникиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            художникиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void дизайнерыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            дизайнерыToolStripMenuItem.ForeColor = Color.White;
        }

        private void дизайнерыToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            дизайнерыToolStripMenuItem.ForeColor = Color.Black;
        }

        private void программистыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            программистыToolStripMenuItem.ForeColor = Color.White;
        }

        private void программистыToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            программистыToolStripMenuItem.ForeColor = Color.Black;
        }

        private void техническиеПисателиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            техническиеПисателиToolStripMenuItem.ForeColor = Color.White;
        }

        private void техническиеПисателиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            техническиеПисателиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void менеджерыПроектаToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            менеджерыПроектаToolStripMenuItem.ForeColor = Color.White;
        }

        private void менеджерыПроектаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            менеджерыПроектаToolStripMenuItem.ForeColor = Color.Black;
        }

        private void специалистыПоБезопасностиТестированияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            специалистыПоБезопасностиТестированияToolStripMenuItem.ForeColor = Color.White;
        }

        private void специалистыПоБезопасностиТестированияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            специалистыПоБезопасностиТестированияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void тестировщикиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            тестировщикиToolStripMenuItem.ForeColor = Color.White;
        }

        private void тестировщикиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            тестировщикиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void аналитикиТестированияToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            аналитикиТестированияToolStripMenuItem.ForeColor = Color.White;
        }

        private void аналитикиТестированияToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            аналитикиТестированияToolStripMenuItem.ForeColor = Color.Black;
        }

        private void бухгалтераToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            бухгалтераToolStripMenuItem.ForeColor = Color.White;
        }

        private void бухгалтераToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            бухгалтераToolStripMenuItem.ForeColor = Color.Black;
        }

        private void финансовыеАналитикиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            финансовыеАналитикиToolStripMenuItem.ForeColor = Color.White;
        }

        private void финансовыеАналитикиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            финансовыеАналитикиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void менеджерыПоПодборуПерсоналаToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            менеджерыПоПодборуПерсоналаToolStripMenuItem.ForeColor = Color.White;
        }

        private void менеджерыПоПодборуПерсоналаToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            менеджерыПоПодборуПерсоналаToolStripMenuItem.ForeColor = Color.Black;
        }

        private void менеджерыПоОбучениюИРазвитиюToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            менеджерыПоОбучениюИРазвитиюToolStripMenuItem.ForeColor = Color.White;
        }

        private void менеджерыПоОбучениюИРазвитиюToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            менеджерыПоОбучениюИРазвитиюToolStripMenuItem.ForeColor = Color.Black;
        }

        private void инспекторыПоКадрамToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            инспекторыПоКадрамToolStripMenuItem.ForeColor = Color.White;
        }

        private void инспекторыПоКадрамToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            инспекторыПоКадрамToolStripMenuItem.ForeColor = Color.Black;
        }

        private void менеджерыПоПродажамToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            менеджерыПоПродажамToolStripMenuItem.ForeColor = Color.White;
        }

        private void менеджерыПоПродажамToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            менеджерыПоПродажамToolStripMenuItem.ForeColor = Color.Black;
        }

        private void менеджерыПоРаботеСПартнёрамиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            менеджерыПоРаботеСПартнёрамиToolStripMenuItem.ForeColor = Color.White;
        }

        private void менеджерыПоРаботеСПартнёрамиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            менеджерыПоРаботеСПартнёрамиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void маркетологиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            маркетологиToolStripMenuItem.ForeColor = Color.White;
        }

        private void маркетологиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            маркетологиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void специалистыПоСоциальнымСетямToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            специалистыПоСоциальнымСетямToolStripMenuItem.ForeColor = Color.White;
        }

        private void специалистыПоСоциальнымСетямToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            специалистыПоСоциальнымСетямToolStripMenuItem.ForeColor = Color.Black;
        }

        private void переводчикиToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            переводчикиToolStripMenuItem.ForeColor = Color.White;
        }

        private void переводчикиToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            переводчикиToolStripMenuItem.ForeColor = Color.Black;
        }

        private void редакторыToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            редакторыToolStripMenuItem.ForeColor = Color.White;
        }

        private void редакторыToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            редакторыToolStripMenuItem.ForeColor = Color.Black;
        }
    }
}
