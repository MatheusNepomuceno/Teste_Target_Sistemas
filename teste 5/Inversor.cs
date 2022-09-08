using System;
using System.Collections.Generic;
using System.Text;

namespace teste_5
{
    class Inversor
    {
        public static string Reverse(string texto)
        {
            char[] caracterArray = texto.ToCharArray();
            string invertida = string.Empty;

            for (int i = caracterArray.Length - 1; i>=0; i--)
            {
                invertida += caracterArray[i];
            }

            return invertida;
        }
    }
}
