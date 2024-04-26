using System;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace TestovaniHry
{
    internal class Hrac : HerniPostava
    {
        protected string specializace;
        protected string oblicej;
        protected string vlasy;
        protected string barvaVlasu;
        public int XP { get; private set; }

        public Hrac(string jmeno, string specializace, string oblicej, string vlasy, string barvaVlasu) : base(jmeno)
        {
            this.specializace = specializace;
            this.oblicej = oblicej;
            this.vlasy = vlasy;
            this.barvaVlasu = barvaVlasu;
        }

        public void PridejXP(int xp)
        {
            XP += xp;
            int xpNeededForLevelUp = 100 * level;
            if (XP >= xpNeededForLevelUp)
            {
                level++;
                MessageBox.Show("Level UP!");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSpecializace: {specializace}\nOblicej: {oblicej}\nVlasy: {vlasy}\nBarva vlasu: {barvaVlasu}\nXP: {XP}";
        }
    }
}
