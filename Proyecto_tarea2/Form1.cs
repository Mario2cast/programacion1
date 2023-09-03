using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_tarea2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIngresarNota_Click(object sender, EventArgs e)
        {
            int CantidadNotas, nota = 0, i;
            string Nombre, Estado;
            double Promedio = 0;
            Estado = (txtEstado.Text);
            Nombre = (txtNombreAlumno.Text);
            CantidadNotas = int.Parse(txtCantidadNotas.Text);
            for (i = 1; i <= CantidadNotas; i++)
            {
                do
                {
                    nota = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("ingrese la nota: " + i, "Registro de nota"));
                }
                while (nota < 0 || nota > 10);
                Promedio += nota;


            }
            Promedio = Promedio / CantidadNotas;

            if (Promedio >= 6)
            {
                Estado = "Aprobado";
            }
            else
            {
                Estado = "Reprobado";
            }
            txtPromedio.Text = Convert.ToString(Promedio);
            txtNombre.Text = Nombre;
            txtEstado.Text = Estado;

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            txtCantidadNotas.Clear();
            txtPromedio.Clear();
            txtNombre.Clear();
            txtNombreAlumno.Clear();
            txtEstado.Clear();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
