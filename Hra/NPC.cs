using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestovaniHry
{
    internal class NPC : HerniPostava
    {
        public string Prace { get; private set; }
        public bool Boss { get; private set; }

        public NPC(string jmeno, string prace, bool boss = false) : base(jmeno)
        {
            Prace = prace;
            Boss = boss;
        }

      
        public NPC(string jmeno, string prace) : base(jmeno)
        {
            Prace = prace;
            Boss = false; 
        }

     
        public new void ZmenaPozice(double novaPosX, double novaPosY)
        {
            MessageBox.Show("Nelze měnit pozici NPC.");
        }

        
        public override string ToString()
        {
            return base.ToString() + $"\nPráce: {Prace}\nBOSS: {(Boss ? "ANO" : "NE")}";
        }

    }
}
