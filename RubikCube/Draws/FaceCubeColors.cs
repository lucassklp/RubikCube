using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube.Draws
{
    class FaceCubeColors
    {
        public Color Front { get; set; }
        public Color Back { get; set; }
        public Color Up { get; set; }
        public Color Bottom { get; set; }
        public Color Left { get; set; }
        public Color Right { get; set; }

        public FaceCubeColors()
        {
            this.Front = Color.Gray;
            this.Back = Color.Gray;
            this.Up = Color.Gray;
            this.Bottom = Color.Gray;
            this.Left = Color.Gray;
            this.Right = Color.Gray;
        }

        public FaceCubeColors(Color Front, Color Back, Color Up, Color Bottom, Color Left, Color Right)
        {
            this.Front = Front;
            this.Back = Back;
            this.Up = Up;
            this.Bottom = Bottom;
            this.Left = Left;
            this.Right = Right;
        }
    }
}
