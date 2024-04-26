using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestovaniHry
{
    internal class HerniPostava
    {
        protected string jmeno;
        protected int level = 1;
        protected double PosX = 0;
        protected double PosY = 0;
        public HerniPostava(string jmeno)
        {
            Jmeno = jmeno;
        }

        public string Jmeno
        {
            get
            {
                return jmeno;
            }
            set
            {
                if (value.Length > 10)
                {
                    MessageBox.Show("Jmeno je delsi jak 10 znaku");
                }
                else jmeno = value;
            }
        }

        public void ZmenaPozice(double novaPosX, double novaPosY)
        {
            PosX = novaPosX;
            PosY = novaPosY;
        }
        public override string ToString()
        {
            return
                "Jmeno: " + jmeno +
                "Level: " + level +
                "PosX: " + PosX +
                "PosY: " + PosY;
        }

    }
}
