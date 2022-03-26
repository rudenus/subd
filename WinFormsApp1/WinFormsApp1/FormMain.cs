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
    }
}