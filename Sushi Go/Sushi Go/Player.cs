using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Sushi_Go
{
    public class Player 
    {
        //####################################################################
        //# Instance Variables
        //Create a new Hand object
        private Hand h = new Hand();
        //Creates a new Play area object
        private Board b = new Board();
        //The score of the player
        private int _score;


        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialises the Player object
        /// </summary>
        public Player()
        {
            //Sets the score to 0 
            _score = 0;
        }


        //####################################################################
        //# Public Properties
        /// <summary>
        /// Gets & Sets the Score 
        /// </summary>
        public int Score
        {
            get { return _score; }
            set { _score = value; }
        }

        
        /// <summary>
        /// Gets & Sets the Hand object
        /// </summary>
        public Hand MyHand
        {
            get { return h; }
            set { h = value; }
        }

        /// <summary>
        /// Gets & Sets the Board object
        /// </summary>
        public Board MyBoard
        {
            get { return b; }
            set { b = value; }
        }

        /// <summary>
        /// Gets the number of card in hand
        /// </summary>
        public int CardInHand
        {
            get { return h.CardList.Count; } //Read Only
        }


        //####################################################################
        //# Public Methods
        /// <summary>
        /// This method adds card to Hand
        /// </summary>
        ///<param name="c">The card added to hand</param>
        public void AddToHand(Card c)
        {
            h.AddCard(c);
        }

        /// <summary>
        /// This method displays all the cards in Hand
        /// </summary>
        /// <param name="paper">Where to display the card</param>
        /// <param name="width">The width of the card</param>
        public void DisplayHand(Graphics paper, int width)
        {
            h.Draw(paper, width);
        }

        /// <summary>
        /// This method displays all the cards in Board
        /// </summary>
        /// <param name="paper">Where to display the card</param>
        /// <param name="width">The width of the card</param>
        public void DisplayBoard(Graphics paper, int width)
        {
            b.Draw(paper, width);
        }

        /// <summary>
        /// This method moves the chosen card from hand to board
        /// </summary>
        /// <param name="index">The position of the chosen card in the card list</param>
        public void PlayCard(int index)
        {
            //Takes the chosen card from the list of card in Hand
            Card c = h.CardList[index];

            //Checks if it is Nigiri Card
            if (c is Nigiri)
            {
                //Loops through each card in the list of card in player's Board
                foreach (Card myCard in b.CardList)
                {
                    //Checks IF there is a Wasabi Card
                    if (myCard is Wasabi)
                    {
                        //Shows that the Nigiri card is dipped in Wasabi
                        ((Nigiri)c).Dipped = true;
                        //Removes the Wasabi card from the ist of card in player's board
                        b.CardList.Remove(myCard);
                        break;
                    }
                }
            }
            //Adds the chosen card to the list of card in player's Board
            b.AddCard(c);
            //Removes the chosen card from the list of card in player's Hand
            h.CardList.Remove(c);
        }

        /// <summary>
        /// This method gets the number of maki roll ICONS that player has
        /// </summary>
        /// <returns>the number of maki roll ICONS that player has</returns>
        public int GetNumMaki()
        {
            //Declares variable
            int numMaki = 0;

            //Loops through each card in the list of card in player's Board
            foreach (Card myCard in b.CardList)
            {
                //Checks IF the card is Maki Roll Card
                if (myCard is Maki)
                {
                    //Adds up the number of maki roll ICONS that player has
                    numMaki += ((Maki)myCard).NumMaki; 
                }
            }
            //Returns the number of maki roll ICONS that player has
            return numMaki;
        }

        /// <summary>
        /// This method gets the number of Pudding Cards that player has
        /// </summary>
        /// <returns>the number of Pudding Cards that player has</returns>
        public int GetNumPudding()
        {
            //Declares variable
            int numPudding = 0;

            //Loops through each card in the list of card in player's Board
            foreach (Card myCard in b.CardList)
            {
                //Checks IF the card is Pudding Card
                if (myCard is Pudding)
                {
                    //Counts the number of Pudding Cards that player has
                    numPudding++;
                }
            }
            //Returns the number of Pudding Cards that player has
            return numPudding;
        }

        /// <summary>
        /// This method calculate the score of the player
        /// </summary>
        public void CalcScore()
        {
            //Adds all the card's score in the board
            _score += b.CalcPoint();
        }
    }
}
