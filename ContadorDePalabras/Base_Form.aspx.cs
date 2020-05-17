using System;
using System.Linq;

namespace ContadorDePalabras
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            int numeroPalabras = 0;
            CharLblWS.Visible = false;

            if(TxtBox.Text == String.Empty)
            {
                WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                CharLbl.Text = "Char number: " + TxtBox.Text.Length;
            }
            else
            {
                CharLblWS.Visible = true;
                bool hayTexto = false;

                for (int i = 1; i < TxtBox.Text.Length - 1; i++)
                {
                    if (i == 1 && TxtBox.Text[0] == ' ')
                    {
                        continue;
                    }
                    else if (TxtBox.Text[i] == ' ' && TxtBox.Text[i - 1] != ' ' && TxtBox.Text[i + 1] != ' ')
                    {
                        numeroPalabras++;
                        hayTexto = true;
                    }
                    else if (i == (TxtBox.Text.Length - 1) && TxtBox.Text[TxtBox.Text.Length] == ' ')
                    {
                        continue;
                    }
                    else if (TxtBox.Text[i] == ' ' && TxtBox.Text[i - 1] == ' ')
                    {
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
                if (hayTexto == true)
                {
                    numeroPalabras++;
                    WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                }
                else if(hayTexto == false && TxtBox.Text != " " && TxtBox.Text != String.Empty)
                {
                    numeroPalabras++;
                    WordsLbl.Text = "Word number: " + numeroPalabras.ToString();
                }
                else
                {
                    WordsLbl.Text = "Word number: No words found.";
                }
                CharLbl.Text = "Char number: " + TxtBox.Text.Length;
                CharLblWS.Text = "Char number without spaces: " + (TxtBox.Text.Length - TxtBox.Text.Count(s => s == ' '));
            }
            
        }
    }
}