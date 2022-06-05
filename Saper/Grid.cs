using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public static class Grid
    {
        public static CellButton[,] gridTab;
        public static int minesNumber;
        public static int gridSize;
        public static bool freezeGrid = false;

        public static void InitMap(Form current, int _gridSize, int cellSize, int _minesNumber)
        {
            gridSize = _gridSize;
            gridTab = new CellButton[gridSize, gridSize];
            minesNumber = _minesNumber;
            freezeGrid = false;

            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    CellButton cell = new("default", row, col)
                    {
                        Size = new Size(cellSize, cellSize),
                        Location = new Point(col * cellSize + 5, row * cellSize + 30),
                        BackColor = Color.White,
                    };
                    gridTab[row, col] = cell;
                    current.Controls.Add(gridTab[row, col]);
                    cell.MouseUp += new MouseEventHandler(GridLogic.onCellClicked);
                }
            }
        }

        public static void RemoveMap(Form current)
        {
            for (int row = 0; row < Math.Sqrt(gridTab.Length); row++)
            {
                for (int col = 0; col < Math.Sqrt(gridTab.Length); col++)
                {
                    current.Controls.Remove(gridTab[row, col]);
                }
            }
            GridLogic.firstClick = true;
        }

        public static void FillMines(int number)
        {
            for (int i = 0; i < number; i++)
            {
                Random random = new();
                int randNum1 = random.Next(0, (int)Math.Sqrt(gridTab.Length));
                int randNum2 = random.Next(0, (int)Math.Sqrt(gridTab.Length));
                if (gridTab[randNum1, randNum2].getCellType() != "Clicked" && gridTab[randNum1, randNum2].getCellType() != "Mine")
                {
                    gridTab[randNum1, randNum2].setCellType("Mine");
                }
                else
                {
                    number += 1;
                }
            }
        }
    }
}
