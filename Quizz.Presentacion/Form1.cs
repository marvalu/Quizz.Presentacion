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


        public void MostrarTodo() {



            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = logicaproyecto.mostrar();
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaisText.Text != "" && ProvinciaText.Text != "" && DistritoText.Text != "" && Detalles1Text.Text != "" && Detalles2Text.Text != "" && TelFijoText.Text != "")
                {

                    Direcciones direcciones = new Direcciones(int.Parse(IDText.Text), PaisText.Text, ProvinciaText.Text, DistritoText.Text, Detalles1Text.Text, Detalles2Text.Text, int.Parse(TelFijoText.Text));

                    logicaproyecto.InsertarDireccion(direcciones);
                    MostrarTodo();

                }

                else

                    MessageBox.Show("Todos los campos deben de estar llenos");

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Direcciones direcciones = new Direcciones(int.Parse(IDText.Text), PaisText.Text, ProvinciaText.Text, DistritoText.Text, Detalles1Text.Text, Detalles2Text.Text, int.Parse(TelFijoText.Text));

           logicaproyecto.modificar(direcciones);
            MostrarTodo();
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (IDText.Text != "") {
                    MessageBox.Show("Se borrara el dato con el ID insertado");

                    logicaproyecto.Eliminar(int.Parse(IDText.Text));
                    MostrarTodo();

                }
            }
            catch (Exception)
            {

                MessageBox.Show("no existe ningun ID con ese num para eliminar");
            }
        }
        }
    }
