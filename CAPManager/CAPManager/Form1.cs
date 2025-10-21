using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
using System.Diagnostics;

namespace CAPManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread T = new Thread(new ThreadStart(SplashStart));
            T.Start();
            Thread.Sleep(2000);
            InitializeComponent();
            T.Abort();
        }
        private void CrearExpediente_Click(object sender, EventArgs e)
        {
            String Carpeta = Application.StartupPath + @"Expedientes\Pacientes\EXP1";

            try
            {
                if (Directory.Exists(Carpeta))
                {
                    MessageBox.Show("La carpeta ya existe");
                }
                else
                {
                    MessageBox.Show("El directorio no existe, se esta creando");
                    Directory.CreateDirectory(Carpeta);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubo un error al crear la carpeta");
            }
        }
        private void AbrirBiblioteca_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"Biblioteca");
        }
        private void AbrirPacientes_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", @"Expedientes\Pacientes");
        }
        private void Agregar_Click(object sender, EventArgs e)
        {
            if (TextoFecha.Text != "" && TextoTipo.Text != "" && TextoAsunto.Text != "" && TextoTipo.Text != "" && TextoCuatrimestre.Text != "" && TextoDia.Text != "")
            {
                DGVAgenda.Rows.Add(TextoFecha.Text, TextoTipo.Text, TextoAsunto.Text, TextoTipo.Text, TextoCuatrimestre.Text, TextoDia.Text);
                MessageBox.Show("Datos ingresados");
            }
            else
            {
                MessageBox.Show("Ingrese los datos en las partes faltantes");
            }
        }
        private void Quitar_Click(object sender, EventArgs e)
        {
            string Texto = "¿Esta seguro de eliminar la fila?";
            string Titulo = "Advertencia";

            MessageBoxButtons Botones = MessageBoxButtons.YesNo;
            DialogResult Resultado = MessageBox.Show(Texto, Titulo, Botones);
            if (Resultado == DialogResult.Yes)
            {
                foreach (DataGridViewRow item in this.DGVAgenda.SelectedRows)
                {
                    DGVAgenda.Rows.RemoveAt(item.Index);
                }
            }
            else
            {
                MessageBox.Show("No ha seleccionado una fila");
            }
        }
        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Acercade acercade = new Acercade();
            acercade.ShowDialog();
        }
        private void GuardarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWriter Writer = new StreamWriter(@"Sesiones\Sesion.txt");
            for (int i = 0; i < DGVAgenda.Rows.Count - 1; i++)
            {
                for (int j = 0; j < DGVAgenda.Columns.Count; j++)
                {
                    Writer.Write("\t" + DGVAgenda.Rows[i].Cells[j].Value.ToString() + "\t"+"|");
                }
            }
            Writer.Close();
            MessageBox.Show("Se ha guardado la sesión");
        }
        private void AbrirSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Abrir.ShowDialog();
        }
        private void GuardarSesionComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar1.ShowDialog();
        }
        public void SplashStart()
        {
            Application.Run(new Splash());
        }
    }
}