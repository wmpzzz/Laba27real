using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba27
{
    public partial class Ex2Form : Form
    {
        public Ex2Form()
        {
            InitializeComponent();

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            string courses = "";
            foreach (var itemChecked in CoursesCheckedListBox.CheckedItems)
            {
                courses += itemChecked + " ";
            }
            MessageBox.Show("Вы выбрали следующие курсы:\n" + "\t" + courses + "\n");

        }

        private void Ex2Form_Load(object sender, EventArgs e)
        {
            CoursesCheckedListBox.Items.AddRange(new string[] { "Программирование", "Веб-дизайн", "Ракетка", "Кондиции", "Лит Энерджи", "АБАЮДНА", "Гитара", "Найк про", "Палитра", "плаки плаки" });
        }
    }
}
