using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace TOO_4
{
    abstract class AirCraft
    {
        protected string TypeMachine { get; set; }
        protected int Weight { get; set; }
        protected int AmountEngine { get; set; }
        public static int Count { get; set; } = 0;
        public int Number { get; set; }

        public AirCraft()
        {
            TypeMachine = Interaction.InputBox("Введіть тип літака", "Введення");
            Weight = Convert.ToInt32(Interaction.InputBox("Введіть массу літака", "Введення"));
            AmountEngine = Convert.ToInt32(Interaction.InputBox("Введіть кількість двигунів літака", "Введення"));
            Count++;
            Number = Count;
        }

        public AirCraft(string TypeMachine, int Weight, int AmountEngine)
        {
            this.TypeMachine = TypeMachine;
            this.Weight = Weight;
            this.AmountEngine = AmountEngine;
            Count++;
            Number = Count;
        }

        protected virtual string TypeWeight()
        {
            if (Weight <= 7) return "Легкий";
            else if (Weight <= 136) return "Середній";
            else return "Важкий";
        }

        protected virtual string TypeEngine()
        {
            return $"{AmountEngine}-Двигунний";
        }

        public virtual void ShowInfo()
        {
            MessageBox.Show($"Данні літака:\nТип: {TypeMachine}\nВага: {Weight} ({TypeWeight()})" +
                $"\nДвигун: {TypeEngine()}", "Інформація", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        ~AirCraft()
        {
            MessageBox.Show($"Знищується літак № {Number}", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Count--;
        }
    }
}
