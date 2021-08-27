using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class Maki3 : Maki
    {
        public Maki3(string type) : base(type)
        {
            //Sets the number of Maki Roll ICONS for this card to 3
            _numMaki = 3;
        }

        public override void DrawCard(Graphics paper, int x)
        {
            paper.DrawImage(Properties.Resources.maki3, x, y, WIDTH, HEIGHT);
        }
    }
}
