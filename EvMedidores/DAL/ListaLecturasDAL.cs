using EvMedidores.DTO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvMedidores.DAL
{
    public class ListaLecturasDAL : ILecturasDAL
    {
        private static List<Lectura> lista = new List<Lectura>();

        public void AgregarLectura(String id, DateTime fecha, String consumo)
        {
            Lectura lectura = new Lectura
            {
                Idmedidor = id,
                Fecha = fecha,
                Consumo = consumo
            };
            lista.Add(lectura);
        }
                 
        

        public List<Lectura> ObtenerLecturas()
        {
            return lista;
        }

        public List<Lectura> FiltrarXIdMedidor(string idmedidor) {

            return lista.FindAll(x => x.Idmedidor == idmedidor);
        }
        public string largoLista() {
            return lista.Count.ToString();
        }
    }
}
