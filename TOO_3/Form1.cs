using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOO_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CivilAir c = new CivilAir("Транспортний", 10, 2, 10000);
            MilitaryAir m = new MilitaryAir("Винищувач", 40, 4);
            AirCraft abs;
            abs = c;
            abs.ShowInfo();
            abs = m;
            abs.ShowInfo(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Поточна кількість об'єктів: {AirCraft.Count}", "Увага!", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CivilAir civilAbs = new CivilAir("Транспортний", 10, 2, 10000);
            civilAbs.ShowInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MilitaryAir militaryAbs = new MilitaryAir("Винищувач", 40, 4);
            militaryAbs.ShowInfo();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CivilAir civilParam = new CivilAir();
            civilParam.ShowInfo();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MilitaryAir militaryParam = new MilitaryAir();
            militaryParam.ShowInfo();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button a = new Button(); Random rnd = new Random();
            a.Width = 200;
            a.Height = 50;
            a.Left = rnd.Next(200);
            a.Top = rnd.Next(200);
            a.Text = ((Button)sender).Text;
            a.Parent = this;
            a.Show();
            a.Click += new System.EventHandler(this.button8_Click);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
                elem.Left += 100;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach (Control elem in this.Controls)
                elem.Top += 100;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            AirCraft abs;
            abs = new CivilAir();
            abs.ShowInfo();
            abs = new MilitaryAir();
            abs.ShowInfo();
        }
    }
}
