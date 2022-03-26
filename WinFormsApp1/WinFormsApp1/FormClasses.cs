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
            int num = Convert.ToInt32(textBoxNumber.Text);
            string letter = textBoxLetter.Text;
            classStorage.Insert(new Class() { Number = num, Letter = letter });
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            List<Class> list = classStorage.GetFullList();
            label1.Text = String.Empty;
            foreach(Class item in list) 
            {
                label1.Text += item.Id + " " + item.Number + item.Letter + Environment.NewLine;
            }
        }
    }
}
