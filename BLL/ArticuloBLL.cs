using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ArticuloBLL
    {
        public static bool Guardar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.articulos.Add(articulo) != null)
                {

                    contexto.SaveChanges();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(Articulo articulo)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(articulo).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;

        }

        public static Articulo Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();

            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulo;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            Articulo articulo = new Articulo();
            try
            {
                articulo = contexto.articulos.Find(id);
                contexto.articulos.Remove(articulo);
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static List<Articulo> GetList(Expression<Func<Articulo, bool>> expression)
        {
            Contexto contexto = new Contexto();
            List<Articulo> articulos = new List<Articulo>();

            try
            {
                articulos = contexto.articulos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return articulos;
        }

        public static int CalcularGanancia(int costo, int precio)
        {
            int resultado;
            resultado = precio - costo;
            resultado = resultado / costo;
            resultado *= 100;
            return resultado;

        }
    }
}
