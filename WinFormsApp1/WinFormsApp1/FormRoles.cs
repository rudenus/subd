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
    public partial class FormRoles : Form
    {
        RoleStorage roleStorage;
        public FormRoles()
        {
            InitializeComponent();
            roleStorage = new RoleStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                MessageBox.Show("Название не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string name = textBoxName.Text;
            textBoxName.Text = "";
            roleStorage.Insert(new Role() { Name = name});
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                List<Role> list;
                if (textBoxFiltred.Text != "")
                {
                    list = roleStorage.GetFiltredList(textBoxFiltred.Text);
                }
                else
                {
                    list = roleStorage.GetFullList();
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
            if (textBoxNameUpdate.Text == "")
            {
                MessageBox.Show("Название не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdUpdate.Text,out int temp))
            {
                MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBoxIdUpdate.Text);
            textBoxIdUpdate.Text = "";
            string name = textBoxNameUpdate.Text;
            textBoxNameUpdate.Text = "";
            try
            {
                roleStorage.Update(new Role() { Id = id, Name = name});
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
                roleStorage.Delete(new Role() { Id = id });
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

