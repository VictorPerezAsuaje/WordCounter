using System;
using System.Linq;
using System.Text.RegularExpressions;

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
            CharLblWS.Visible = false;

            if(TxtBox.Text == String.Empty)
            {
                WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                CharLbl.Text = "Char number: " + TxtBox.Text.Length;
            }
            else
            {
                CharLblWS.Visible = true;
                TxtBox.Text = Regex.Replace(TxtBox.Text, @"\s+", " ");

                if (TxtBox.Text.Count(s => s == ' ') == TxtBox.Text.Length)
                {
                    WordsLbl.Text = "Word number: No words found";
                }
                else if (TxtBox.Text != String.Empty)
                {
                    if(TxtBox.Text[0] == ' ')
                    {
                        restaPalabras++;
                    }
                    else 
                    { 
                    }
                    if(TxtBox.Text[TxtBox.Text.Length-1] == ' ')
                    {
                        restaPalabras++;
                    }
                    else
                    {

                    }
                    numeroPalabras = TxtBox.Text.Count(s => s == ' ') + 1 - restaPalabras;
                    WordsLbl.Text = "Word number: " + numeroPalabras;
                }
                CharLbl.Text = "Char number: " + TxtBox.Text.Length;
                CharLblWS.Text = "Char number without spaces: " + (TxtBox.Text.Length - TxtBox.Text.Count(s => s == ' '));
            }
            
        }
    }
}