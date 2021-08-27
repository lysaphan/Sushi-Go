using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Go
{
    public class Board : Hand
    {
        //#############################################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Board object
        /// </summary>
        public Board() : base() { }


        //#############################################################################################
        //# Public Methods
        /// <summary>
        /// This methods calculate the point of all Nigiri cards
        /// </summary>
        /// <returns>The point of all Nigiri cards</returns>
        public int CalcPoint()
        {
            //Declares variables
            int pointN = 0; int pointD = 0;
            int pointT = 0; int pointS = 0;
            int countD = 0; int countT = 0;
            int countS = 0; int totalPoint = 0;

            //Loops through in card in the card list 
            foreach (Card c in _cardList)
            {
                //Checks IF the card is Nigiri card
                if (c is Nigiri)
                {
                    //Sets the Nigiri card
                    Nigiri n = (Nigiri)c;
                    //Adds up all the point of Nigiri card
                    pointN += n.cardPoint;
                }
                else if (c is Dumpling) //ELSE IF the card is Dumpling card
                {
                    //Counts the number of Dumpling cards
                    countD++;
                    //Calculates the point for Dumpling cards
                    pointD += countD;
                }
                else if (c is Tempura) //ELSE IF the card is Tempura card
                {
                    //Counts the number of Tempura cards
                    countT++;
                    //Calculates the point of Tempura cards
                    pointT = (countT / 2) * 5;
                }
                else if (c is Sashimi) //ELSE IF the card is Sashimi card
                {
                    //Counts the number of Sashimi card
                    countS++;
                    //Calculates the point of Sashimi cards
                    pointS = (countS / 3) * 10;
                }
                //Adds up the total point
                totalPoint = pointS + pointT + pointD + pointN;
            }

            //Returns the point of all cards
            return totalPoint;
        }
    }
}
