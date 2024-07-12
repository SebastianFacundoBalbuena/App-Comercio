using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using DataBase;

namespace Controllers
{
    public class Controler
    {
        //metodo traer todos los elementos
        public  List<Articulos> listar() {

            List<Articulos> ListaArticulo = new List<Articulos>();

            Data data = new Data();

            
            //newArticulo.categoria = new Categoria();
            try
            {
                
                data.setearConsulta("select A.Id as Id,A.Codigo as Codigo,Nombre, A.Descripcion Descripcion,C.Descripcion as Categoria, M.Descripcion as MarcaDes,Precio,A.ImagenUrl from ARTICULOS A, MARCAS M,CATEGORIAS C where A.IdMarca = M.Id AND A.IdCategoria = C.Id");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())

                {
                    Categoria categoria = new Categoria();
                    Marca marca = new Marca();
                    
                    Articulos newArticulo = new Articulos(categoria,marca);

                    //validacion de NULL
                    if (!(data.LectorReader["Codigo"] is DBNull))
                    newArticulo.Codigo = (string)data.LectorReader["Codigo"];

                    newArticulo.Id = (int)data.LectorReader["Id"];
                    newArticulo.Nombre = (string)data.LectorReader["Nombre"];
                    newArticulo.Descripcion = (string)data.LectorReader["Descripcion"];
                    marca.Marcas = (string)data.LectorReader["MarcaDes"];
                    newArticulo.Imagen = (string)data.LectorReader["ImagenUrl"];
                    newArticulo.Precio = (decimal)data.LectorReader["Precio"];
                    categoria.Categorias = (string)data.LectorReader["Categoria"];




                    ListaArticulo.Add(newArticulo);
                }

                return ListaArticulo;

            }
			catch (Exception ex)
			{

				throw ex;
			}
            finally
            {
                data.cerrarConexion();
            }
        }

        
        //metodo traer MARCAS

        public List<Marca> MarcaListar()
        {

            List<Marca> marca = new List<Marca>();
            Data data = new Data();

            try
            {
                
                data.setearConsulta("select Id,Descripcion FROM MARCAS");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())
                {
                    Marca newMarca = new Marca();

                    newMarca.Marcas = (string)data.LectorReader["Descripcion"];
                    newMarca.Id = (int)data.LectorReader["Id"];

                    marca.Add(newMarca);
                }


                return marca;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }

        //metodo traer CATEGORIAS

        public List<Categoria> CategoriaLista()
        {
            Data data = new Data();
            List<Categoria> categoria = new List<Categoria>();
            try
            {
                data.setearConsulta("select Id,Descripcion FROM CATEGORIAS");
                data.ejecutarConsulta();

                while (data.LectorReader.Read())
                {
                    Categoria newCategoria = new Categoria();

                    newCategoria.Categorias = (string)data.LectorReader["Descripcion"];
                    newCategoria.Id = (int)data.LectorReader["Id"];

                    categoria.Add(newCategoria);
                }

                return categoria;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        // metodo agregar
        public void Agregar(Articulos newArticulos, Categoria idCategoria, Marca idMarca)
        {
            Data data = new Data();
            try
            {
                


                data.setearConsulta("insert into ARTICULOS (Codigo,Nombre,Descripcion,ImagenUrl,Precio,IdCategoria,IdMarca)values('" + newArticulos.Codigo + "','" + newArticulos.Nombre + "','" + newArticulos.Descripcion + "','" + newArticulos.Imagen + "', "+ newArticulos.Precio +  " ," + idCategoria.Id + "," + idMarca.Id + " )");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        //Metodo eliminar art
        public void Eliminar(int id)
        {
            Data data = new Data();
            Categoria cat = new Categoria();
            Marca marca = new Marca();
            Articulos artEliminar = new Articulos(cat,marca);
            try
            {
                data.setearConsulta("delete ARTICULOS where id = " + id + "");
                data.EjecutarAccion();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                data.cerrarConexion();
            }
        }


        //Metodo modificar art
        public void Modificar(Articulos articulo, Categoria categoria, Marca marca)
        {
            Data data = new Data();

            try
            {
                data.setearConsulta("update ARTICULOS set Codigo = '" + articulo.Codigo + "', Nombre = '" + articulo.Nombre + "', Descripcion = '" + articulo.Descripcion + "', IdMarca = " + marca.Id + ", IdCategoria = " + categoria.Id + ", ImagenUrl = '" + articulo.Imagen + "', Precio = " + articulo.Precio + " where Id = " + articulo.Id + " ");
                data.EjecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
