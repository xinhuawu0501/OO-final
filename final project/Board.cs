using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public class Board
    {
        public int[,] board_list = null;
        private int x_interval = 0;
        private int y_interval = 0;

        public Board(int rows, int cols, int x_int, int y_int) { 
            board_list = new int[rows, cols];
            x_interval = x_int;
            y_interval = y_int;
            
        }

        public void ClickBoardPt(int i, int j)
        {

            if (board_list[i, j] == 1) board_list[i, j] = 0;
            else board_list[i, j] = 1;
        }

        public int NumOfClickedPt()
        {
            return board_list.Cast<int>().Count(item => item != 0);

        }

        public int Row
        {
            get { return board_list.GetLength(0); }
        }
        public int Col
        {
            get { return board_list.GetLength(1); }
        }


        public Tuple<int, int> CalcCoord(int i, int j) {
            int x = i * x_interval;
            int y = j * y_interval;
            return Tuple.Create(x, y);
        
        }
    }
}
