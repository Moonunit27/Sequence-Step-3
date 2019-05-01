using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SequenceGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Board gameBoard = new Board(this);  //Create the gameboard usinf gameBoard class           
        }


        //////////////Create a card////////////////////////////////////////////////////////////////////
        static int GetCard(Random rndCard)
        {
            int Card = rndCard.Next(1, 107); //Generate random number between 1 and 104                                  
            return Card;
        }

        ////////////////////////Generate List Of Random Cards//////////////////////////////////////////

        private void Button1_Click(object sender, EventArgs e)
        {

            List<Button> PC = new List<Button>{PC1, PC2, PC3, PC4, PC5, PC6, PC7};
            var PCArray = PC.ToArray();
            Console.WriteLine(PCArray.Length);



            Random CardNum = new Random();
            List<int> CardsList = new List<int>(107); //create a card list to hold the players cards

            for (int i = 0; i < 7; i++) //Get 7 random numbers 
            {
                CardsList.Add(GetCard(CardNum)); //Add the card to the list
            }

            foreach (int Card in CardsList)
            {
                if (Card == 0 || Card == 9 || Card == 90 || Card == 99)
                {
                    //Code for skipping the black spaces will go here
                }
                else
                {
                    Console.WriteLine("\t" + Card); //Display the Cards ID number that can be matched to the board  
                    PCArray[0].BackgroundImage = AllCards.Images[Card];
                    PCArray[0].BackgroundImageLayout = ImageLayout.Stretch;

                    PCArray[0] = PCArray[+1]; PCArray[1] = PCArray[+2]; PCArray[2] = PCArray[+3]; PCArray[3] = PCArray[+4]; PCArray[4] = PCArray[+5]; PCArray[5] = PCArray[+6];

                
                }






                ////////////////////////////////////PlayerCard//////////////////////////////





            }
        }
    }
}
