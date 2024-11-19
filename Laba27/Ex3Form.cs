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
    public partial class Ex3Form : Form
    {
        public Ex3Form()
        {
            InitializeComponent();
        }

        private void Ex3Form_Load(object sender, EventArgs e)
        {
            PlayerListBox.Items.Add("Иван Золочевский");
            PlayerListBox.Items.Add("Мишаня Кондиционер");
            PlayerListBox.Items.Add("Субарик Суба");
            PlayerListBox.Items.Add("Аделька");
            PlayerListBox.Items.Add("вова братишкин");
        }

        private void ToPlayerButton_Click(object sender, EventArgs e)
        {
            if (NewPlayerTextBox.Text != "")
            {
                PlayerListBox.Items.Add(NewPlayerTextBox.Text);
            }
        }

        private void ToNotPlayerButton_Click(object sender, EventArgs e)
        {
            NotPlayerListBox.Items.Add(PlayerListBox.Text);
            PlayerListBox.Items.RemoveAt(PlayerListBox.SelectedIndex);
        }

        private void ToAllNotPlayerButton_Click(object sender, EventArgs e)
        {
            foreach (var obj in PlayerListBox.Items)
                NotPlayerListBox.Items.Add(obj);
            PlayerListBox.Items.Clear();
        }
    }
}
