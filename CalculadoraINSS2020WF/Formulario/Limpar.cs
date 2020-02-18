using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraINSS2020WF.Formulario
{
    class Limpar
    {
        public static void Campos(Control control)
        {
            foreach (Control txtBox in control.Controls)
            {
                //Campos TextBox
                if (txtBox is TextBox)
                {
                    ((TextBox)txtBox).Text = "0";
                }
                /*if (txtBox is MaskedTextBox)
                {
                    ((MaskedTextBox)txtBox).Text = string.Empty;
                }*/

                /*if (txtBox is RichTextBox)
                {
                    ((RichTextBox)txtBox).Text = string.Empty;
                }*/
            }
        }
    }
}
