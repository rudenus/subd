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
    public partial class FormClasses : Form
    {
        ClassStorage classStorage;
        public FormClasses()
        {
            InitializeComponent();
            classStorage = new ClassStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxNumber.Text, out int temp))
            {
                MessageBox.Show("Введите корректный номер класса","Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if(textBoxLetter.Text == "")
            {
                MessageBox.Show("Литера не может быть пустой", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int num = Convert.ToInt32(textBoxNumber.Text);
            textBoxNumber.Text = "";
            string letter = textBoxLetter.Text;
            textBoxLetter.Text = "";
            classStorage.Insert(new Class() { Number = num, Letter = letter });
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Class> list;
                if (textBoxFiltred.Text != "")
                {
                    if(!int.TryParse(textBoxFiltred.Text, out int temp))
                    {
                        MessageBox.Show("Номер класса должен быть целым числом", "Ошибка", MessageBoxButtons.OK,
              MessageBoxIcon.Error);
                        return;
                    }
                    list = classStorage.GetFiltredList(Convert.ToInt32(textBoxFiltred.Text));
                }
                else
                {
                    list = classStorage.GetFullList();
                }
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
            if (!int.TryParse(textBoxNumberUpdate.Text, out int temp))
            {
                MessageBox.Show("Введите корректный номер класса", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxLetterUpdate.Text == "")
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
            textBoxIdUpdate.Text = "";
            int num = Convert.ToInt32(textBoxNumberUpdate.Text);
            textBoxNumberUpdate.Text = "";
            string letter = textBoxLetterUpdate.Text;
            textBoxLetterUpdate.Text = "";
            try
            {
                classStorage.Update(new Class() { Id = id, Number = num, Letter = letter });
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
                classStorage.Delete(new Class() { Id = id });
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
