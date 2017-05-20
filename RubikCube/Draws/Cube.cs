using System;
using System.Collections.Generic;
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
        private FaceCubeColors faceColors;

        public Cube(double size, double X, double Y, double Z)
        {
            this.size = size;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.faceColors = new FaceCubeColors(Color.Black, Color.Black, Color.Black, Color.Black, Color.Black, Color.Black);
        }

        public Cube(double size, double X, double Y, double Z, FaceCubeColors faceColors)
        {
            this.size = size;
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.faceColors = faceColors;
        }

        public void Draw()
        {
            Gl.glBegin(Gl.GL_QUADS);

            //Trazeira
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
            Gl.glColor3ub(faceColors.Up.R, faceColors.Up.G, faceColors.Up.B);
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

        }
    }
}
