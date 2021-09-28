using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_4
{
    class MilitaryAir : AirCraft
    {
        public MilitaryAir() : base() { }

        public MilitaryAir(string TypeMachine, int Weight, int AmountEngine) : base(TypeMachine, Weight, AmountEngine) { }

        protected override string TypeWeight()
        {
            if (Weight <= 5) return "Легкомоторний";
            else if (Weight <= 10) return "4-го классу";
            else if (Weight <= 30) return "3-го классу";
            else if (Weight <= 75) return "2-го классу";
            else return "1-го классу";
        }

        public override void ShowInfo()
        {
            MessageBox.Show($"Данні літака:\nТип (військовий): {TypeMachine}\nВага: {Weight} ({TypeWeight()})" +
                $"\nДвигун: {TypeEngine()}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
