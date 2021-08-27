using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class SalmonN : Nigiri
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Salmon Nigiri object
        /// </summary>
        /// <param name="type">The type of the card</param>
        public SalmonN(string type) : base(type)
        {
            //Sets the point of this card to 2
            _point = 2;
        }

        /// <summary>
        /// This method draws the image of the Salmon Nigiri card 
        /// </summary>
        /// <param name="paper">Where to draw the card</param>
        /// <param name="x">The x position of the card</param>
        public override void DrawCard(Graphics paper, int x)
        {
            //Checks if this Nigiri card is dipped in wasabi 
            if (_dipped == true)
            {
                //Draws the image of the Salmon Nigiri card dipped in Wasabi
                paper.DrawImage(Properties.Resources.wasabi_salmon, x, y, WIDTH, HEIGHT);
            }
            else //IF NOT
            {
                //Draws the image of the Salmon Nigiri card 
                paper.DrawImage(Properties.Resources.salmon, x, y, WIDTH, HEIGHT);
            }
        }
    }
}
