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
   
    public class Board
    {
        //map out the gameboard values
        public string[] GameBoard = {"a", "1", "49", "97", "89", "85", "81", "77", "73", "b", "2", "28", "32", "36",
                "40", "48", "52", "56", "69", "60", "50", "24", "37", "33", "29", "25", "21", "58", "65", "64",
                "46", "20", "45", "31", "27", "23", "17", "62", "9", "68", "38", "16", "101", "35", "59", "71", "13",
                "66", "57", "72", "34", "12", "53", "39", "63", "67", "61", "70", "55", "76", "30", "8", "54",
                "47", "51", "3", "5", "74", "103", "80", "26", "7", "102", "98", "90", "86", "82", "78", "99", "84",
                "22", "11", "15", "19", "75", "79", "83", "87", "91", "88", "c", "18", "14", "10", "6", "4", "104",
                "100", "92", "d"};

        public Board(Form1 f)
        {
            Console.WriteLine("board created"); //display board created (for testing purposes
            this.AddButtons(f);
        }
        public void AddButtons(Form1 f)
        {
            int xPos = 0;
            int yPos = 0;

            // Declare and assign number of buttons = 100
            System.Windows.Forms.Button[] btnArray = new System.Windows.Forms.Button[100];
           
            for (int i = 0; i < 100; i++)  // Create (100) Buttons: 
            {
                // Initialize one variable 
                btnArray[i] = new System.Windows.Forms.Button
                {
                    Tag = i + 1, // Tag of button 
                    Width = 40, // Width of button 
                    Height = 50 // Height of button 
                };

                //spacing the buttons for the board
                if (i == 10) { xPos = 0; yPos = 0; }
                if (i == 20) { xPos = 0; yPos = 50; }
                if (i == 30) { xPos = 0; yPos = 50; }
                if (i == 40) { xPos = 0; yPos = 100; }
                if (i == 50) { xPos = 0; yPos = 150; }
                if (i == 60) { xPos = 0; yPos = 200; }
                if (i == 70) { xPos = 0; yPos = 250; }
                if (i == 80) { xPos = 0; yPos = 300; }
                if (i == 90) { xPos = 0; yPos = 350; }
                if (i == 100) { xPos = 0; yPos = 400; }

                btnArray[i].Left = xPos;
                btnArray[i].Top = yPos;

                // Add buttons to a Panel: 
                f.Pnl1.Controls.Add(btnArray[i]); // Let panel  Pnl1 hold the Buttons 
                f.Pnl1.BackColor = Color.LightGray;

                xPos = xPos + btnArray[i].Width; // Left of next button 

               
                
                btnArray[i].BackgroundImage = f.AllCards.Images[i];
                btnArray[i].BackgroundImageLayout = ImageLayout.Stretch; //Resize the background images
                btnArray[i].FlatStyle =FlatStyle.Flat;
                
               

                btnArray[i].Click += new System.EventHandler(ClickButton); // the Event of click Button 
              

            }
        }

        // Result of (Click Button) event, get the text of button 
        public void ClickButton(Object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            
            
            btn.Enabled = false; //Does not allow buttons to be clicked twice    
            btn.FlatAppearance.BorderColor = Color.Red;
            btn.FlatAppearance.BorderSize = 3;
        }


    }
    }