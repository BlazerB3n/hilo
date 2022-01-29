using System;
namespace Hilo.gamehilo
{
    //to keep track of the random number between 1-13 and compare to previous loops and user's guess
    class Card
    {
        public Card()
        {
            Random rnd = new Random();
            int card = rnd.Next(1, 14);
            

        }
    }
}