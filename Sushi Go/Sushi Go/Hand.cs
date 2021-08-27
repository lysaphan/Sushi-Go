using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sushi_Go
{
    public class Hand
    {
        //####################################################################
        //# Instance Variables
        //Creates a list of cards 
        public List<Card> _cardList;


        //####################################################################
        //# Constructor
        /// <summary>
        /// Initialise the list
        /// </summary>
        public Hand()
        {
            _cardList = new List<Card>();
        }


        //####################################################################
        //# Public Properties
        /// <summary>
        /// Gets & Sets the list of cards 
        /// </summary>
        public List<Card> CardList
        {
            get { return _cardList; }
            set { _cardList = value; }
        }


        //####################################################################
        //# Public Methods
        /// <summary>
        /// This method adds card to the list of cards
        /// </summary>
        /// <param name="c">The card added to the list of card</param>
        public void AddCard(Card c)
        {
            _cardList.Add(c);
        }

        /// <summary>
        /// This method removes the card to the list of cards
        /// </summary>
        /// <param name="c">The card removed to the list of card</param>
        public void RemoveCard(Card c)
        {
            _cardList.Remove(c);
        }

        /// <summary>
        /// This method draws the card
        /// </summary>
        /// <param name="paper">Where to draw the card</param>
        /// <param name="width">The width of the card</param>
        public void Draw(Graphics paper, int width)
        {
            //The x position to draw the card
            int x = 3;
            //Loops through each card in the card list
            for (int i = 0; i < _cardList.Count; i++)
            {
                //Draws each card at the given position in the card list
                _cardList[i].DrawCard(paper, x);
                //Shifts the x position to the right
                x += width / 10;
            }
        }
    }
}
















//public void RemoveCard(string card)
//{
//    if (card == "Tempura")
//    {
//        _cardHandList.Remove(new Tempura(card));
//    }
//    else if (card == "Sashimi")
//    {
//        _cardHandList.Add(new Sashimi(card));
//    }
//    else if (card == "Dumpling")
//    {
//        _cardHandList.Add(new Dumpling(card));
//    }
//    else if (card == "Maki1")
//    {
//        _cardHandList.Add(new Maki1(card));
//    }
//    else if (card == "Maki2")
//    {
//        _cardHandList.Add(new Maki2(card));
//    }
//    else if (card == "Maki3")
//    {
//        _cardHandList.Add(new Maki3(card));
//    }
//    else if (card == "SalmonN")
//    {
//        _cardHandList.Add(new SalmonN(card));
//    }
//    else if (card == "SquidN")
//    {
//        _cardHandList.Add(new SquidN(card));
//    }
//    else if (card == "EggN")
//    {
//        _cardHandList.Add(new EggN(card));
//    }
//    else if (card == "Pudding")
//    {
//        _cardHandList.Add(new Pudding(card));
//    }
//    else if (card == "Wasabi")
//    {
//        _cardHandList.Add(new Wasabi(card));
//    }
//    else
//    {
//        _cardHandList.Add(new Chopsticks(card));
//    }
//}


