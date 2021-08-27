using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Go
{
    public abstract class Maki : Card
    {
        //####################################################################
        //# Instance Variables
        //The number of Maki Roll ICONS  
        protected int _numMaki;


        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Maki object
        /// </summary>
        /// <param name="type">The type of the card</param>
        public Maki(string type) : base(type) { }


        //####################################################################
        //# Public Properties
        /// <summary>
        /// Gets & Sets the number of Maki Roll ICONS 
        /// </summary>
        public int NumMaki
        {
            get { return _numMaki; }
            set { _numMaki = value; }
        }
    }
}
