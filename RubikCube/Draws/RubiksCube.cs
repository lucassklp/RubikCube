using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;

namespace RubikCube.Draws
{
    class RubiksCube : IDraw
    {
        List<Cube> composingCubes;
        int AngleX, AngleY, AngleZ;


        public RubiksCube()
        {
            composingCubes = new List<Cube>();
            composingCubes.Add(new Cube(1, 0, 0, 0));

            double blockSpace = .73;
            for (double x = -blockSpace; x < 2 * blockSpace; x += blockSpace)
            {
                for (double y = -blockSpace; y < 2 * blockSpace; y += blockSpace)
                {
                    for (double z = -blockSpace; z < 2 * blockSpace; z += blockSpace)
                    {
                        var cubeColor = this.GenerateCubeColor(x, y, z);
                        composingCubes.Add(new Cube(.32, x, y, z, cubeColor));
                    }
                }
            }
        }

        private FaceCubeColors GenerateCubeColor(double x, double y, double z)
        {
            var cubeColor = new FaceCubeColors(Color.Green, Color.Blue, Color.White, Color.Yellow, Color.Orange, Color.Red);

            if (x < 0)
            {
                cubeColor.Right = Color.DarkGray;
            }
            if (x == 0)
            {
                cubeColor.Left = Color.DarkGray;
                cubeColor.Right = Color.DarkGray;
            }
            if (x > 0)
            {
                cubeColor.Left = Color.DarkGray;
            }
            if (y < 0)
            {
                cubeColor.Top = Color.DarkGray;
            }
            if (y == 0)
            {
                cubeColor.Top = Color.DarkGray;
                cubeColor.Bottom = Color.DarkGray;
            }
            if (y > 0)
            {
                cubeColor.Bottom = Color.DarkGray;
            }
            if (z < 0)
            {
                cubeColor.Front = Color.DarkGray;
            }
            if (z == 0)
            {
                cubeColor.Front = Color.DarkGray;
                cubeColor.Back = Color.DarkGray;
            }
            if (z > 0)
            {
                cubeColor.Back = Color.DarkGray;
            }

            return cubeColor;
        }

        public void Manipulate(RubikCubeMoviment moviment)
        {

            List<Cube> movimentingPieces = new List<Cube>();

            if (moviment.Axis == Axis.X)
            {
                if(moviment.Depth == Depth.First)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.X < 0);
                }
                else if(moviment.Depth == Depth.Second)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.X == 0);
                }
                else if (moviment.Depth == Depth.Third)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.X > 0);
                }


                foreach (var item in movimentingPieces)
                {
                    item.Rotate(90, 0, 0);
                    item.Place(moviment);
                }
            }
            else if(moviment.Axis == Axis.Y)
            {
                if (moviment.Depth == Depth.First)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Y > 0);
                }
                else if (moviment.Depth == Depth.Second)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Y == 0);
                }
                else if (moviment.Depth == Depth.Third)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Y < 0);
                }


                foreach (var item in movimentingPieces)
                {
                    item.Rotate(0, 90, 0);
                    item.Place(moviment);
                }
            }
            else if(moviment.Axis == Axis.Z)
            {
                if (moviment.Depth == Depth.First)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Z > 0);
                }
                else if (moviment.Depth == Depth.Second)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Z == 0);
                }
                else if (moviment.Depth == Depth.Third)
                {
                    movimentingPieces = this.composingCubes.FindAll(pieces => pieces.Z < 0);
                }

                foreach (var item in movimentingPieces)
                {
                    item.Rotate(0, 0, 90);
                    item.Place(moviment);
                }
            }

        }

        public void Rotate(int AngleAxisX, int AngleAxisY, int AngleAxisZ)
        {
            this.AngleX += AngleAxisX;
            this.AngleY += AngleAxisY;
            this.AngleZ += AngleAxisZ;

        }

        public void Draw()
        {
            AdjustRotation();
            foreach (var item in composingCubes)
            {
                item.Draw();
            }
        }

        private void AdjustRotation()
        {
            //if(AngleX > 90)
            //{
            //    this.
            //    this.AngleX = this.AngleX % 91;
            //}

            Gl.glRotatef(AngleX, 1, 0, 0);
            Gl.glRotatef(AngleY, 0, 1, 0);
            Gl.glRotatef(AngleZ, 0, 0, 1);

        }
    }
}
