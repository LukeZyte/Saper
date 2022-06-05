using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public static class GridLogic
    {
        public static bool firstClick = true;

        public static void onCellClicked(object sender, MouseEventArgs e)
        {
            if (!Grid.freezeGrid)
            {
                CellButton clickedCell = sender as CellButton;
                switch (e.Button.ToString())
                {
                    case "Right":
                        onRightCellClicked(clickedCell);
                        break;
                    case "Left":
                        onLeftCellClicked(clickedCell);
                        break;
                }
            }
        }

        private static void onLeftCellClicked(CellButton clickedCell)
        {
            if (clickedCell.getCellType() == "Mine")
            {
                showAllMines();
                clickedCell.BackColor = Color.Black;
                Grid.freezeGrid = true;
            }
            else
            {
                if (firstClick)
                {
                    firstClick = false;
                    Grid.FillMines(Grid.minesNumber);
                }
                fillCellContent(clickedCell);
                showSafeCellsAround(clickedCell);
                gameScoreUpdate(clickedCell);
            }
        }
        private static void onRightCellClicked(CellButton clickedCell)
        {
            if (clickedCell.flaged == true)
            {
                clickedCell.BackColor = Color.White;
                clickedCell.flaged = false;
            }
            else if (clickedCell.getCellType() != "Clicked")
            {
                clickedCell.BackColor = Color.LimeGreen;
                clickedCell.flaged = true;
                gameScoreUpdate(clickedCell);
            }
        }

        private static void showAllMines()
        {
            foreach (CellButton cell in Grid.gridTab)
            {
                if (cell.getCellType() == "Mine")
                {
                    cell.BackColor = Color.Red;
                }
            }
        }

        private static void fillCellContent(CellButton clickedCell)
        {
            int numOfMinesAround = countMinesAround(clickedCell);

            clickedCell.BackColor = Color.LightGray;
            clickedCell.setCellType("Clicked");
            clickedCell.FlatStyle = FlatStyle.Flat;
            clickedCell.BackColor = Color.LightGray;
            clickedCell.FlatAppearance.BorderSize = 0;
            clickedCell.Text = numOfMinesAround.ToString();
            clickedCell.Font = new Font(clickedCell.Font.FontFamily.Name, 16, FontStyle.Bold);
            clickedCell.TextAlign = ContentAlignment.MiddleCenter;
            clickedCell.UseCompatibleTextRendering = true;

            switch (numOfMinesAround)
            {
                case 0:
                    clickedCell.Text = "";
                    break;
                case 1:
                    clickedCell.ForeColor = Color.Blue;
                    break;
                case 2:
                    clickedCell.ForeColor = Color.Green;
                    break;
                case 3:
                    clickedCell.ForeColor = Color.Red;
                    break;
                case 4:
                    clickedCell.ForeColor = Color.Orange;
                    break;
                case 5:
                    clickedCell.ForeColor = Color.Purple;
                    break;
                case 6:
                    clickedCell.ForeColor = Color.Cyan;
                    break;
                case 7:
                    clickedCell.ForeColor = Color.Brown;
                    break;
                case 8:
                    clickedCell.ForeColor = Color.Black;
                    break;
            }
        }

        private static void showSafeCellsAround(CellButton clickedCell)
        {
            int Xpos = clickedCell.getCellCol();
            int Ypos = clickedCell.getCellRow();

            if (Grid.gridTab[Ypos, Xpos].Text == "")
            {
                for (int x = Xpos - 1; x <= Xpos + 1; x++)
                {
                    for (int y = Ypos - 1; y <= Ypos + 1; y++)
                    {
                        if (x >= 0 && y >= 0 && x < Grid.gridSize && y < Grid.gridSize && Grid.gridTab[y, x].getCellType() == "default")
                        {
                            Grid.gridTab[y, x].BackColor = Color.LightGray;
                            fillCellContent(Grid.gridTab[y, x]);
                            showSafeCellsAround(Grid.gridTab[y, x]);
                        }
                    }
                }
            }
        }

        private static int countMinesAround(CellButton clickedCell)
        {
            int Xpos = clickedCell.getCellCol();
            int Ypos = clickedCell.getCellRow();
            int count = 0;

            for (int x = Xpos - 1; x <= Xpos + 1; x++)
            {
                for (int y = Ypos - 1; y <= Ypos + 1; y++)
                {
                    if (x >= 0 && y >= 0 && x < Grid.gridSize && y < Grid.gridSize && Grid.gridTab[y, x].getCellType() == "Mine")
                    {
                        count++;
                    } 
                }
            }
            return count;
        }

        private static void gameScoreUpdate(CellButton clickedCell)
        {
            int correctFlags = 0;

            foreach (CellButton currentCell in Grid.gridTab)
            {
                if (currentCell.getCellType() == "Mine" && currentCell.flaged)
                {
                    correctFlags++;
                }

                if (correctFlags == Grid.minesNumber)
                {
                    MessageBox.Show("Congratulations, You have filled the board!", "You won!");
                    Grid.freezeGrid = true;
                    break;
                }
            }
        }
    }
}
