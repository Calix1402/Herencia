using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaTeoria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //crear la instancia de la clase gato 

            Gato Gato = new Gato();

            Gato.animalAge = 3;
            Gato.animalFur=true;
            Gato.vidas = 7;

            MessageBox.Show(Gato.getInfo());
            MessageBox.Show(Gato.walk());
            MessageBox.Show(Gato.meuw());
            MessageBox.Show(Gato.walk(" Bartolito ",  " Naño "));
            MessageBox.Show(Gato.run());

            // crear la instancia de clase perro

            Perro Perro = new Perro();
            Perro.animalAge = 4;
            Perro.animalFur = true;
            MessageBox.Show(Perro.getInfo());
            MessageBox.Show(Perro.walk());
            MessageBox.Show(Perro.run());
            MessageBox.Show(Perro.Ladrar());
            
        }
    }
}
