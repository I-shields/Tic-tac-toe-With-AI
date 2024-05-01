using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeMiniMax
{
    internal class Cell
    {
        private int row;
        private int col;
        private int player;
        private Button btn;

        public Cell()
        {

        }

        public Cell(int r, int c, Button b, int p)
        {
            row = r; 
            col = c; 
            player = p;
            btn = b;
        }

        public void setRow(int r)
        {
            row = r;
        }

        public void setCol(int c)
        {
            col = c;
        }

        public void setPlayer(int p)
        {
            player = p;
        }

        public void setBtn(Button b)
        {
            btn = b;
        }

        public int getRow()
        {
            return row;
        }

        public int getCol()
        {
            return col;
        }

        public int getPlayer()
        {
            return player;
        }

        public Button getBtn()
        {
            return btn;
        }
    }
}
