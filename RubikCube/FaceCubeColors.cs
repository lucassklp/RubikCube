using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    class FaceCube<T>
    {
        public T Front { get; set; }
        public T Back { get; set; }
        public T Top { get; set; }
        public T Bottom { get; set; }
        public T Left { get; set; }
        public T Right { get; set; }


        public FaceCube(T Front, T Back, T Up, T Bottom, T Left, T Right)
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
            var oldState = (FaceCube<T>)this.MemberwiseClone();

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
