using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMedidores.DAL
{
    public class ListaMedidoresDAL : IMedidoresDAL
    {
        private static List<Medidor> lista = new List<Medidor>();
        private static List<String> listaTipo = new List<String>() {"Medidor de Agua","Medidor de Gas","Medidor de Luz" };

        public List<String> ObtenerListaTipo() {
            return listaTipo;
        }
        
        public List<Medidor> ObtenerListaMedidores() { 
            
            return lista;
        }

        public bool ExisteMedidor(int id) {

            bool exist = false;
            for (int i = 0; i < ObtenerListaMedidores().Count; i++)
            {
                if (ObtenerListaMedidores()[i].Id == id.ToString())
                {
                    
                    exist = true;
                    
                }
            }

            return exist;
        }
        public bool AgregarMedidor(String id, String tipo) {
            bool success = false;

            Medidor medidor = new Medidor() { Id = id, Tipo= tipo };
            lista.Add(medidor);

            return success; 
        }
        public List<Medidor> FiltrarXTipo(String tipo) {
            return lista.FindAll(x => x.Tipo == tipo);
        }
        public string largoListaMedidores() { 
            return lista.Count.ToString();

        }
        

    }
}
