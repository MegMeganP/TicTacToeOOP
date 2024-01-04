

namespace TicTacToeExercise
{
    class Player
    {
        public string Name { get; set; }
        public string Symbol { get; set; }

        public Player(string name)
        {
            if (name == "1")
            {
                Name = "Player 1";
                Symbol = "O";
            }
            else
            {
                Name = "Player 2";
                Symbol = "X";
            }
        }
    }
}
