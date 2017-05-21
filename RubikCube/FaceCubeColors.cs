using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    class FaceCubeColors
    {
        public Color Front { get; set; }
        public Color Back { get; set; }
        public Color Top { get; set; }
        public Color Bottom { get; set; }
        public Color Left { get; set; }
        public Color Right { get; set; }

        public FaceCubeColors()
        {
            this.Front = Color.Gray;
            this.Back = Color.Gray;
            this.Top = Color.Gray;
            this.Bottom = Color.Gray;
            this.Left = Color.Gray;
            this.Right = Color.Gray;
        }

        public FaceCubeColors(Color Front, Color Back, Color Up, Color Bottom, Color Left, Color Right)
        {
            this.Front = Front;
            this.Back = Back;
            this.Top = Up;
            this.Bottom = Bottom;
            this.Left = Left;
            this.Right = Right;
        }

        public void Rotate(RubikCubeMoviment moviment)
        {
            var oldState = (FaceCubeColors)this.MemberwiseClone();

            if (moviment.Axis == Axis.X)
            {
                if (moviment.Spin == Spin.Clockwise) //Up
                {
                    this.Front = oldState.Bottom;
                    this.Bottom = oldState.Back;
                    this.Back = oldState.Top;
                    this.Top = oldState.Front;
                }
                else //Down
                {
                    this.Front = oldState.Top;
                    this.Bottom = oldState.Front;
                    this.Back = oldState.Bottom;
                    this.Top = oldState.Back;
                }
            }
            else if(moviment.Axis == Axis.Y)
            {
                if(moviment.Spin== Spin.Clockwise) //Left
                {
                    this.Front = oldState.Right;
                    this.Left = oldState.Front;
                    this.Back = oldState.Left;
                    this.Right = oldState.Back;
                }
                else //Right
                {
                    this.Front = oldState.Left;
                    this.Left = oldState.Back;
                    this.Back = oldState.Right;
                    this.Right = oldState.Front;
                }
            }
            else if(moviment.Axis == Axis.Z)
            {
                if(moviment.Spin == Spin.Clockwise) 
                {
                    this.Top = oldState.Left;
                    this.Right = oldState.Top;
                    this.Bottom = oldState.Right;
                    this.Left = oldState.Bottom;
                }
                else
                {
                    this.Top = oldState.Right;
                    this.Right = oldState.Bottom;
                    this.Bottom = oldState.Left;
                    this.Left = oldState.Top;
                }
            }
        }
    }
}
