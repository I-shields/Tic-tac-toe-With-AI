using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMiniMax
{
    internal class MiniMax
    {
        //struct that stores the score of a game board and the row and column of the
        //piece that results in that score
        public struct info
        {
            public int row;
            public int col;
            public int score;
        }

        public MiniMax() 
        {

        }

        public int[] GetMove(Board b)
        {
            //initiate minimax, and set required values
            int[] move = new int[2];
            info ifo = new info();
            int aplha = int.MinValue;
            int beta = int.MaxValue;
            ifo = miniMax(b.getBoard(), true, aplha, beta);

            if (ifo.row == -1 || ifo.col == -1)
            {
                move[0] = 0;
                move[1] = 2;
            }
            else
            {
                move[0] = ifo.row;
                move[1] = ifo.col;
            }

            return move;
        }

        private Cell[,] makeNewBoard(Cell[,] b)
        {
            //make a new board by copying all the cells from
            //the 2D array (of type Cell) passed to the function
            Cell[,] gameBoard = new Cell[3, 3];

            foreach (Cell cell in b)
            {
                Cell c = new Cell();
                c.setCol(cell.getCol());
                c.setRow(cell.getRow());
                c.setPlayer(cell.getPlayer());
                gameBoard[cell.getRow(), cell.getCol()] = c;
            }
            return gameBoard;
        }

        public bool checkWin(int p, Cell[,] cells)
        {
            //check for wins
            bool win = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (cells[j, i].getPlayer() == p)
                    {
                        if (i + 2 < 3 && j + 2 < 3 && cells[j + 1, i + 1].getPlayer() == p
                            && cells[j + 2, i + 2].getPlayer() == p)
                        {
                            win = true;
                        }
                        else if (i + 2 < 3 && j - 2 > -1 && cells[j - 1, i + 1].getPlayer() == p
                            && cells[j - 2, i + 2].getPlayer() == p)
                        {
                            win = true;
                        }
                        else if (i + 2 < 3 && cells[j, i + 1].getPlayer() == p
                            && cells[j, i + 2].getPlayer() == p)
                        {
                            win = true;
                        }
                        else if (j + 2 < 3 && cells[j + 1, i].getPlayer() == p
                            && cells[j + 2, i].getPlayer() == p)
                        {
                            win = true;
                        }
                    }
                }
            }

            return win;
        }

        public bool isEnd(Cell[,] b)
        {
            //this function checks if the board is full or not
            bool allDone = true;

            foreach (Cell cell in b)
            {
                if(cell.getPlayer() == 0)
                {
                    allDone = false;
                }
            }
            return allDone;
        }

        private info miniMax(Cell[,] gb, bool MaxPlayer, int alpha, int beta)
        {

            if(isEnd(gb) || checkWin(1, gb) || checkWin(2, gb))
            {
                if (checkWin(1, gb)) //if player wins, return minValue + 1
                {
                    info ifo = new info();
                    ifo.row = 0;
                    ifo.col = 0;
                    ifo.score = int.MinValue + 1;
                    return ifo;
                }
                else if (checkWin(2, gb)) //if AI wins, return maxValue - 1
                {
                    info ifo = new info();
                    ifo.row = 0;
                    ifo.col = 0;
                    ifo.score = int.MaxValue - 1;
                    return ifo;
                }
                else //if it's a tie, return minValue + 2
                {
                    info ifo = new info();
                    ifo.row = 0;
                    ifo.col = 0;
                    ifo.score = int.MinValue + 2;
                    return ifo;
                }
            }
            else
            {
                
                Cell[,] newBoard;
                newBoard = new Cell[3, 3];
                info ifo;

                if(MaxPlayer)
                {
                    int maxEval = int.MinValue;
                    int[] bestPos = new int[2];
                    bestPos[0] = -1;
                    bestPos[1] = -1;

                    foreach (Cell cell in gb) //loop trough each cell in the board
                    {
                        if(cell.getPlayer() == 0) //check if it's an empty spot
                        {
                            newBoard = makeNewBoard(gb); //create a new, virtual copy of the board
                            ifo = new info();
                            newBoard[cell.getRow(), cell.getCol()].setPlayer(2); //place a AI "piece" at the position of the cell found above
                            ifo = miniMax(newBoard, false, alpha, beta); //call the miniMax function again, and pass it the new virtual board
                                                                         //the score and moves are stored in "ifo"
                            if(ifo.score > maxEval) //if a higher score was found, set the maxEval to that score, and save the position
                            {
                                maxEval = ifo.score;
                                bestPos[0] = cell.getRow();
                                bestPos[1] = cell.getCol();
                            }

                            alpha = Math.Max(alpha, maxEval); //update alpha
                            if(alpha >= beta) //if alpha is greater then or equal to beta, break. this is to stop the AI from searching
                                              //unnecessary branches
                            {
                                break;
                            }
                        }
                    }
                    //return the info from maximizing player
                    ifo = new info();
                    ifo.score = maxEval;
                    ifo.row = bestPos[0];
                    ifo.col = bestPos[1];
                    return ifo;
                }
                else
                {
                    //minimum player, very similar to the maximizing player, except for the alpha-beta pruning
                    int minEval = int.MaxValue;
                    int[] bestPos = new int[2];
                    bestPos[0] = -1;
                    bestPos[1] = -1;
                    foreach (Cell cell in gb)
                    {
                        if (cell.getPlayer() == 0)
                        {
                            newBoard = makeNewBoard(gb);
                            ifo = new info();
                            newBoard[cell.getRow(), cell.getCol()].setPlayer(1);
                            ifo = miniMax(newBoard, true, alpha, beta);

                            if (ifo.score < minEval)
                            {
                                minEval = ifo.score;
                                bestPos[0] = cell.getRow();
                                bestPos[1] = cell.getCol();
                            }
                            beta = Math.Min(beta, minEval);
                            if(alpha >= beta)
                            {
                                break;
                            }
                        }
                    }
                    ifo = new info();
                    ifo.score = minEval;
                    ifo.row = bestPos[0];
                    ifo.col = bestPos[1];
                    return ifo;
                }
            }
        }
    }
}
