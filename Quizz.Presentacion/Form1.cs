using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quizz.Entidades;
using Quizz.Logica;

namespace Quizz.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        LogicaProyecto logicaproyecto = new LogicaProyecto();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaisText.Text != "" && ProvinciaText.Text != "" && DistritoText.Text != "" && Detalles1Text.Text != "" && Detalles2Text.Text != "" && TelFijoText.Text != "")
                {

                    Direcciones direcciones = new Direcciones(int.Parse(IDText.Text), PaisText.Text, ProvinciaText.Text, DistritoText.Text, Detalles1Text.Text, Detalles2Text.Text, int.Parse(TelFijoText.Text));

                    logicaproyecto.InsertarDireccion(direcciones);

                }

                else

                    MessageBox.Show("Todos los campos deben de estar llenos");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
