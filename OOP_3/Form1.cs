using OOP_3.AnimalZoo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxInfo_TextChanged(object sender, EventArgs e)
        {
            //111
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal lion = new Animal("Лев", 150, 8, 3000);
            MessageBox.Show(lion.GetInfo(), "Інформація про тварину", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Створення об'єкту вовка
            Wolf wolf = new Wolf(30, 3, 450, "Сірий Вовк", "Ліси"); ; ;
            // Виведення інформації про вовка в MessageBox
            MessageBox.Show(wolf.GetInfo(), "Інформація про Вовка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    namespace AnimalZoo
    {
        // Базовий абстрактний клас Animal
        class Animal
        {
            protected string species;
            protected double weight;
            protected int age;
            protected double dailyMaintenanceCost;

            public Animal(double weight, int age, double dailyMaintenanceCost)
            {
                this.weight = weight;
                this.age = age;
                this.dailyMaintenanceCost = dailyMaintenanceCost;
            }

            public Animal(string species, double weight, int age, double dailyMaintenanceCost)
            {
                this.species = species;
                this.weight = weight;
                this.age = age;
                this.dailyMaintenanceCost = dailyMaintenanceCost;
            }

            public virtual string GetInfo()
            {
                return $"Вид: {species}, Вага: {weight} кг, Вік: {age} років, Вартість обслуговування: {dailyMaintenanceCost}$";
            }
        }

        // Похідний клас Wolf, який наслідує клас Animal
        class Wolf : Animal
        {
            private string breed;
            private string naturalHabitat;

            // Конструктор похідного класу Wolf, ініціалізує конструктор базового класу Animal
            public Wolf(double weight, int age, double dailyMaintenanceCost, string breed, string naturalHabitat)
                : base(weight, age, dailyMaintenanceCost)
            {
                this.breed = breed;
                this.naturalHabitat = naturalHabitat;
            }

            // Перевизначення методу GetInfo для виведення інформації про вовка
            public override string GetInfo()
            {
                return $"Вид: Вовк, Порода: {breed}, Природне середовище проживання: {naturalHabitat}, Вага: {weight} кг, Вік: {age} роки, Вартість обслуговування: {dailyMaintenanceCost}$";
            }
        }

  
    }
}

