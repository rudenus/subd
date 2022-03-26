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
    public partial class FormLessons : Form
    {
        LessonStorage lessonStorage;
        public FormLessons()
        {
            InitializeComponent();
            lessonStorage = new LessonStorage();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxIdUser.Text, out int temp))
            {
                MessageBox.Show("Введите корректный id пользователя", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdSubject.Text, out temp))
            {
                MessageBox.Show("Введите корректный id предмета", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxEstimation.Text, out temp))
            {
                MessageBox.Show("Введите корректную оценку", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }

            int classId = Convert.ToInt32(textBoxIdUser.Text);
            textBoxIdUser.Text = "";
            int roleId = Convert.ToInt32(textBoxIdSubject.Text);
            textBoxIdSubject.Text = "";
            int estimation = Convert.ToInt32(textBoxEstimation.Text);
            textBoxEstimation.Text = "";
            try
            {
                lessonStorage.Insert(new Lesson()
                {
                    Estimation = estimation,
                    date = DateTime.UtcNow,
                    User= new User() { Id = classId },
                    Subject = new Subject() { Id = roleId }
                }) ;
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении урока", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LoadData();
        }
        private void LoadData()
        {
            try
            {
                var list = lessonStorage.GetFullList();
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
            if (!int.TryParse(textBoxUserIdUpdate.Text, out int temp))
            {
                MessageBox.Show("Введите корректный id пользователя", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxSubjectIdUpdate.Text, out temp))
            {
                MessageBox.Show("Введите корректный id предмета", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxEstimationUpdate.Text, out temp))
            {
                MessageBox.Show("Введите корректную оценку", "Ошибка", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(textBoxIdUpdate.Text, out temp))
            {
                MessageBox.Show("Введите корректный Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int id = Convert.ToInt32(textBoxIdUpdate.Text);
            textBoxIdUpdate.Text = "";
            int classId = Convert.ToInt32(textBoxUserIdUpdate.Text);
            textBoxUserIdUpdate.Text = "";
            int roleId = Convert.ToInt32(textBoxSubjectIdUpdate.Text);
            textBoxSubjectIdUpdate.Text = "";
            int estimation = Convert.ToInt32(textBoxEstimationUpdate.Text);
            textBoxEstimationUpdate.Text = "";
            try
            {
                lessonStorage.Update(new Lesson()
                {
                    Id = id,
                    Estimation = estimation,
                    date = DateTime.UtcNow,
                    User = new User() { Id = classId },
                    Subject = new Subject() { Id = roleId }
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
                lessonStorage.Delete(new Lesson() { Id = id });
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
