using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    public abstract class Card
    {
        //####################################################################
        //# Instance Variables
        //The type of the card
        protected string _type;
        //The y position to draw the card
        protected int y = 1;
        //The constants that store Width and Height of the card
        public const int WIDTH = 90;
        public const int HEIGHT = 120;
        

        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the card object
        /// </summary>
        /// <param name="type">The type of the card</param>
        public Card(string type)
        {
            _type = type;
        }


        //####################################################################
        //# Public Properties
        /// <summary>
        /// Gets & Sets the type of card
        /// </summary>
        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }


        //####################################################################
        //# Public Methods
        /// <summary>
        /// This method draws the image of the card depends on its type.
        /// </summary>
        /// <param name="paper">Where to draw the card</param>
        /// <param name="x">The x position of the card</param>
        public abstract void DrawCard(Graphics paper, int x);
    }
}
