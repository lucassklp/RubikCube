using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using Tao.OpenGl;

namespace RubikCube.Draws
{
    class Cube : IDraw
    {
        private double size;
        public double X { get; private set; }
        public double Y { get; private set; }
        public double Z { get; private set; }

        private FaceCube<Color> faceColors;

        private int AngleX = 0;
        private int AngleY = 0;
        private int AngleZ = 0;


        public Cube(double size, double X, double Y, double Z)
        {
            this.size = size;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.faceColors = new FaceCube<Color>(Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black);
        }

        public Cube(double size, double X, double Y, double Z, FaceCube<Color> faceColors)
        {
            this.size = size;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.faceColors = faceColors;
        }

        public Cube(double size, double X, double Y, double Z, FaceCube<Texture> faceColors)
        {
            this.size = size;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            //this.faceColors = faceColors;
        }

        public void Rotate(int AngleAxisX, int AngleAxisY, int AngleAxisZ)
        {
            this.AngleX += AngleAxisX;
            this.AngleY += AngleAxisY;
            this.AngleZ += AngleAxisZ;
        }

        public void Draw()
        {

            Gl.glEnable(Gl.GL_TEXTURE);

            Gl.glPushMatrix();
            Gl.glRotatef(AngleX, 1, 0, 0);
            Gl.glRotatef(AngleY, 0, 1, 0);
            Gl.glRotatef(AngleZ, 0, 0, 1);

            Gl.glBegin(Gl.GL_QUADS);

            //Traseira
            Gl.glColor3ub(faceColors.Back.R, faceColors.Back.G, faceColors.Back.B);
            Gl.glVertex3d(this.size + X, this.size + Y, -this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(-this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(-this.size + X, this.size + Y, -this.size + Z);

            //Inferior
            Gl.glColor3ub(faceColors.Bottom.R, faceColors.Bottom.G, faceColors.Bottom.B);
            Gl.glVertex3d(-this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, this.size + Z);
            Gl.glVertex3d(-this.size + X, -this.size + Y, this.size + Z);

            //Esquerda
            Gl.glColor3ub(faceColors.Left.R, faceColors.Left.G, faceColors.Left.B);
            Gl.glVertex3d(-this.size + X, this.size + Y, -this.size + Z);
            Gl.glVertex3d(-this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(-this.size + X, -this.size + Y, this.size + Z);
            Gl.glVertex3d(-this.size + X, this.size + Y, this.size + Z);

            //Direita
            Gl.glColor3ub(faceColors.Right.R, faceColors.Right.G, faceColors.Right.B);
            Gl.glVertex3d(this.size + X, this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, -this.size + Z);
            Gl.glVertex3d(this.size + X, this.size + Y, -this.size + Z);

            ///Superior
            Gl.glColor3ub(faceColors.Top.R, faceColors.Top.G, faceColors.Top.B);
            Gl.glVertex3d(-this.size + X, this.size + Y, -this.size + Z);
            Gl.glVertex3d(-this.size + X, this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, this.size + Y, -this.size + Z);

            //Frente
            Gl.glColor3ub(faceColors.Front.R, faceColors.Front.G, faceColors.Front.B);
            Gl.glVertex3d(-this.size + X, this.size + Y, this.size + Z);
            Gl.glVertex3d(-this.size + X, -this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, -this.size + Y, this.size + Z);
            Gl.glVertex3d(this.size + X, this.size + Y, this.size + Z);

            Gl.glEnd();

            Gl.glPopMatrix();
        }

        public void Place(RubikCubeMoviment moviment)
        {
            this.faceColors.Rotate(moviment);
            this.Transform(moviment);
            this.ResetTransforms();
        }

        private void Transform(RubikCubeMoviment moviment)
        {
            if(moviment.Axis == Axis.X)
            {
                if(moviment.Spin == Spin.Clockwise) //Up
                {
                    //Edges
                    if(this.Y < 0 && this.Z < 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if(this.Y < 0 && this.Z > 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if(this.Y > 0 && this.Z < 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if(this.Y > 0 && this.Z > 0)
                    {
                        this.Z = -this.Z;
                    }

                    //Middles
                    else if(this.Y == 0 && this.Z < 0)
                    {
                        this.Y = this.Z;
                        this.Z = 0;
                    }
                    else if (this.Y == 0 && this.Z > 0)
                    {
                        this.Y = this.Z;
                        this.Z = 0;
                    }
                    else if (this.Z == 0 && this.Y < 0)
                    {
                        this.Z = -this.Y;
                        this.Y = 0;
                    }
                    else if (this.Z == 0 && this.Y > 0)
                    {
                        this.Z = -this.Y;
                        this.Y = 0;
                    }
                }
                else //Down
                {
                    //Edges
                    if (this.Y < 0 && this.Z < 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if (this.Y < 0 && this.Z > 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if (this.Y > 0 && this.Z < 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if (this.Y > 0 && this.Z > 0)
                    {
                        this.Y = -this.Y;
                    }

                    //Middles
                    else if (this.Y == 0 && this.Z < 0)
                    {
                        this.Y = -this.Z;
                        this.Z = 0;
                    }
                    else if (this.Y == 0 && this.Z > 0)
                    {
                        this.Y = -this.Z;
                        this.Z = 0;
                    }
                    else if (this.Z == 0 && this.Y < 0)
                    {
                        this.Z = this.Y;
                        this.Y = 0;
                    }
                    else if (this.Z == 0 && this.Y > 0)
                    {
                        this.Z = this.Y;
                        this.Y = 0;
                    }
                }
            }

            if(moviment.Axis == Axis.Y)
            {
                if (moviment.Spin == Spin.Clockwise) //Left
                {
                    if (this.X < 0 && this.Z < 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X < 0 && this.Z > 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if (this.X > 0 && this.Z < 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if (this.X > 0 && this.Z > 0)
                    {
                        this.X = -this.X;
                    }

                    //Middle
                    else if(this.X == 0 && this.Z < 0)
                    {
                        this.X = -this.Z;
                        this.Z = 0;
                    }
                    else if(this.X == 0 && this.Z > 0)
                    {
                        this.X = -this.Z;
                        this.Z = 0;
                    }
                    else if(this.Z == 0 && this.X < 0)
                    {
                        this.Z = this.X;
                        this.X = 0;
                    }
                    else if(this.Z == 0 && this.X > 0)
                    {
                        this.Z = this.X;
                        this.X = 0;
                    }
                }
                else
                {
                    if (this.X < 0 && this.Z < 0)
                    {
                        this.Z = -this.Z;
                    }
                    else if (this.X < 0 && this.Z > 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X > 0 && this.Z < 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X > 0 && this.Z > 0)
                    {
                        this.Z = -this.Z;
                    }

                    //Middle
                    else if (this.X == 0 && this.Z < 0)
                    {
                        this.X = this.Z;
                        this.Z = 0;
                    }
                    else if (this.X == 0 && this.Z > 0)
                    {
                        this.X = this.Z;
                        this.Z = 0;
                    }
                    else if (this.Z == 0 && this.X < 0)
                    {
                        this.Z = -this.X;
                        this.X = 0;
                    }
                    else if (this.Z == 0 && this.X > 0)
                    {
                        this.Z = -this.X;
                        this.X = 0;
                    }
                }
            }

            if(moviment.Axis == Axis.Z)
            {
                if(moviment.Spin == Spin.Clockwise)
                {
                    if (this.X < 0 && this.Y < 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if (this.X < 0 && this.Y > 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X > 0 && this.Y < 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X > 0 && this.Y > 0)
                    {
                        this.Y = -this.Y;
                    }

                    //Middle
                    else if (this.X == 0 && this.Y < 0)
                    {
                        this.X = this.Y;
                        this.Y = 0;
                    }
                    else if (this.X == 0 && this.Y > 0)
                    {
                        this.X = this.Z;
                        this.Y = 0;
                    }
                    else if (this.Y == 0 && this.X < 0)
                    {
                        this.Y = -this.X;
                        this.X = 0;
                    }
                    else if (this.Y == 0 && this.X > 0)
                    {
                        this.Y = -this.X;
                        this.X = 0;
                    }
                }
                else
                {
                    if (this.X < 0 && this.Y < 0)
                    {
                        this.X = -this.X;
                    }
                    else if (this.X < 0 && this.Y > 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if (this.X > 0 && this.Y < 0)
                    {
                        this.Y = -this.Y;
                    }
                    else if (this.X > 0 && this.Y > 0)
                    {
                        this.X = -this.X;
                    }

                    //Middle
                    else if (this.X == 0 && this.Y < 0)
                    {
                        this.X = -this.Y;
                        this.Y = 0;
                    }
                    else if (this.X == 0 && this.Y > 0)
                    {
                        this.X = -this.Z;
                        this.Y = 0;
                    }
                    else if (this.Y == 0 && this.X < 0)
                    {
                        this.Y = this.X;
                        this.X = 0;
                    }
                    else if (this.Y == 0 && this.X > 0)
                    {
                        this.Y = this.X;
                        this.X = 0;
                    }
                }
            }
            
            this.ResetTransforms();
        }

        private void ResetTransforms()
        {
            this.AngleX = 0;
            this.AngleY = 0;
            this.AngleZ = 0;
        }
    }
}
