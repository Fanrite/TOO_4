using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;


namespace TOO_4
{
    class CivilAir : AirCraft
    {
        protected int FlightRange { get; set; }

        public CivilAir() : base()
        {
            FlightRange = Convert.ToInt32(Interaction.InputBox("Введіть дальність польоту літака", "Введення"));
        }

        public CivilAir(string TypeMachine, int Weight, int AmountEngine, int FlightRange) : base(TypeMachine, Weight, AmountEngine)
        {
            this.FlightRange = FlightRange;
        }

        public override void ShowInfo()
        {
            MessageBox.Show($"Данні літака:\nТип (цивільний): {TypeMachine}\nВага: {Weight} ({TypeWeight()})" +
               $"\nДвигун: {TypeEngine()}\nДальність польоту: {FlightRange}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
