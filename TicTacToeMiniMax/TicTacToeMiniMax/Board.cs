using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMiniMax
{
    internal class Board
    {
        private Cell[,] cells = new Cell[3,3];
        private bool isPlayerTurn = true;
        private bool placed = false;


        public Cell[,] getBoard()
        {
            return cells;
        }

        public void buildBoard(Cell cell)
        {
            cells[cell.getRow(), cell.getCol()] = cell;
        }

        public bool getTurn()
        {
            return isPlayerTurn;
        }

        public void setTurn(bool turn)
        {
            isPlayerTurn = turn;
        }

        public bool checkPos(int r, int c)
        {
            if (cells[r, c].getPlayer() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void placePiece(int r, int c)
        {
            if(isPlayerTurn && checkPos(r, c))
            {
                cells[r, c].setPlayer(1);
                cells[r, c].getBtn().Text = "X";
                placed = true;
                isPlayerTurn=false;
            }
            else if(!isPlayerTurn && checkPos(r,c))
            {
                cells[r, c].setPlayer(2);
                cells[r, c].getBtn().Text = "O";
                isPlayerTurn = true;
            }
            placed = false;
        }

        public void resetGame()
        {
            foreach(Cell cell in cells)
            {
                cell.getBtn().Text = "";
                cell.setPlayer(0);
            }
        }

        public bool checkWin(int p)
        {
            bool win = false;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    if(cells[j, i].getPlayer() == p)
                    {
                        if(i + 2 < 3 && j + 2 < 3 && cells[j + 1, i + 1].getPlayer() == p
                            && cells[j + 2, i + 2].getPlayer() == p)
                        {
                            win = true;
                        }
                        else if(i + 2 < 3 && j - 2 > -1 && cells[j - 1, i + 1].getPlayer() == p
                            && cells[j - 2, i + 2].getPlayer() == p)
                        {
                            win = true;
                        }
                        else if( i + 2 < 3 && cells[j, i + 1].getPlayer() == p
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

        public bool getPlaced()
        {
            return placed;
        }

        public void setPlaced(bool p)
        {
            placed = p;
        }
    }
}
