using EvMedidores.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ev3Medidores
{
    public partial class AgregarLecturas : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new ListaMedidoresDAL();
        private ILecturasDAL lecturasDAL = new ListaLecturasDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                calendarTxt.Text = DateTime.Today.ToShortDateString() ;
                List<Medidor> medidores = medidoresDAL.ObtenerListaMedidores();
                this.medidoresDdl.DataSource = medidores;
                this.medidoresDdl.DataTextField = "Id";
                this.medidoresDdl.DataBind();

            }
        }

        protected void calendar_SelectionChanged(object sender, EventArgs e)
        {
           calendarTxt.Text = calendar.SelectedDate.ToShortDateString();
        }

        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            bool isString;
            string idmedidor = medidoresDdl.SelectedValue;
            string fecha = calendarTxt.Text;
            string hora = horaTxt.Text.Trim();
            string minutos = minutosTxt.Text.Trim();
            string consumo = consumoTxt.Text.Trim();

            if (idmedidor==null||hora==null||minutos==null||consumo==null) {
                return;
            }
            isString = int.TryParse(hora, out int horaInt);
            isString = int.TryParse(minutos, out int minutosInt);
            if (horaInt < 0 || horaInt > 23 || minutosInt < 0 || minutosInt > 59)
            {
                return;
            }
            //crea un objeto DateTime con las variables: fecha,hora,minutos, o usa el calendario
            DateTime fechaHora = DateTime.Parse(fecha + " " + hora + ":" + minutos);
            //crea un objeto lectura con todas las variables acumuladas
            lecturasDAL.AgregarLectura(idmedidor, fechaHora, consumo);
            this.mensajeslbl.Text = lecturasDAL.largoLista();


        }
    }
}