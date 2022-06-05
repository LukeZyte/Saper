using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class CellButton : Button
    {
        public bool flaged = false;
        string cellType;
        int cellRow;
        int cellCol;

        public CellButton(string _cellType = "default", int _cellRow = 0, int _cellCol = 0)
        {
            cellType = _cellType;
            cellRow = _cellRow;
            cellCol = _cellCol;
        }

        public string getCellType()
        {
            return cellType;
        }

        public void setCellType(string _cellType)
        {
            cellType= _cellType;
        }

        public int getCellRow()
        {
            return cellRow;
        }

        public void setCellRow(int _cellRow)
        {
            cellRow= _cellRow;
        }

        public int getCellCol()
        {
            return cellCol;
        }

        public void setCellCol(int _cellCol)
        {
            cellCol = _cellCol;
        }
    }
}
