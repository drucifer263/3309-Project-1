using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGame
{
    //Internal card rep
    class InternalBingoCard
    {
        //Declares rows and cols of internal bingo card and diag arrays
        private int[] internalBingoCardRow;
        
        private int[] internalBingoCardCol;
        
        private int[] internalBingoCardForDiag;
        private int[] internalBingoCardBackDiag;

        private  const int SIZE = 5;

        // Default Constructor
        public InternalBingoCard()
        {
            //Initializes rows and cols of internal bingo card and diag arrays
            internalBingoCardRow = new int[SIZE];
            

            internalBingoCardCol = new int[SIZE];
           
            //Forward and back ward diag
            internalBingoCardForDiag = new int[SIZE];
            internalBingoCardBackDiag = new int[SIZE];

            //Free Space
            internalBingoCardRow[2]++;
            internalBingoCardCol[2]++;
            internalBingoCardForDiag[2]++;
            internalBingoCardBackDiag[2]++;

        }

        //Alternate constructor
        public InternalBingoCard(int bingocardsize)
        {
            //Rep for rows
            internalBingoCardRow = new int[bingocardsize];
            
            //Rep for cols
            internalBingoCardCol = new int[bingocardsize];
          
            //Rep for forward and backward 
            internalBingoCardForDiag = new int[bingocardsize];
            internalBingoCardBackDiag = new int[bingocardsize];

            //Free Space
            internalBingoCardRow[2]++;
            internalBingoCardCol[2]++;
            internalBingoCardForDiag[2]++;
            internalBingoCardBackDiag[2]++;
        }

        //Checks to see if there is a winner and returns 0 or 1
        public bool isWinner()
        {
            bool winner = false;

            return winner;
        }

        //Checks to see if there is a winner and returns 0 or 1
        public int isWinner(int row, int col)
        {
           // int sum = 0;
            int winner = 0;
            int fordiagsum = 0,backdiagsum =0;
            string print = "";

            //Checks each row for a winner condition of 5 cells
            for(int i = 0; i<SIZE;i++)
            {
                  
                if (internalBingoCardRow[i] == 5)
                {
                    winner = 1;
                }
            }

            //Checks each row for a winner condition of 5 cells
            for (int j = 0; j < SIZE; j++)
            {
                print += internalBingoCardCol[j] +" ";
                if (internalBingoCardCol[j] == 5)
                {
                    winner = 1;
                }
            }

            //Checks forward diag for a winner condition of 5 cells
            for (int k = 0; k < SIZE; k++)
            {

                fordiagsum += internalBingoCardForDiag[k];
               
                if (fordiagsum == 5)
                {
                    winner = 1;
                }
                
            }

            //Checks  backdiag for a winner condition of 5 cells
            for (int l = 0; l < SIZE; l++)
            {

                backdiagsum += internalBingoCardBackDiag[l];
                
                if (backdiagsum == 5)
                {
                    winner = 1;
                }
                
            }

            return winner;
        }

        //Records where a number is used in the internal board rep
        public void recordCalledNumber(int row, int col)
        {

            //Records the cell for each row

            for (int i = 0; i < SIZE; i++)
            {
                if (row == i)
                {
                    internalBingoCardRow[i]++;
                }
            }

            //Records the cell for each column

            for (int j = 0; j < SIZE; j++)
            {
                if (col== j)
                {
                    internalBingoCardCol[j]++;
                }
            }

            //Records forward diagnal

            if (row == col )
            {
                //Counts the cell that is used to the corresponding column and row
                internalBingoCardForDiag[row]++;
            }

            //Records backward diagnal
            if (row == 0 && col == 4)
            {
                //Counts the cell that is used to the corresponding column and row
                internalBingoCardBackDiag[0]++;
            }

            else if(row == 1 && col == 3)
            {
                internalBingoCardBackDiag[1]++;
            }

            else if (row == 3 && col == 1)
            {
                internalBingoCardBackDiag[3]++;
            }

            else if (row == 4 && col == 0)
            {
                internalBingoCardBackDiag[4]++;
            }
        }
    }
}
