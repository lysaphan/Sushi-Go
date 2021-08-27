using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sushi_Go
{
    //Name: Lysa Phan

    public partial class Form1 : Form
    {
        //#############################################################################################
        //# Instance variables
        //The variable to count the number of round
        int roundCount = 0;
        //The point of human
        int totalHumanPoint = 0;
        //The point of computer
        int totalCompPoint = 0;
        //The number of pudding cards that human has
        int humanPudding = 0;
        //The number of pudding cards that computer has
        int compPudding = 0;
        

        //The constant to store the points that player has the most Maki Roll will get
        const int HIGHEST_MAKIPOINT = 6;
        //The constant to store the points that player has the second most Maki Roll will get
        const int S_HIGHEST_MAKIPOINT = 3;
        //The constant to store the points that player has the most Pudding Cards will get
        const int PUDDING_POINT = 6;


        //Random number generator, used to generate cards
        Random rand = new Random();

        //A list of card
        List<Card> totalCardList = new List<Card>();

        //Creates hand object
        private Hand playerHand;
        private Hand compHand;
        private Hand aHand;
        private Board board;
        //Creates Player object
        private Player human;
        //Creates Computer object
        private Computer comp;
        

        //#############################################################################################
        //# Constructor
        public Form1()
        {
            InitializeComponent();

            playerHand = new Hand();
            compHand = new Hand();
            aHand = new Hand();
            human = new Player();
            comp = new Computer();
            board = new Board();
        }


        //#############################################################################################
        //# Event Handlers
        /// <summary>
        /// This buttons will generate the decks of card and randomly deal it for each player
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {

            //Declares graphics
            Graphics paperC = pictureBoxComputerBoard.CreateGraphics();
            Graphics paperP = pictureBoxHumanBoard.CreateGraphics();
            Graphics paperH = pictureBoxHumanHand.CreateGraphics();
            Graphics paperN = pictureBox1.CreateGraphics();

            //Creates new font
            Font drawFont = new Font("Arial", 16);
            //Creates a new brush
            Brush br = new SolidBrush(Color.WhiteSmoke);
            //Gets the size 
            int size = pictureBox1.Width / 24 - 5 ;
            //Draws the position of 10 cards in human's hand
            for (int c = 1; c <= 10; c++)
            {
                //Draws the position of the cards
                paperN.DrawString(c.ToString(), drawFont, br, size, 1);
                //Shift the x (size) position to the right
                size += pictureBox1.Width/10;
            }

            //Starts the first round
            roundCount++;

            //Adds different types of cards to the total card list
            for (int i = 1; i <= 14; i++) //Adds 14 Tempura, Sashimi and Dumpling cards
            {
                totalCardList.Add(new Tempura("Tempura"));
                totalCardList.Add(new Sashimi("Sashimi"));
                totalCardList.Add(new Dumpling("Dumpling"));
            }
            for (int i = 1; i <= 12; i++) //Adds 12 Maki2 cards
            {
                totalCardList.Add(new Maki2("Maki2"));
            }
            for (int i = 1; i <= 10; i++) //Adds 10 SalmonN and Pudding cards
            {
                totalCardList.Add(new SalmonN("SalmonN"));
                totalCardList.Add(new Pudding("Pudding"));
            }
            for (int i = 1; i <= 8; i++) //Adds 8 Maki3 cards
            {
                totalCardList.Add(new Maki3("Maki3"));
            }
            for (int i = 1; i <= 6; i++) //Adds 6 Wasabi and Maki1 cards
            {
                totalCardList.Add(new Wasabi("Wasabi"));
                totalCardList.Add(new Maki1("Maki1"));
            }
            for (int i = 1; i <= 5; i++) //Adds 5 SquidN and EggN cards
            {
                totalCardList.Add(new SquidN("SquidN"));
                totalCardList.Add(new EggN("EggN"));
            }
            for (int i = 1; i <= 4; i++) //Adds 4 Chopsticks cards
            {
                totalCardList.Add(new Chopsticks("Chopsticks"));
            }

            //Gives 10 random cards for each player
            for (int k = 1; k <= 10; k++)
            {
                //Creates a random number
                int i = rand.Next(totalCardList.Count);
                //Adds a random card to human's hand
                human.AddToHand(totalCardList[i]);
                //Removes that card from the total card list
                totalCardList.RemoveAt(i);

                //Creates another random number
                int j = rand.Next(totalCardList.Count);
                //Adds a random card to computer's hand
                comp.AddToHand(totalCardList[j]);
                //Removes that card from the total card list
                totalCardList.RemoveAt(j);
            }

            //Displays all the cards in human's hand 
            human.DisplayHand(paperH, pictureBoxHumanHand.Width);

            //Sets focus to the textbox
            textBoxChoose.Focus();
            //Displays the number of current round
            textBoxRound.Text = roundCount.ToString();
            //Displays the message said that the round is started
            MessageBox.Show("Start Round " + roundCount).ToString();
        }

        /// <summary>
        /// This will set the width and the height of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Sets the width of the form
            Width = 980;
            //Sets the height of the form
            Height = 630;
        }

        /// <summary>
        /// This button allows players to choose the card they want to play 
        /// and calculate the point for each player 
        /// and compare the final point of each player to declare the winner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Declares graphics
                Graphics paperC = pictureBoxComputerBoard.CreateGraphics();
                Graphics paperP = pictureBoxHumanBoard.CreateGraphics();
                Graphics paperH = pictureBoxHumanHand.CreateGraphics();

                //Declares the computer choice
                int computerChoice = 0;

                //Gets the card number that human chooses from the textbox
                int humanChoice = int.Parse(textBoxChoose.Text);

                //Checks IF the chosen card number is valid
                if (humanChoice > 0 && humanChoice <= human.CardInHand)
                {

                    //Loops through the list of card in computer's board
                    foreach (Card c in comp.MyBoard.CardList)
                    {
                        //Checks if there is a chopsticks card
                        if (c is Chopsticks)
                        {
                            //Creates a random card number that computer wants to swap
                            int compSwapChoice = rand.Next(1, comp.MyHand.CardList.Count + 1);

                            //Swaps the Chopsticks card width the random card
                            PlayChopsticks(paperC, comp, compSwapChoice);
                            break;
                        }
                    }

                    //Checks IF human wants to play a hard game (play with Smart Robot)
                    if (checkBoxHard.Checked)
                    {
                        //Get the computer choice
                        computerChoice = comp.ComputerChoice();
                    }
                    else //else human wants to play easy game (play with Dump Robot)
                    {
                        //Creates a random card number that computer chooses from its hand
                        computerChoice = rand.Next(1, comp.MyHand.CardList.Count + 1);
                    }


                    //Displays the card that the human chooses
                    human.PlayCard(humanChoice - 1);
                    //Displays the card that the computer chooses
                    comp.PlayCard(computerChoice);

                    //Clears the data in the textbox
                    textBoxChoose.Clear();
                    //Sets focus to the textbox
                    textBoxChoose.Focus();

                    //Swaps human's hand & computer's hand 
                    aHand = human.MyHand;
                    human.MyHand = comp.MyHand;
                    comp.MyHand = aHand;

                    //Clears all the graphics in the pictureboxHand
                    pictureBoxHumanHand.Refresh();

                    //Displays all the cards in human's hand
                    human.DisplayHand(paperH, pictureBoxHumanHand.Width);
                    //Displays all the cards in human's board
                    human.DisplayBoard(paperP, pictureBoxHumanBoard.Width);
                    //Displays all the cards in computer's board
                    comp.DisplayBoard(paperC, pictureBoxComputerBoard.Width);

                    //Checks if there is no card left in human's hand or computer's hand
                    if (human.CardInHand == 0 || comp.CardInHand == 0)
                    {
                        //Checks if it is not the end of the game
                        if (roundCount != 3)
                        {
                            //Displays the message says that the round is ended
                            MessageBox.Show("Round " + roundCount + " Completed!");

                            //Calculate the total point of each player
                            CalculateTotalPoint();

                        }
                        else //When the game is ended (Finished round 3)
                        {
                            //Displays the message says that the game is ended
                            MessageBox.Show("End Game!");

                            //Calculate the total point of each player
                            CalculateTotalPoint();

                            //Calculate the pudding point of each player
                            if (humanPudding > compPudding) //IF human has more pudding cards
                            {
                                //Human gets the pudding point
                                totalHumanPoint += PUDDING_POINT;
                            }
                            else if (humanPudding < compPudding) //IF computer has more pudding cards
                            {
                                //Computer gets the pudding point
                                totalCompPoint += PUDDING_POINT;
                            }
                            else //IF human & computer has the same card
                            {
                                //The players split the point evenly
                                totalHumanPoint += (PUDDING_POINT / 2);
                                totalCompPoint += (PUDDING_POINT / 2);
                            }

                            //(Updates) Displays the total point of the players
                            textBoxTotalHPoint.Text = totalHumanPoint.ToString();
                            textBoxTotalCPoint.Text = totalCompPoint.ToString();

                            //Compares the total point of the players & Declares the winner
                            if (totalHumanPoint > totalCompPoint)
                            {
                                MessageBox.Show("You Win!!!");
                            }
                            else if (totalHumanPoint < totalCompPoint)
                            {
                                MessageBox.Show("Computer Win!");
                            }
                            else
                            {
                                MessageBox.Show("Tie!!");
                            }
                        }
                    }
                }
                else
                {
                    //Displays an error message
                    MessageBox.Show("Please enter a number between 1 and "
                        + human.MyHand.CardList.Count.ToString());
                }
            }
            catch (Exception ex)
            {
                //Displays an error message
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// This method calculates the total point for each player
        /// </summary>
        private void CalculateTotalPoint()
        {
            //Gets the number of Pudding Cards that each player has
            humanPudding += human.GetNumPudding();
            compPudding += comp.GetNumPudding();

            //Displays the number of Pudding Cards that each player has
            textBoxHumanPudding.Text = humanPudding.ToString();
            textBoxCompPudding.Text = compPudding.ToString();

            //Calculate the Maki Point of each player
            CalcMakiPoint();

            //Calculates each player's score 
            human.CalcScore();
            comp.CalcScore();

            //Checks if it is not the first round
            if (textBoxTotalHPoint.Text != "" && textBoxTotalCPoint.Text != "")
            {
                //Gets the total point that the players have earned in previous rounds
                totalHumanPoint = int.Parse(textBoxTotalHPoint.Text);
                totalCompPoint = int.Parse(textBoxTotalCPoint.Text);

                //Calculates the total point of each player (includes the current point)
                totalHumanPoint += human.Score;
                totalCompPoint += comp.Score;

                //Displays the total point of each player (includes the current point)
                textBoxTotalHPoint.Text = totalHumanPoint.ToString();
                textBoxTotalCPoint.Text = totalCompPoint.ToString();
            }
            else //ELSE it is the first round
            {
                //Display the score of each player in the textboxes
                textBoxTotalHPoint.Text = human.Score.ToString();
                textBoxTotalCPoint.Text = comp.Score.ToString();
            }

            //Displays each player's score
            textBoxHumanPoint.Text = human.Score.ToString();
            textBoxCompScore.Text = comp.Score.ToString();
            
            //Set the maximum card in players' hand back to normal for new round
            //maxCardInHand = 10;
        }

        /// <summary>
        /// This method calculates the Maki point of each player
        /// </summary>
        private void CalcMakiPoint()
        {
            //Declares variable
            int humanMaki = 0;
            int compMaki = 0;

            //Gets the number of maki roll icons for each player 
            humanMaki = human.GetNumMaki();
            compMaki = comp.GetNumMaki();

            //Checks IF all the players have Maki Roll 
            if (humanMaki > 0 && compMaki > 0)
            {
                //Calculates the point each player get depends on who has more maki roll icons
                if (humanMaki > compMaki) //IF human has more
                {
                    //Gives the highest point to human
                    human.Score += HIGHEST_MAKIPOINT;
                    //Gives the second highest point to computer
                    comp.Score += S_HIGHEST_MAKIPOINT;
                }
                else if (humanMaki == compMaki)  //IF tie
                {
                    //Divides the highest point for each player
                    human.Score += (HIGHEST_MAKIPOINT / 2);
                    comp.Score += (HIGHEST_MAKIPOINT / 2);
                }
                else //IF computer has more
                {
                    //Gives the highest point to computer
                    comp.Score += HIGHEST_MAKIPOINT;
                    //Gives the second highest point to human
                    human.Score += S_HIGHEST_MAKIPOINT;
                }
            }
            //ELSE IF human does not have any Maki Roll 
            else if (humanMaki == 0)
            {
                //Gives the highest point to computer
                comp.Score += HIGHEST_MAKIPOINT;
            }
            //ELSE IF computer does not have any Maki Roll 
            else if (compMaki == 0)
            {
                //Gives the highest point to human
                human.Score += HIGHEST_MAKIPOINT;
            }

        }

        /// <summary>
        /// This methods will allow players to swap the Chopsticks card with another card
        /// </summary>
        /// <param name="paper">Where to draw the card</param>
        /// <param name="p">Who will use this method</param>
        /// <param name="cardSwap">The position of the card that player want to swap</param>
        private void PlayChopsticks(Graphics paper, Player p, int cardSwap)
        {
            //Loops through each card in player's board
            foreach (Card c in p.MyBoard.CardList)
            {
                //Checks IF the card is a Chopstick card
                if (c is Chopsticks)
                {
                    //Displays a message 
                    MessageBox.Show("Sushi Go!");
                    //Removes the Chopsticks card from player's board
                    p.MyBoard.CardList.Remove(c);
                    //Chooses a card to swap
                    p.PlayCard(cardSwap-1);
                    //Puts the Chopsticks card back into the hand
                    p.MyHand.CardList.Add(c);
                    //Displays all the cards in player's board
                    p.DisplayBoard(paper, pictureBoxHumanBoard.Width);
                    break;
                }
            }
        }

        /// <summary>
        /// This button allows players to the chopsticks card in their board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUseChopsticks_Click(object sender, EventArgs e)
        {
            try
            {
                //Declares graphics
                Graphics paperP = pictureBoxHumanBoard.CreateGraphics();
                Graphics paperH = pictureBoxHumanHand.CreateGraphics();

                //Loops through the list of card in player's board
                foreach (Card c in human.MyBoard.CardList)
                {
                    //Checks if there is a chopsticks card
                    if (c is Chopsticks)
                    {
                        //Gets the card number that player wants to swap 
                        int cardSwap = int.Parse(textBoxSwapChopsticks.Text);
                        //Swaps that card with the Chopsticks card
                        PlayChopsticks(paperP, human, cardSwap);
                        //Clears the textbox
                        textBoxSwapChopsticks.Clear();
                        //Displays all the cards in player's hand
                        human.DisplayHand(paperH, pictureBoxHumanHand.Width);
                    break;
                    }
                }
        }
            catch (Exception ex)
            {
                //Displays an error message
                MessageBox.Show(ex.Message);
            }
}

        /// <summary>
        /// This button starts a new round
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            //Clear some data from previous round to start new round
            Clear();

            //Starts the next round
            roundCount++;

            //Declares graphics
            Graphics paperC = pictureBoxComputerBoard.CreateGraphics();
            Graphics paperP = pictureBoxHumanBoard.CreateGraphics();
            Graphics paperH = pictureBoxHumanHand.CreateGraphics();

            //Gives 10 random cards for each player
            for (int k = 1; k <= 10; k++)
            {
                //Creates a random number
                int i = rand.Next(totalCardList.Count);
                //Adds a random card to human's hand
                human.AddToHand(totalCardList[i]);
                //Removes that card from the total card list
                totalCardList.RemoveAt(i);

                //Creates another random number
                int j = rand.Next(totalCardList.Count);
                //Adds a random card to computer's hand
                comp.AddToHand(totalCardList[j]);
                //Removes that card from the total card list
                totalCardList.RemoveAt(j);
            }

            //Displays all the cards in human's hand 
            human.DisplayHand(paperH, pictureBoxHumanHand.Width);

            //Sets focus to the textbox
            textBoxChoose.Focus();
            //Displays the number of current round
            textBoxRound.Text = roundCount.ToString();
            //Shows message said that the round is started
            MessageBox.Show("Start Round " + roundCount).ToString();
        }

        /// <summary>
        /// This methods will clear the data needed to be clear to start new round
        /// </summary>
        private void Clear()
        {
            //Clears the list of cards in each player's hand
            human.MyHand.CardList.Clear();
            comp.MyHand.CardList.Clear();

            //Clears the list of cards in each player's board
            human.MyBoard.CardList.Clear();
            comp.MyBoard.CardList.Clear();

            //Clears the image of cards in each player's board
            pictureBoxHumanBoard.Refresh();
            pictureBoxComputerBoard.Refresh();
            
            //Clears the textboxes point
            textBoxHumanPoint.Clear();
            textBoxCompScore.Clear();

            //Clears the current point of the player
            human.Score = 0;
            comp.Score = 0;
        }
        
        /// <summary>
        /// Closes the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void pictureBoxSelect_Click(object sender, EventArgs e)
        {

        }
        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {


        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            pictureBoxHumanHand.Width = Width - 35;
            // pictureBoxHumanHand.Height = Height;

            pictureBoxHumanBoard.Width = Width - 35;
            // pictureBoxHumanBoard.Height = Height;

            pictureBoxComputerBoard.Width = Width - 35;
            //pictureBoxComputerBoard.Width = Height;

            pictureBox1.Width = Width - 35;
            //label1.Location.X = Location.X;
        }
    }
}
    

