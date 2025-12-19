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
        public TextBox[,] coordTextBoxes = null;
        private int num_of_side = 3;
        public Form1()
        {
            InitializeComponent();
            cShapeBox.SelectedIndex = 0;
        }

        private void createPinBoardBtn_Click(object sender, EventArgs e)
        {
            int rows = Convert.ToInt32(rowBox.Text);
            int cols = Convert.ToInt32(colBox.Text);
            board = new Board(
                rows, cols,
                Convert.ToInt32(xIntervalBox.Text), 
                Convert.ToInt32(yIntervalBox.Text));

            boardBtns = new RadioButton[rows, cols];
            Tuple<int, int> boardOffset = Tuple.Create(pinBoardVisualGroup.Location.X, pinBoardVisualGroup.Location.Y);

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
                        AutoCheck = false,
                        Location = new Point(3, 3),
                        TabStop = true,
                        UseVisualStyleBackColor = true,
                        Name = string.Concat(i, ",", j),
                        
                    };

                    boardBtns[i, j].Click += new System.EventHandler(this.clickRadioBtn);

                    btnContainer.Controls.Add(boardBtns[i, j]);
                    pinBoardVisualGroup.Controls.Add(btnContainer);
                }
            }


        }

        private void clickRadioBtn(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            string[] parts = rb.Name.Split(',');
            int row = int.Parse(parts[0]);
            int col = int.Parse(parts[1]);

            board.ClickBoardPt(row, col);
            UpdateCoordBox(row, col);
            rb.Checked = !rb.Checked;

            int selected = board.NumOfClickedPt();

            // If max reached → disable all unselected buttons
            if (selected >= num_of_side)
            {
                for (int i = 0; i < board.Row; i++)
                {
                    for (int j = 0; j < board.Col; j++)
                    {
                        if (!boardBtns[i, j].Checked)
                            boardBtns[i, j].Enabled = false;
                    }
                }
            }
            else
            {
                // Otherwise keep everything enabled
                for (int i = 0; i < board.Row; i++)
                    for (int j = 0; j < board.Col; j++)
                        boardBtns[i, j].Enabled = true;
            }
        }

        private void UnCheckAllRadio()
        {
       
    
            for (int i = 0; i < board.Row; i++)
            {
                for (int j = 0; j < board.Col; j++)
                {
                    boardBtns[i, j].Checked = false;
                    boardBtns[i, j].Enabled = true;
                    board.board_list[i, j] = 0;
 
                }
            }
         
        }
        private void UpdateCoordBox(int i, int j)
        {
            if (boardBtns[i, j].Checked){
                //remove data in textbox
                var target = (i, j);
                for (int k = 0; k < num_of_side; k++)
                {
                    if (coordTextBoxes[k, 0].Tag != null && Equals(coordTextBoxes[k, 0].Tag, target))
                    {
                        coordTextBoxes[k, 0].Text = "";
                        coordTextBoxes[k, 1].Text = "";
                        coordTextBoxes[k, 2].Text ="";
                        coordTextBoxes[k, 3].Text ="";
                        coordTextBoxes[k, 0].Tag =null;
                        return;
                    }
                }
            }

            //find first empty row and fill in data of radio button at (i, j)
            for(int k = 0; k < num_of_side; k++)
            {
                if (coordTextBoxes[k, 0].Tag == null)
                {
                    coordTextBoxes[k, 0].Text = (i + 1).ToString();
                    coordTextBoxes[k, 1].Text = (j + 1).ToString();
                    coordTextBoxes[k, 2].Text = (j * Convert.ToInt32(xIntervalBox.Text)).ToString();
                    coordTextBoxes[k, 3].Text = (i * Convert.ToInt32(yIntervalBox.Text)).ToString();
                    coordTextBoxes[k, 0].Tag = (i, j);
                    break;
                }
            }
        }
    
        private void createCoordBox()
        {
            coordTextBoxes = new TextBox[num_of_side, 4];
            int rowDist = 30;
            int y = ptRowLabel.Location.Y ;
            Label[] labelList = { ptRowLabel, ptColLabel, ptXLabel, ptYLabel };

            for (int i = 0; i < num_of_side; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    coordTextBoxes[i, j] = new TextBox
                    {
                        Location = new Point(labelList[j].Location.X - 10, y + rowDist * (i + 1)),
                        Width = 60,
                        Name = string.Concat(i, ",", j),
                        Tag = null
                    };

                    coordGroup.Controls.Add(coordTextBoxes[i, j]);
                }
               
            }
        }

        private void calcBtn_Click(object sender, EventArgs e)
        {
            GeoPoint[] points = new GeoPoint[num_of_side];
            for (int k = 0; k < num_of_side; k++)
            {
            
                if (coordTextBoxes[k, 0].Tag == null)
                {
                    MessageBox.Show("Please fill in all coordinates");
                    return;
                };

                GeoPoint p = new GeoPoint(
                      Convert.ToInt32(coordTextBoxes[k, 2].Text),
                      Convert.ToInt32(coordTextBoxes[k, 3].Text)
                );

                points[k] = p;
               
                
            }

            if (num_of_side == 3)
            {
                Triangle tri = new Triangle(points);
                messageBox.Text = tri.PropertyString();
            }
            else if (num_of_side == 4) { 
                Tetragon te = new Tetragon(points);
                messageBox.Text = te.PropertyString();
            }
 

        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            board.Reset();
            pinBoardVisualGroup.Controls.Clear();
            boardBtns = null;

            //reset props text
            foreach(object obj in pinBoardPropsGroup.Controls)
            {
                TextBox t = obj as TextBox;
                if(t != null) t.Text = string.Empty;
                
            }

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            messageBox.Text = "";
        }

        private void cShapeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            num_of_side = cShapeBox.SelectedIndex == 0 ? 3 : 4;
            //clear old boxes
            if(coordTextBoxes == null)
            {
                createCoordBox();
                return;
            }

            foreach(var box in coordTextBoxes)
            {
                coordGroup.Controls.Remove(box);
            }

            createCoordBox();
            UnCheckAllRadio();
        }
    }
}
