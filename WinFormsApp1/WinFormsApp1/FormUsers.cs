using ApplicationDB.Implements;
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

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //userStorage.Insert()
        }
    }
}
