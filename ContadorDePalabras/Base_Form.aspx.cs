using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ContadorDePalabras
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            int numeroPalabras = 0, restaPalabras = 0;
            char[] buscadorEspacios = new char[50000];
            CharLblWS.Visible = false;

            if(TxtBox.Text == String.Empty)
            {
                WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                CharLbl.Text = "Char number: " + TxtBox.Text.ToCharArray().Length;
            }
            else
            {
                buscadorEspacios = TxtBox.Text.ToCharArray();
                CharLblWS.Visible = true;
                for (int i = 1; i < TxtBox.Text.ToCharArray().Length; i++)
                {
                    if (i == 1 && buscadorEspacios[0] == ' ')
                    {
                        restaPalabras++;
                    }
                    else if (buscadorEspacios[i] == ' ' && buscadorEspacios[i - 1] == ' ')
                    {
                        restaPalabras++;
                    }
                    else
                    {
                        continue;
                    }
                }
                numeroPalabras = TxtBox.Text.ToCharArray().Count(s => s == ' ') + 1 - restaPalabras;
                WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                CharLbl.Text = "Char number: " + TxtBox.Text.ToCharArray().Length;
                CharLblWS.Text = "Char number without spaces: " + (TxtBox.Text.ToCharArray().Length - TxtBox.Text.ToCharArray().Count(s => s == ' '));
            }
            
        }
    }
}