using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class Form1 : Form
    {
        public Board board = null;
        public RadioButton[,] boardBtns = null;
        private readonly int MAX_CHECKED = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void createPinBoardBtn_Click(object sender, EventArgs e)
        {
            //TODO: destroy old board
            //if (board != null) Dispose(board);
            int rows = Convert.ToInt32(rowBox.Text);
            int cols = Convert.ToInt32(colBox.Text);
            board = new Board(
                rows, cols,
                Convert.ToInt32(xIntervalBox.Text), 
                Convert.ToInt32(yIntervalBox.Text));

            boardBtns = new RadioButton[rows, cols];
            Tuple<int, int> boardOffset = Tuple.Create(pinBoardVisualGroup.Location.X, pinBoardVisualGroup.Location.Y);
            Console.WriteLine(boardOffset);

            int row_distance = 30;
            int col_distance = 30;

            for (int i = 0; i < board.Row; i++)
            {
                for (int j = 0; j < board.Col; j++)
                {
                    Panel btnContainer = new Panel
                    {
                        Location = new Point(20 + j * col_distance, 20 + i * row_distance),
                        Size = new Size(20, 20),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    boardBtns[i, j] = new RadioButton
                    {
                        AutoSize = true,
                        Location = new Point(3, 3),
                        TabStop = true,
                        UseVisualStyleBackColor = true,
                        Name = string.Concat(i, ",", j)
                    };

                    boardBtns[i, j].Click += new System.EventHandler(this.clickRadioBtn);
                    Console.WriteLine(boardBtns[i, j].Name);

                    btnContainer.Controls.Add(boardBtns[i, j]);
                    pinBoardVisualGroup.Controls.Add(btnContainer);
                }
            }


        }

        private void clickRadioBtn(object sender, EventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            string[] name = radioButton.Name.Split(',');
            int i = Convert.ToInt32(name[0]);
            int j = Convert.ToInt32(name[1]);

         
            if(board.NumOfClickedPt() == MAX_CHECKED)
            {
                //freeze all other buttons
                for(int k = 0; k < board.Row; k++)
                {
                    for(int l = 0; l < board.Col; l++)
                    {
                        if (board.board_list[k, l] != 1) boardBtns[i, j].Enabled = false;
                    }
                }
            }

            board.ClickBoardPt(i, j);
            Console.WriteLine(board.NumOfClickedPt());

        }



        private void calcBtn_Click(object sender, EventArgs e)
        {

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
