using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocios;
namespace UI.web_.Reportes
{
    public partial class Calificar_alumnos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblinformar.Visible = false;
        }


        public int k;
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            txtnota.Text = GridView1.SelectedRow.Cells[5].Text;
           
           k  = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string op = DropDownList2.SelectedValue.ToString();
                switch (op)
                {
                    case "Aprobado":


                        if (txtnota.Text != "" && Convert.ToInt32(txtnota.Text) <= 10 && Convert.ToInt32(txtnota.Text) >= 6 && Regex.IsMatch(txtnota.Text, "[0-9]") == true)
                        {
                            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
                            //metodo para tarer el idinscripcion
                            int ka = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));

                            int idinscrip = ia.buscarid_inscripcion(ka, Convert.ToInt32(DropDownList1.SelectedValue));
                            ia.modificar(ka.ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, txtnota.Text, idinscrip.ToString());


                            lblinformar.Text = "registrado!";

                            lblinformar.Visible = true;
                            GridView1.DataBind();
                        }
                        else
                        {
                            lblinformar.Text = "La nota tiene que ser menor igual a 10 y mayor que 6 ";
                            lblinformar.Visible = true;
                        }



                        break;

                    case "Libre":

                        if (txtnota.Text != "" && Convert.ToInt32(txtnota.Text) <= 0 && Convert.ToInt32(txtnota.Text) < 6
                            && Regex.IsMatch(txtnota.Text, "[0-9]")==true )
                        {
                            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
                            //metodo para tarer el idinscripcion
                            int ka = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));

                            int idinscrip = ia.buscarid_inscripcion(ka, Convert.ToInt32(DropDownList1.SelectedValue));
                            ia.modificar(ka.ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, txtnota.Text, idinscrip.ToString());


                            lblinformar.Text = "registrado!";

                            lblinformar.Visible = true;
                            GridView1.DataBind();
                        }
                        else
                        {
                            lblinformar.Text = "La nota tiene que ser menor a 6 y mayor que 0 ";
                            lblinformar.Visible = true;
                        }break;




                    case "Aprobacion directa":

                        if (txtnota.Text != "" && Convert.ToInt32(txtnota.Text) <= 10 && Convert.ToInt32(txtnota.Text) > 7 && Regex.IsMatch(txtnota.Text, "[0-9]") == true)
                        {
                            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
                            //metodo para tarer el idinscripcion
                            int ka = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));

                            int idinscrip = ia.buscarid_inscripcion(ka, Convert.ToInt32(DropDownList1.SelectedValue));
                            ia.modificar(ka.ToString(), DropDownList1.SelectedValue, DropDownList2.SelectedValue, txtnota.Text, idinscrip.ToString());


                            lblinformar.Text = "registrado!";

                            lblinformar.Visible = true;
                            GridView1.DataBind();
                        }
                        else
                        {
                            lblinformar.Text = "La nota tiene que ser menor a 10 y mayor que 7 ";
                            lblinformar.Visible = true;
                        }


                        break;
                }
                
               
            }
            catch (Exception ex)
            {
                lblinformar.Text = "ha ocurrido un error , verifique la entrada  e intente de nuevo" ;
                lblinformar.Visible = true;
            }
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            _Inscripciones_Alumnos ia = new _Inscripciones_Alumnos();
            txtnota.Text = GridView1.SelectedRow.Cells[5].Text;
            k = ia.buscarPerosnaParaCalificar(Convert.ToInt32(GridView1.SelectedRow.Cells[2].Text));
        }
    }
}