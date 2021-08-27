using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class Maki2: Maki
    { 
        public Maki2(string type) : base(type)
        {
            //Sets the number of Maki Roll ICONS for this card to 2
            _numMaki = 2;
        }

        public override void DrawCard(Graphics paper, int x)
        {
            paper.DrawImage(Properties.Resources.maki2, x, y, WIDTH, HEIGHT);
        }
    }
}
