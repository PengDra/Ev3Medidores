using EvMedidores.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ev3Medidores
{
    public partial class Default : System.Web.UI.Page
    {
        private IMedidoresDAL medidoresDAL = new ListaMedidoresDAL();
       

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<String> tipos = medidoresDAL.ObtenerListaTipo();
                this.tipoDdl.DataSource = tipos;
                
                this.tipoDdl.DataBind();
            }
        }
        protected void agregarBtn_Click(object sender, EventArgs e)
        {
            bool existe;
            string id = this.idMedidorTxt.Text.Trim();
            String tipo = this.tipoDdl.SelectedValue;
            existe = medidoresDAL.ExisteMedidor(Convert.ToInt32(id));
            if (existe == false)
            {
                medidoresDAL.AgregarMedidor(id, tipo);
                this.mensajeslbl.Text = medidoresDAL.largoListaMedidores();
                Response.Redirect("VerMedidores.aspx");
            }
            else {
                this.mensajeslbl.Text = "Medidor agregado anteriormente";
            }
        }

        protected void ValidatorID_ServerValidate(object source, ServerValidateEventArgs args)
        {
            bool existe;
            try
            {
                int id = Convert.ToInt32(args.Value);
                existe = medidoresDAL.ExisteMedidor(id);
                if (existe==false)
                {
                    args.IsValid = true;
                }
                else
                {
                    args.IsValid = false;
                    this.mensajeslbl.Text = "Medidor agregado anteriormente";
                }
            }
            catch (Exception)
            {
                args.IsValid = false;
            }
                       
        }
    }
}