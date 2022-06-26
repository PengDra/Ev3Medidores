using EvMedidores.DAL;
using EvMedidores.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ev3Medidores
{
    public partial class VerLecturas : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new ListaMedidoresDAL();
        private ILecturasDAL lecturasDAL = new ListaLecturasDAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                List<Medidor> medidores = medidoresDAL.ObtenerListaMedidores();
                this.medidoresDdl.DataSource = medidores;
                this.medidoresDdl.DataTextField = "Id";
                this.medidoresDdl.DataBind();
                cargarGrilla();

            }
        }
        private void cargarGrilla() {
            List<Lectura> lecturas = lecturasDAL.ObtenerLecturas();
            this.grillaLecturas.DataSource = lecturas;
            this.grillaLecturas.DataBind();
        }
        private void cargarGrillaXidMedidor(List<Lectura> filtrada)
        {
            this.grillaLecturas.DataSource = filtrada;
            this.grillaLecturas.DataBind();
        }
        

        protected void medidoresDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.medidoresDdl.SelectedItem!=null) {
                string idmedidor = this.medidoresDdl.SelectedItem.Value;
                List<Lectura> filtrada = lecturasDAL.FiltrarXIdMedidor(idmedidor);
                cargarGrillaXidMedidor(filtrada);
            }
        }

        protected void restartBtn_Click(object sender, EventArgs e)
        {
            cargarGrilla();
        }

        protected void Filtrar_Click(object sender, EventArgs e)
        {
            if (this.medidoresDdl.SelectedItem != null)
            {
                string idmedidor = this.medidoresDdl.SelectedItem.Value;
                List<Lectura> filtrada = lecturasDAL.FiltrarXIdMedidor(idmedidor);
                cargarGrillaXidMedidor(filtrada);
            }
        }
    }
}