using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparent_Form
{
    internal class Eszkozok
    {
        public string name {  get; set; }

        public Eszkozok (string sor)
        {
            string[] darabol = sor.Split (';');
            name = darabol[0];
        }
    }
}
