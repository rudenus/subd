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
    public partial class FormUsers : Form
    {
        UserStorage userStorage;
        public FormUsers()
        {
            InitializeComponent();
            userStorage = new UserStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdClass.Text, out int temp))
            {
                MessageBox.Show("Введите корректный id класса", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdRole.Text, out temp))
            {
                MessageBox.Show("Введите корректный id роли", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxLogin.Text == "")
            {
                MessageBox.Show("Логин не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxName.Text== "")
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPassword.Text == "")
            {
                MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int classId = Convert.ToInt32(textBoxIdClass.Text);
            textBoxIdClass.Text = "";
            int roleId = Convert.ToInt32(textBoxIdRole.Text);
            textBoxIdRole.Text = "";
            string login = textBoxLogin.Text;
            textBoxLogin.Text = "";
            string password= textBoxPassword.Text;
            textBoxPassword.Text = "";
            string name = textBoxName.Text;
            textBoxName.Text = "";
            try
            {
                userStorage.Insert(new User()
                {
                    Login = login,
                    Name = name,
                    Password = password,
                    Class = new Class() { Id = classId },
                    Role = new Role() { Id = roleId }
                });
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении пользователя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = userStorage.GetFullList();
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
            if (!int.TryParse(textBoxIdUpdate.Text, out int temp))
            {
                MessageBox.Show("Введите корректный id", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdClassUpdate.Text, out  temp))
            {
                MessageBox.Show("Введите корректный id класса", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdRoleUpdate.Text, out temp))
            {
                MessageBox.Show("Введите корректный id роли", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (textBoxLoginUpdate.Text == "")
            {
                MessageBox.Show("Логин не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxNameUpdate.Text == "")
            {
                MessageBox.Show("Имя не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBoxPasswordUpdate.Text == "")
            {
                MessageBox.Show("Пароль не может быть пустым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBoxIdUpdate.Text);
            textBoxIdUpdate.Text = "";
            int classId = Convert.ToInt32(textBoxIdClassUpdate.Text);
            textBoxIdClassUpdate.Text = "";
            int roleId = Convert.ToInt32(textBoxIdRoleUpdate.Text);
            textBoxIdRoleUpdate.Text = "";
            string login = textBoxLoginUpdate.Text;
            textBoxLoginUpdate.Text = "";
            string password = textBoxPasswordUpdate.Text;
            textBoxPasswordUpdate.Text = "";
            string name = textBoxNameUpdate.Text;
            textBoxNameUpdate.Text = "";
            try
            {
                userStorage.Update(new User()
                {
                    Id = id,
                    Login = login,
                    Name = name,
                    Password = password,
                    Class = new Class() { Id = classId },
                    Role = new Role() { Id = roleId }
                });
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
                userStorage.Delete(new User() { Id = id });
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
