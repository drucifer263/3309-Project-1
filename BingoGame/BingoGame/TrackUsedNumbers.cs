using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BingoGame
{
    //Records the numbers being called
    class TrackUsedNumbers
    {
        //Bool array keeps track of what has been used
        private static bool[] trackedNumbers;
        private const int TRACKED_SIZE = 76;

        //Default constructor that initilizes the array, and sets it to false
        public TrackUsedNumbers ()
        {

            initilizeTrackedNumbersArray();
        }

        //Marks the cell as used
        public void markCellUsed(int index)
        {
            
            trackedNumbers[index] = true;
      
        }

        //Checks to see if the cell has been used
        public bool checkIfCellUsed(int index)
        {
            bool used = false;

                //Checks to see if number has been used
                if (trackedNumbers[index] == true)
                {
                    used = true;
                } 

           return used;
        }

        //Initilizes the array
        public static void initilizeTrackedNumbersArray()
        {
                trackedNumbers = new bool[TRACKED_SIZE];

            //Goes through the array and sets everything to false
            for (int i = 0; i < TRACKED_SIZE; i++)
            {
                trackedNumbers[i] = false;
            }
        }
    }
}
