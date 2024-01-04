

namespace TicTacToeExercise
{
    class Game
    {
        public Player player1 = new Player("1");
        public Player player2 = new Player("2");
        public Board board = new Board();

        public void Start()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Player 1 is O, Player 2 is X");
            board.DrawBoard();
            Console.WriteLine("Press any key to begin");
            Console.ReadKey();

        }

        public void Play()
        {
            Console.Clear();
            board.DrawBoard();
            Player player = player2;
            bool playGame = true;
            while (playGame)
            {
                player = SwitchPlayer(player);
                TakeTurn(player);
                Console.Clear();
                board.DrawBoard();
                playGame = CheckWin(player);
               
               
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }

        private Board TakeTurn(Player player)
        {
            bool turn = true;
            while (true)
            {
                if (player == player1)
                {
                    Console.WriteLine("Player 1, choose your field!");
                }
                else
                {
                    Console.WriteLine("Player 2, choose your field!");
                }

                string inputField = Console.ReadLine();
                int fieldChoice = int.TryParse(inputField, out fieldChoice) ? fieldChoice : 0;
                
                if (fieldChoice == 0 || fieldChoice > board.matrix.Length)
                {
                    Console.WriteLine("Field choice must be a number between 1 and 9.  Please try again");
                }
                else
                {
                    switch (fieldChoice)
                    {
                        case 1:
                            if (board.matrix[0, 0] != "1")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[0, 0] = player.Symbol;
                                break;
                            }
                            
                        case 2:
                            if (board.matrix[0, 1] != "2")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[0, 1] = player.Symbol;
                                break;
                            }
                            
                        case 3:
                            if (board.matrix[0, 2] != "3")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[0, 2] = player.Symbol;
                                break;
                            }
                            
                        case 4:
                            if (board.matrix[1, 0] != "4")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[1, 0] = player.Symbol;
                                break;
                            }
                            
                        case 5:
                            if (board.matrix[1, 1] != "5")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[1, 1] = player.Symbol;
                                break;
                            }

                        case 6:
                            if (board.matrix[1, 2] != "6")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[1, 2] = player.Symbol;
                                break;
                            }
                            
                        case 7:
                            if (board.matrix[2, 0] != "7")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[2, 0] = player.Symbol;
                                break;
                            }
                            
                        case 8:
                            if (board.matrix[2, 1] != "8")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[2, 1] = player.Symbol;
                                break;
                            }
                            
                        case 9:
                            if (board.matrix[2, 2] != "9")
                            {
                                Console.WriteLine("Field already taken.  Please try again");
                                turn = true;
                                continue;
                            }
                            else
                            {
                                board.matrix[2, 1] = player.Symbol;
                                break;
                            }
                    }
                    turn = false;
                    return board;
                }
            

                
            }
            
        }

        private Player SwitchPlayer(Player player)
        {
            if (player == player1)
            {
                player = player2;
                return player;
            }
            else
            {
                player = player1;
                return player;
            }

        }

        private bool CheckWin(Player player)
        {
            string symbol = player.Symbol;
            if ( (board.matrix[0, 0] == symbol && board.matrix[0, 1] == symbol &&board.matrix[0, 2] == symbol) ||
                    (board.matrix[1, 0] == symbol && board.matrix[1, 1] == symbol && board.matrix[1, 2] == symbol) || 
                    (board.matrix[2, 0] == symbol && board.matrix[2, 1] == symbol && board.matrix[2, 2] == symbol) || 
                    (board.matrix[0, 0] == symbol && board.matrix[1, 0] == symbol && board.matrix[2, 0] == symbol) || 
                    (board.matrix[0, 1] == symbol && board.matrix[1, 1] == symbol && board.matrix[2, 1] == symbol) || 
                    (board.matrix[0, 2] == symbol && board.matrix[1, 2] == symbol && board.matrix[2, 2] == symbol) || 
                    (board.matrix[0, 0] == symbol && board.matrix[1, 1] == symbol && board.matrix[2, 2] == symbol) || 
                    (board.matrix[0, 2] == symbol && board.matrix[1, 1] == symbol && board.matrix[2, 0] == symbol) )
            {
                
                if (player == player1)
                {
                    Console.WriteLine("Player 1 wins!");
                }
                else
                {
                    Console.WriteLine("Player 2 wins!");
                }
                return false;

            }
            else if (board.matrix[0, 0] != "1" && 
                    board.matrix[0, 1] != "2" && 
                    board.matrix[0, 2] != "3" &&
                    board.matrix[1, 0] != "4" && 
                    board.matrix[1, 1] != "5" &&
                    board.matrix[1, 2] != "6" &&
                    board.matrix[2, 0] != "7" && 
                    board.matrix[2, 1] != "8" && 
                    board.matrix[2, 2] != "9")
            {
                Console.WriteLine("It's a draw!");
                return false;
            }   
            else
            {
                return true;
            }
            
        }

    }
}

