﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace MinTetris
{
    class pLm : Tetromino
    {
        public pLm(Main main) : base(main)
        {
            color = main.pLmColor;
            columns = main.columns;
            xPos = (columns - 2) / 2;
            yPos = 0;
        }

        public override List<int> GetLayout(OutputDestination destination)
        {
            int position;
            List<int> layout = new List<int>();
            position = xPos + yPos * columns;
            if (destination == OutputDestination.Next)
            {
                position = 0;
                columns = nextColumns;
            }
            switch (rotation)
            {
                case Rotation.rotate0:
                    layout.Add(position + 1);
                    layout.Add(position + columns + 1);
                    layout.Add(position + columns * 2 + 1);
                    layout.Add(position + columns * 3);
                    layout.Add(position + columns * 3 + 1);
                    TetroWidth = 2;
                    TetroHeight = 4;
                    break;
                case Rotation.rotate90:
                    layout.Add(position);
                    layout.Add(position + columns);
                    layout.Add(position + columns + 1);
                    layout.Add(position + columns + 2);
                    layout.Add(position + columns + 3);
                    TetroWidth = 4;
                    TetroHeight = 2;
                    break;
                case Rotation.rotate180:
                    layout.Add(position);
                    layout.Add(position + 1);
                    layout.Add(position + columns);
                    layout.Add(position + columns * 2);
                    layout.Add(position + columns * 3);
                    TetroWidth = 2;
                    TetroHeight = 4;
                    break;
                case Rotation.rotate270:
                    layout.Add(position);
                    layout.Add(position + 1);
                    layout.Add(position + 2);
                    layout.Add(position + 3);
                    layout.Add(position + columns + 3);
                    TetroWidth = 4;
                    TetroHeight = 2;
                    break;
            }
            return layout;
        }
    }
}
