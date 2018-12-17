using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aceso;
namespace Datos
{
    public class Querys
    {
        basePractica12 contexto;

        public Querys()
        {
            contexto = new basePractica12();
            contexto.Configuration.ProxyCreationEnabled = false;
        }

        public List<personas> SelecAll()
        {
            return contexto.personas.ToList();
        }

        public personas Insertar(personas nueva)
        {
            contexto.personas.Add(nueva);
            contexto.SaveChanges();
            return nueva;
        }

        public bool Actualizar(personas datos)
        {
            personas aux = contexto.personas.Where(t => t.id_pe == datos.id_pe).SingleOrDefault();
            if (aux != null)
            {
                aux.bio_pe = datos.bio_pe;
                aux.dni_pe = datos.dni_pe;
                aux.email_pe = datos.email_pe;
                aux.fecha_pe = datos.fecha_pe;
                aux.foto_pe = datos.foto_pe;
                aux.nombres_pe = datos.nombres_pe;
                aux.web_pe = datos.web_pe;
                contexto.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Eliminar(personas datos)
        {
            personas aux = contexto.personas.Where(t => t.id_pe == datos.id_pe).SingleOrDefault();
            if (aux != null)
            {
                contexto.personas.Remove(aux);
                contexto.SaveChanges();
                return true;
            }
            else
                return false;
        }

    }
}
