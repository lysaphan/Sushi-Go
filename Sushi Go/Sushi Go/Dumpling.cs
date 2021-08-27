using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class Dumpling : Card
    {

        public Dumpling(string type) : base(type)
        { }

        public override void DrawCard(Graphics paper, int x)
        {
            paper.DrawImage(Properties.Resources.dumpling, x, y, WIDTH, HEIGHT);
        }
    }
}
