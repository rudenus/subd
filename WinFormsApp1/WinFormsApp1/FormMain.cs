namespace WinFormsApp1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormUsers form = new FormUsers();
            form.ShowDialog();
        }

        private void buttonClasses_Click(object sender, EventArgs e)
        {
            FormClasses form = new FormClasses();
            form.ShowDialog();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            FormSubjects form = new FormSubjects();
            form.ShowDialog();
        }

        private void buttonLesson_Click(object sender, EventArgs e)
        {
            FormLessons form = new FormLessons();
            form.ShowDialog();
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            FormRoles form = new FormRoles();
            form.ShowDialog();
        }
    }
}