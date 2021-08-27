using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    public abstract class Nigiri : Card
    {
        //####################################################################
        //# Instance Variables
        //The point of Nigiri card
        protected int _point;
        //The boolean variable to check if the Nigiri is dipped in Wasabi 
        protected bool _dipped;


        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Nigiri card object
        /// </summary>
        /// <param name="type">The type of the card</param>
        public Nigiri(string type) : base(type)
        {
            //Sets the dipped boolean variable to false
            _dipped = false;
        }

        //####################################################################
        //# Public Properties
        /// <summary>
        /// Gets & Sets the boolean variable Dipped
        /// </summary>
        public bool Dipped
        {
            get { return _dipped; }
            set { _dipped = value; }
        }

        /// <summary>
        /// Gets the card point (Read Only)
        /// </summary>
        public int cardPoint
        {
            get
            {
                //Checks if the Nigiri is dipped in Wasabi
                if (_dipped == true)
                {
                    //Increases the point of Nigiri card by 3 times
                    return _point * 3;
                }
                else //IF NOT
                {
                    //Returns the point of Nigiri card
                    return _point;
                }
            }

        }
        
    }
}
