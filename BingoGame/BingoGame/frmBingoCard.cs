using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGame
{
    public partial class frmBingoCard : Form
    {
        /*
        Drew Watson
        Component
        Friedman
        Spring 18

        Bingo Project Version 3

            *Friedman gave me some extra time and tried to help me with and error/freezing of my program it still does it. 
             It never reaches the lose condition for some reason and freezes before then.
            
         */

        public frmBingoCard()
        {
            InitializeComponent();
        }

        //Constants
        private const int BINGOCARDSIZE = 5;
        private const int NUMBERSPERCOLUMN = 15;
        private const int MAXBINGONUMBER = 75;

        //Button array
        private Button[,] newButton = new Button[BINGOCARDSIZE, BINGOCARDSIZE];

        //Variables for calles numbers
        int countOfCalledNumbers;
        char nextCalledLetter;
        int nextCalledNumber;

        //Internal Bingo card rep
        private InternalBingoCard internalCardRep2DArray = new InternalBingoCard(BINGOCARDSIZE);
        private InternalBingoCard internalCardRepWO2DArray = new InternalBingoCard(BINGOCARDSIZE);
        private RandomNumberGenerator RNGObj = new RandomNumberGenerator();
        private RandomNumberGenerator RNGObj2 = new RandomNumberGenerator();

        private string bingoLetters = "BINGO";

        // Total width and height of a card cell
        int cardCellWidth = 75;
        int cardCellHeight = 75;
        int barWidth = 6;  // Width or thickness of horizontal and vertical bars
        int xcardUpperLeft = 45;
        int ycardUpperLeft = 45;
        int padding = 20;
        //Panel pnlCard = new Panel();

        // Creates the Bingo Card for Play
        private void createCard()
        {
            // Dynamically Creates 25 buttons on a Bingo Board 
            // Written by Bill Hall with Joe Jupin and FLF
            // This should be enough help for all of you to adapt this to your own needs
            // Create and  Add the buttons to the form
    
            Size size = new Size(75, 75);
            // if (gameCount > 0) size = new Size(40,40);
            Point loc = new Point(0, 0);
            int topMargin = 60;

            int x;
            int y;

            // Draw Column indexes
            y = 0;
            DrawColumnLabels();

            x = xcardUpperLeft;
            y = ycardUpperLeft;

            // Draw top line for card
            drawHorizBar(x, y, BINGOCARDSIZE);
            y = y + barWidth;

            // The board is treated like a 5x5 array
            drawVertBar(x, y);
            for (int row = 0; row < BINGOCARDSIZE; row++)
            {
                loc.Y = topMargin + row * (size.Height + padding);
                int extraLeftPadding = 50;
                for (int col = 0; col < BINGOCARDSIZE; col++)
                {
                    newButton[row, col] = new Button();
                    newButton[row, col].Location = new Point(extraLeftPadding + col * (size.Width + padding) + barWidth, loc.Y);
                    newButton[row, col].Size = size;
                    newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);

                    if (row == BINGOCARDSIZE / 2 && col == BINGOCARDSIZE / 2)
                    {
                        newButton[row, col].Font = new Font("Arial", 10, FontStyle.Bold);
                        newButton[row, col].Text = "Free \n Space";
                        newButton[row, col].BackColor = System.Drawing.Color.Orange;
                    }
                    else
                    {
                        newButton[row, col].Font = new Font("Arial", 24, FontStyle.Bold);
                        newButton[row, col].Text = RNGObj.getRandomValue(bingoLetters[col]).ToString();
                    }  // end if    
                    newButton[row, col].Enabled = true;
                    newButton[row, col].Name = "btn" + row.ToString() + col.ToString();

                    // Associates the same event handler with each of the buttons generated
                    newButton[row, col].Click += new EventHandler(Button_Click);

                    // Add button to the form
                    pnlCard.Controls.Add(newButton[row, col]);

                    // Draw vertical delimiter                 
                    x += cardCellWidth + padding;
                    if (row == 0) drawVertBar(x - 5, y);
                } // end for col
                // One row now complete

                // Draw bottom square delimiter if square complete
                x = xcardUpperLeft - 20;
                y = y + cardCellHeight + padding;
                drawHorizBar(x + 25, y - 10, BINGOCARDSIZE - 10);
            } // end for row

            // Draw column indices at bottom of card
            y += barWidth - 1;
            DrawColumnLabels();
            Globals.selectedNumbersListObj.reset();
            newButton[2, 2].Enabled = false; //disables free space
           
        } // end createBoard



        // Draws column indexes at top and bottom of card
        private void DrawColumnLabels()
        {
            Label lblColID = new Label();
            lblColID.Font = new System.Drawing.Font("Microsoft Sans Serif", (float)24.0, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            lblColID.ForeColor = System.Drawing.Color.Orange;
            lblColID.Location = new System.Drawing.Point(cardCellWidth, 0);
            lblColID.Name = "lblColIDBINGO";
            lblColID.Size = new System.Drawing.Size(488, 32);
            lblColID.TabIndex = 0;
            lblColID.Text = "B       I        N       G       O";
            pnlCard.Controls.Add(lblColID);
            lblColID.Visible = true;
            lblColID.CreateControl();
            lblColID.Show();
        } // end drawColumnLabels



        // Draw the dark horizontal bar
        private void drawHorizBar(int x, int y, int cardSize)
        {
            int currentx;
            currentx = x;

            Label lblHorizBar = new Label();
            lblHorizBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblHorizBar.Location = new System.Drawing.Point(currentx, y);
            lblHorizBar.Name = "lblHorizBar";
            lblHorizBar.Size = new System.Drawing.Size((cardCellWidth + padding - 1) * BINGOCARDSIZE, barWidth);
            lblHorizBar.TabIndex = 20;
            pnlCard.Controls.Add(lblHorizBar);
            lblHorizBar.Visible = true;
            lblHorizBar.CreateControl();
            lblHorizBar.Show();
            currentx = currentx + cardCellWidth;
        } // end drawHorizBar



        // Draw dark vertical bar
        private void drawVertBar(int x, int y)
        {
            Label lblVertBar = new Label();
            lblVertBar.BackColor = System.Drawing.SystemColors.ControlText;
            lblVertBar.Location = new System.Drawing.Point(x, y);
            lblVertBar.Name = "lblVertBar" + x.ToString();
            lblVertBar.Size = new System.Drawing.Size(barWidth, (cardCellHeight + padding - 1) * BINGOCARDSIZE);
            lblVertBar.TabIndex = 19;
            pnlCard.Controls.Add(lblVertBar);
            lblVertBar.Visible = true;
            lblVertBar.CreateControl();
            lblVertBar.Show();
        }  // end drawVertBar

        //Converts the char to an Int
        private int convertCharToInt(int c)
        {
            int number = 0;

            number = ((int)(c) - (int)('0'));

            return number;
        }

        //Plays the game
        private void playTheGame()
        {
            //Instructions
            string instructions = "This is the game of Bingo!! One number is called at a time. \n\n"+ 
                                  "Check the number that is called, and if it is  found click on the cell.\n\n" +
                                  "The number will be called to your right. If you get five in a row then it is BINGO!!";
                                 
            //Catchs any errors or exception
            try
            {   //Tests that the txtbox is valid
                if (validateName(txtEnterName))
                {
                    //Creates the bingo card, 
                    createCard();

                    //Clears and initilizes tracked numbers array, 
                    TrackUsedNumbers.initilizeTrackedNumbersArray();

                    //Creates the player and displays their name, 
                    Player playerOne = new Player(txtEnterName.Text);

                    lblDsiplayName.Text = playerOne.displayName();

                    //Disables other controls
                    txtEnterName.Visible = false;
                    lblEnterName.Visible = false;
                    btnOK.Visible = false;
                    btnNextNumber.Enabled = true;
                    txtNextNumber.Enabled = true;

                    //Displays instructions
                    lblInstructions.Text = instructions;

                    //Calls next number
                    callNumber();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + "Please try again." + "\n\n" + "Type of error encountered: " + ex.GetType().ToString(), "Error: Exception found.");
            }

        }

        // This is the handler for all Bingo Card Buttons
        // It uses sender argument to determine which Bingo Card button was selected
        // The argument is of type object and must be converted to type button in
        //    order to change its properties
        private void Button_Click(object sender, EventArgs e)
        {
            int bingoCount2D;
            int bingoCountWO2D;
            int selectedNumber;  // number randomly selected

            int rowID = convertCharToInt(((Button)sender).Name[3]); 
            int colID = convertCharToInt(((Button)sender).Name[4]);
            //MessageBox.Show("Cell[" + rowID + "," + colID + "] has been selected!");
            int cellID = rowID * 3 + colID;

            // Double check that clicked on button value matches called value
            selectedNumber = Convert.ToInt32(newButton[rowID, colID].Text);

            // if the call number matches the cell that you click, it will change to orange
            if (selectedNumber == nextCalledNumber)
            {
                newButton[rowID, colID].BackColor = System.Drawing.Color.Orange;
                internalCardRep2DArray.recordCalledNumber(rowID, colID);
                internalCardRepWO2DArray.recordCalledNumber(rowID, colID);
                Globals.selectedNumbersListObj.setUsedNumber(selectedNumber);

                // Check for winner
                // Go here if player found the number called in his or her card
                // Check for winner for either internal representation
                bingoCount2D = internalCardRep2DArray.isWinner(rowID, colID);
                bingoCountWO2D = internalCardRepWO2DArray.isWinner(rowID, colID);

                if ((bingoCount2D > 0) && (bingoCountWO2D > 0))
                {
                    MessageBox.Show("You are a Winner!!", "Winner Found! \n"
                        + "Bingos count = " + (bingoCount2D + bingoCountWO2D) / 2 + ". Game over!");
                    Close();
                }  // end inner if

                //Erroneuos code copied accidentally????
                //playTheGame(); 
            }

            else
            {
                MessageBox.Show("Called number does not match the one in the box you selected."
                          + "Try again!", "Numbers Do Not Match");
            } // end outer if

            //Checks for lose condition
            if (countOfCalledNumbers < MAXBINGONUMBER)
            {
            
                callNumber();
            }

            else if(countOfCalledNumbers == MAXBINGONUMBER)//Tried changing the lose condition but to no avail
            {
                MessageBox.Show("All Bingo Numbers have been called. \n You must have missed one or more. \n Game Over");
                Close();
            }

        } // end button clickhandler 

        //Click event for the start of the game
        private void btnOK_Click(object sender, EventArgs e)
        {
            playTheGame();
            
        }

        //Exits the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Calls the next number
        private void btnNextNumber_Click(object sender, EventArgs e)
        {
            callNumber();
        }

        //Creates a random letter number combo 
        private void callNumber()
        {
            string nextNumber = "";


            
            nextCalledNumber = RNGObj/*2*/.getNextUniqueRandomValue(1,MAXBINGONUMBER);
            nextCalledLetter = bingoLetters[(nextCalledNumber - 1)/NUMBERSPERCOLUMN];
           
            nextNumber =  nextCalledLetter +" "+ nextCalledNumber.ToString();
            txtNextNumber.Text = nextNumber;
            countOfCalledNumbers++;
            
        }

        //Validates the name txtbox
        private bool validateName(TextBox txtbox)
        {
            bool validName = false;
            string name = "";

            name = txtbox.Text;

            //Checks to see if name txtbox is empty
            if(name == "")
            {
                //Displays a message and sets validname to false
                MessageBox.Show("Name is a manditory field, Please try again.", "Entry Error!");
                validName = false;
                txtEnterName.Focus();
            }

            else
            {
                validName = true;
            }
            
            //Returns validname
            return validName;
        }

        //Disables next button when form loads
        private void frmBingoCard_Load(object sender, EventArgs e)
        {
            btnNextNumber.Enabled = false;
            txtNextNumber.Enabled = false;
        }
    }
}
