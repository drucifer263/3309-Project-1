using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingoGame
{
    //Player class holds name of player and displays name
    class Player
    {
        //Variable
        private string playerName;

        //Default constructor
        public Player ()
        {

        }
        
        //Constructor
        public Player (string playerName)
        {
            this.PlayerName = playerName;
        }

        //Name Property 
        public string PlayerName 
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }

        //Displays name for txtbox
        public string displayName()
        {
            return playerName;
        }
    }
}
