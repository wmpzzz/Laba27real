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
    public partial class Ex1Form : Form
    {
        public Ex1Form()
        {
            InitializeComponent();
            
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Билет: Архангельск - " + CityComboBox.Text);
        }

        private void Ex1Form_Load(object sender, EventArgs e)
        {
            CityComboBox.Items.Add("Северодвинск");
            CityComboBox.Items.Add("Онега");
            CityComboBox.Items.Add("Котлас");
            CityComboBox.Items.Add("Новодвинск");
        }
    }
}
