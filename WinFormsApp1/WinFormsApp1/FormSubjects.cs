using ApplicationDB.Implements;
using ApplicationDB.Tables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormSubjects : Form
    {
        SubjectStorage subjectStorage;
        public FormSubjects()
        {
            InitializeComponent();
            subjectStorage = new SubjectStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdUser.Text, out int temp))
            {
                MessageBox.Show("Введите корректный номер класса", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Литера не может быть пустой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int num = Convert.ToInt32(textBoxIdUser.Text);
            textBoxIdUser.Text = "";
            string name = textBoxName.Text;
            textBoxName.Text = "";
            try
            {
                subjectStorage.Insert(new Subject() { Name = name, User = new User() { Id = num } });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = subjectStorage.GetFullList();
                if (list != null)
                {
                    dataGridView.DataSource = list;
                    dataGridView.Columns[0].Visible = false;
                    dataGridView.Columns[1].AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdUserUpdate.Text, out int temp))
            {
                MessageBox.Show("Введите корректный номер класса", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxNameUpdate.Text == "")
            {
                MessageBox.Show("Литера не может быть пустой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdUpdate.Text, out temp))
            {
                MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBoxIdUpdate.Text);
            int num = Convert.ToInt32(textBoxIdUserUpdate.Text);
            string letter = textBoxNameUpdate.Text;
            textBoxIdUpdate.Text = "";
            textBoxNameUpdate.Text = "";
            textBoxIdUserUpdate.Text = "";
            try
            {
                subjectStorage.Update(new Subject() { Id = id, Name = letter, User = new User() { Id = num} });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdDelete.Text, out int temp))
            {
                MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBoxIdDelete.Text);
            textBoxIdDelete.Text = "";
            try
            {
                subjectStorage.Delete(new Subject() { Id = id });
            }
            catch
            {
                MessageBox.Show("Отсутствует запись с данным индексом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadData();
        }

        private void FormClasses_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
