using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sushi_Go
{
    public class Computer : Player
    {
        //#############################################################################################
        //# Instance variables
        //The maximum number of card in hand
        int maxCardInHand = 0;
        //Random number generator
        Random rand = new Random();

        //#############################################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Computer object
        /// </summary>
        public Computer() { }

        //#############################################################################################
        //# Public Methods
        /// <summary>
        /// This method will get the position of the card Computer wants to choose
        /// </summary>
        /// <returns>The position of the card Computer wants to choose</returns>
        public int ComputerChoice()
        {
            //Declares variable
            int compChoice = 0;
            //Sets the maximum card in computer's hand
            maxCardInHand = MyHand.CardList.Count;

            //Loops through each card in the card list in the computer's hand
            for (int i = 0; i < MyHand.CardList.Count; i++)
            {
                //Checks IF there is a Dumpling card in the computer's Hand
                if (MyHand.CardList[i] is Dumpling)
                {
                    //Gets the position of the Dumpling card
                    compChoice = i;
                    break;
                }
                //ELSE IF there is a Pudding card in the computer's Hand
                else if (MyHand.CardList[i] is Pudding)
                {
                    //Gets the position of the Pudding card
                    compChoice = i;
                    break;
                }
                //ELSE IF there is a Maki3 card in the computer's Hand
                else if (MyHand.CardList[i] is Maki3)
                {
                    //Gets the position of the Maki3 card
                    compChoice = i;
                    break;
                }
                else //if not
                {
                    //Creates a random card number that computer chooses
                    compChoice = rand.Next(0, maxCardInHand);
                }
            }
            //Reduces the maximum number of card in computer's hand
            maxCardInHand--;

            //Returns the position of the card computer wants to choose
            return compChoice;
        }
    }
}
