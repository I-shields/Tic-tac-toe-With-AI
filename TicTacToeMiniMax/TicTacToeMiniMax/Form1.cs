using System.Diagnostics;
using System.Xml.Linq;

namespace TicTacToeMiniMax
{
    public partial class Form1 : Form
    {
        private Board gameBoard;
        public Form1()
        {
            gameBoard = new Board();
            InitializeComponent();
            setBoard();
            btn_0_0.MouseDown += placePiece;
            btn_0_1.MouseDown += placePiece;
            btn_0_2.MouseDown += placePiece;
            btn_1_0.MouseDown += placePiece;
            btn_1_1.MouseDown += placePiece;
            btn_1_2.MouseDown += placePiece;
            btn_2_0.MouseDown += placePiece;
            btn_2_1.MouseDown += placePiece;
            btn_2_2.MouseDown += placePiece;
            Reset_Btn.MouseDown += resetBoard;
            End_Btn.MouseDown += endOfTurn;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void setBoard()
        {
            string name;
            char delim = '_';
            int posDelim;
            int col;
            int row;
            Cell c;

            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Text == "")
                {
                    name = button.Name;
                    posDelim = name.IndexOf(delim);
                    row = Int32.Parse(name.Substring(posDelim + 1, 1));
                    name = name.Substring(posDelim + 2);
                    posDelim = name.IndexOf(delim);
                    col = Int32.Parse(name.Substring(posDelim + 1));
                    c = new Cell(row, col, button, 0);
                    gameBoard.buildBoard(c);
                }
            }
        }

        private void placePiece(object sender, EventArgs e)
        {
            string btnName;
            int col;
            int row;
            char delim = '_';
            int posDelim;
            btnName = ((Button)sender).Name;

            if (gameBoard.getTurn() && !gameBoard.getPlaced())
            {
                posDelim = btnName.IndexOf(delim);
                row = Int32.Parse(btnName.Substring(posDelim + 1, 1));
                btnName = btnName.Substring(posDelim + 2);
                posDelim = btnName.IndexOf(delim);
                col = Int32.Parse(btnName.Substring(posDelim + 1));
                Debug.WriteLine("Row: " + row + "," + col);
                gameBoard.placePiece(row, col);
            }
        }

        private void resetBoard(object sender, EventArgs e)
        {
            foreach(Button btn in this.Controls.OfType<Button>())
            {
                btn.Enabled = true;
            }
            WinBox.Text = "";
            WinBox.Visible = false;
            gameBoard.resetGame();
            gameBoard.setTurn(true);
        }

        private void endOfTurn(object sender, EventArgs e)
        {
            if(!gameBoard.getTurn())
            {
                MiniMax mim = new MiniMax();
                int[] moves = new int[2];
                moves = mim.GetMove(gameBoard);
                gameBoard.placePiece(moves[0], moves[1]);
            }

            bool tie = true;

            foreach(Cell c in gameBoard.getBoard())
            {
                if(c.getPlayer() == 0)
                {
                    tie = false;
                    break;
                }
            }
            if(tie)
            {
                WinBox.Visible = true;
                WinBox.ForeColor = Color.Blue;
                WinBox.Text = "It's a tie";
            }
            else if(gameBoard.checkWin(1))
            {
                WinBox.Visible = true;
                WinBox.ForeColor = Color.Green;
                WinBox.Text = "Player wins";
            }
            else if (gameBoard.checkWin(2))
            {
                WinBox.Visible = true;
                WinBox.ForeColor = Color.Red;
                WinBox.Text = "AI wins";
            }
        }
    }
}
