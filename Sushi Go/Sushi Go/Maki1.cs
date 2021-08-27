using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class Maki1: Maki
    {
        public Maki1(string type) : base(type)
        {
            //Sets the number of Maki Roll ICONS for this card to 1
            _numMaki = 1;
        }

        public override void DrawCard(Graphics paper, int x)
        {
            paper.DrawImage(Properties.Resources.maki1, x, y, WIDTH, HEIGHT);
        }
    }
}
