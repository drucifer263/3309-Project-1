using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    class SelectedNumbersListType
    {
        TrackUsedNumbers numbersTracked;

        //Default constructor
        public SelectedNumbersListType()
        {

        ///Initializes tracked numbers obj
        numbersTracked = new TrackUsedNumbers();
        //numbersTracked.initilizeTrackedNumbersArray();

        }

        //Checks to see if number has been used and returns true or false
        public bool isNumberUsed( int rn)
        {
            bool numberUsed = false;
            
            //Checks to see if the number has been used within tracked number
            if(numbersTracked.checkIfCellUsed(rn))
            {
                numberUsed = true;
            }

            return numberUsed;
        }

        //Sets the number as used within tracked number
        public void setUsedNumber(int rn)
        {
           
            numbersTracked.markCellUsed(rn);
        }

        //Resets tracked numbers
        public void reset()
        {
            TrackUsedNumbers numbersTracked = new TrackUsedNumbers();
            //numbersTracked.initilizeTrackedNumbersArray();
        }
    }
}
