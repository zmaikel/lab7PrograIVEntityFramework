using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaDatos.Entidades;

namespace Lab7PrograIV
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                cargarcmbPais();
                cargarcmbIdioma();
                cargargridPrestamo();


            }
        }
        public void cargarcmbPais()
        {
            using (Class1 contextoBD = new Class1())
            {
                cmbPais.DataSource = contextoBD.Pais.ToList(); 
                cmbPais.DataBind();
            }
        }
        public void cargarcmbIdioma()
        {
            using (Class1 contextoBD = new Class1())
            {
                cmbIdioma.DataSource = contextoBD.Idioma.ToList(); 
                cmbPais.DataBind();
            }
        }
        public void cargargridPrestamo()
        {
            using (Class1 contextoBD = new Class1())
            {
                gridPrestamo.DataSource = contextoBD.Prestamo.ToList(); 
                gridPrestamo.DataBind();
            }
        }


        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            using (Class1 contextoBD = new Class1())
            {

                Prestamo aux = contextoBD.Prestamo.Where(x => x.TGP_ID == Convert.ToInt16 (gridPrestamo.ClientID) ).FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                aux.TGP_PAIS_ID = Convert.ToInt16(cmbPais.SelectedItem.Text);
                aux.TGP_HABITANTES = Convert.ToInt16(txtHabitantes.Text); ;
                aux.TGP_IDIOMA_ID = Convert.ToInt16(cmbIdioma.SelectedItem.Text);
                aux.TGP_PIB = Convert.ToInt16(txtPIB.Text);
                aux.TGP_SUPERFICIE = Convert.ToInt16(txtSUPERFICIE.Text);
                aux.TGP_RIESGO_SEGURIDAD = Convert.ToChar(radioRiesgo.SelectedItem.Text);
                aux.TGP_ABLE = checkPrestamo.Checked;
                contextoBD.SaveChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Se logro actualizar el registro')", true);
                cargargridPrestamo();

            }
        }

        protected void btnBorrar_Click(object sender, EventArgs e)
        {
            using (Class1 contextoBD = new Class1())
            {

                Prestamo aux = contextoBD.Prestamo.Where(x => x.TGP_ID == Convert.ToInt16(gridPrestamo.ClientID)).FirstOrDefault();
                if (aux == null)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('El registro no se encontro')", true);
                    return;
                }

                contextoBD.Prestamo.Remove(aux);
                contextoBD.SaveChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Se logro eliminar el registro')", true);
                cargargridPrestamo();

            }
        }

        protected void btnRegistra_Click(object sender, EventArgs e)
        {
            using (Class1 contextoBD = new Class1())
            {
                Prestamo objPrestamo = new Prestamo();
                objPrestamo.TGP_PAIS_ID = Convert.ToInt16( cmbPais.SelectedItem.Text);
                objPrestamo.TGP_HABITANTES = Convert.ToInt16(txtHabitantes.Text); ;
                objPrestamo.TGP_IDIOMA_ID = Convert.ToInt16(cmbIdioma.SelectedItem.Text);
                objPrestamo.TGP_PIB = Convert.ToInt16(txtPIB.Text);
                objPrestamo.TGP_SUPERFICIE = Convert.ToInt16(txtSUPERFICIE.Text);
                objPrestamo.TGP_RIESGO_SEGURIDAD = Convert.ToChar(radioRiesgo.SelectedItem.Text);
                objPrestamo.TGP_ABLE = checkPrestamo.Checked;
                contextoBD.Prestamo.Add(objPrestamo);
                contextoBD.SaveChanges();
                ScriptManager.RegisterStartupScript(this, this.GetType(), "s1", "alert('Se logro registrar el registro')", true);
                cargargridPrestamo();
            }
        }
    }
}