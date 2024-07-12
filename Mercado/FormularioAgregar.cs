using Controllers;
using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mercado;
using System.Runtime.InteropServices;


namespace Mercado
{
    public partial class FormularioAgregar : Form
    {

        private Articulos articulo = null;
        public FormularioAgregar()
        {
            InitializeComponent();
        }

        public FormularioAgregar(Articulos articulo)
        {
            this.articulo = articulo;
            InitializeComponent();
            
        }

        private void cancelarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Agregar Articulo
        private void agregarnuevoarticulo_Click(object sender, EventArgs e)
        {
            Controler control = new Controler();

            Categoria categoria = new Categoria();
            Marca marca = new Marca();

            try
            {
                if (articulo == null)
                    articulo = new Articulos(categoria, marca);


                articulo.Codigo = barracodigo.Text.ToString();
                articulo.Nombre = barranombre.Text;
                articulo.Precio = decimal.Parse(barraprecio.Text);
                articulo.Descripcion = barradescripcion.Text;
                articulo.Imagen = barraimagen.Text;
                categoria.Id = ((Categoria)barracategoria.SelectedItem).Id;
                marca.Id = ((Marca)barramarca.SelectedItem).Id;


                if (articulo.Id != 0)
                {
                    control.Modificar(articulo, categoria, marca);
                    MessageBox.Show("Modificado exitosamente!");
                }
                else
                {
                    control.Agregar(articulo, categoria, marca);
                    MessageBox.Show("Agregado exitosamente!");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Asegurese de utilizar numeros sin ( , ) y en su lugar utilizar ( . ) ");
            }


        }


        // Mostrar datos en las barras Categoria y Marca
        private void FormularioAgregar_Load(object sender, EventArgs e)
        {
            Controler control = new Controler();
            Formulario2 formilario = new Formulario2();
            List<Categoria> categoria = control.CategoriaLista();   
            List<Marca> marca = control.MarcaListar();



            barracategoria.DataSource = categoria;

            barramarca.DataSource = marca;


            //Mostra datos si se ha marcado la opcion MODIFICAR
            if(this.articulo != null)
            {
                barracodigo.Text = articulo.Codigo;
                barranombre.Text = articulo.Nombre;
                barradescripcion.Text = articulo.Descripcion;
                if (articulo.Imagen != "")
                {
                    imagenAgregar.Load(articulo.Imagen);
                }
                else
                {
                    imagenAgregar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
                }
                barraimagen.Text = articulo.Imagen;
                barraprecio.Text = articulo.Precio.ToString();
                barracategoria.Text = articulo.Categoria;
                barramarca.Text = articulo.Marca;
            }
            
            
        }

        private void barraimagen_Leave(object sender, EventArgs e)
        {
            try
            {
                
                imagenAgregar.Load(barraimagen.Text);
            }
            catch (Exception)
            {

                imagenAgregar.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSi6dicyRXDD9U9eeuelNPyB8lh-dImHhiEvQ&s");
            }
        }

        // mover ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
