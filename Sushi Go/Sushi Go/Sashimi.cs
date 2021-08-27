using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class Sashimi : Card
    {
        public Sashimi(string type) : base(type)
        { }

        public override void DrawCard(Graphics paper, int x)
        {
            paper.DrawImage(Properties.Resources.sashimi, x, y, WIDTH, HEIGHT);
        }
    }
}
