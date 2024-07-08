
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controllers;
using DataBase;
using Dominio;


namespace Mercado
{
    public partial class Formulario2 : Form
    {
        List<Articulos>ListaElectronica = new List<Articulos>();
        public Formulario2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {
            CargarFormulario();

            
        }

        private void CargarFormulario()
        {
            Controler controler = new Controler();
            ListaElectronica = controler.listar();
            panelformulario2.DataSource = ListaElectronica;
            panelformulario2.Columns["Imagen"].Visible = false;
            panelformulario2.Columns["id"].Visible = false;
            fotos.Load(ListaElectronica[0].Imagen);
        }


        // Carga la imagen del articulo en el formulario
        private void panelformulario2_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                Articulos seleccionado = (Articulos)panelformulario2.CurrentRow.DataBoundItem;
                fotos.Load(seleccionado.Imagen);
            }
            catch (Exception )
            {

                fotos.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
            }
        }

        private void botonagregar_Click(object sender, EventArgs e)
        {
            FormularioAgregar newFor = new FormularioAgregar();
            newFor.ShowDialog();
            CargarFormulario();
        }

        private void botoneliminar_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();    
            Articulos articulo = (Articulos)panelformulario2.CurrentRow.DataBoundItem;

            try
            {

                control.Eliminar(articulo.Id);
                CargarFormulario();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        private void botonmodificar_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();
            Articulos articulo = (Articulos)panelformulario2.CurrentRow.DataBoundItem;

            try
            {
                FormularioAgregar Modifica = new FormularioAgregar(articulo);
                Modifica.ShowDialog();
                CargarFormulario();
 
                
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
