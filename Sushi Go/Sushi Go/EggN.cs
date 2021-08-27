using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    class EggN : Nigiri
    {
        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Egg Nigiri object
        /// </summary>
        /// <param name="type">The type of the card</param>
        public EggN(string type) : base(type)
        {
            //Sets the point of this card to 1
            _point = 1;
        }

        /// <summary>
        /// This method draws the image of the Egg Nigiri card 
        /// </summary>
        /// <param name="paper">Where to draw the card</param>
        /// <param name="x">The x position of the card</param>
        public override void DrawCard(Graphics paper, int x)
        {
            //Checks if this Nigiri card is dipped in wasabi 
            if (_dipped == true) 
            {
                //Draws the image of the Egg Nigiri card dipped in Wasabi
                paper.DrawImage(Properties.Resources.wasabi_egg, x, y, WIDTH, HEIGHT);
            }
            else //IF NOT
            {
                //Draws the image of the Egg Nigiri card
                paper.DrawImage(Properties.Resources.egg, x, y, WIDTH, HEIGHT);
            }
        }
    }
}
