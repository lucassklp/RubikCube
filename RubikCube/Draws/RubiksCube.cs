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
        List<Cube> draws;

        public RubiksCube()
        {
            draws = new List<Cube>();

            var cm1m1m1 = new FaceCubeColors();
            cm1m1m1.Back = Color.Blue;
            cm1m1m1.Bottom = Color.Yellow;
            cm1m1m1.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, -.8, -.8, cm1m1m1));

            var cm1m1p0 = new FaceCubeColors();
            cm1m1p0.Bottom = Color.Yellow;
            cm1m1p0.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, -.8, 0, cm1m1p0));

            var cm1m1p1 = new FaceCubeColors();
            cm1m1p1.Bottom = Color.Yellow;
            cm1m1p1.Left = Color.Orange;
            cm1m1p1.Front = Color.Green;
            draws.Add(new Cube(.3, -.8, -.8, .8, cm1m1p1));

            var cm1p0m1 = new FaceCubeColors();
            cm1p0m1.Back = Color.Blue;
            cm1p0m1.Bottom = Color.Yellow;
            cm1p0m1.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, 0, -.8, cm1p0m1));

            var cm1p0p0 = new FaceCubeColors();
            cm1p0p0.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, 0, 0, cm1p0p0));

            var cm1p0p1 = new FaceCubeColors();
            cm1p0p1.Bottom = Color.Yellow;
            cm1p0p1.Left = Color.Orange;
            cm1p0p1.Front = Color.Green;
            draws.Add(new Cube(.3, -.8, 0, .8, cm1p0p1));

            var cm1p1m1 = new FaceCubeColors();
            cm1p1m1.Back = Color.Blue;
            cm1p1m1.Up = Color.White;
            cm1p1m1.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, .8, -.8, cm1p1m1));

            var cm1p1p0 = new FaceCubeColors();
            cm1p1p0.Back = Color.Blue;
            cm1p1p0.Up = Color.White;
            cm1p1p0.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, .8, 0, cm1p1p0));

            var cm1p1p1 = new FaceCubeColors();
            cm1p1p1.Front = Color.Green;
            cm1p1p1.Up = Color.White;
            cm1p1p1.Left = Color.Orange;
            draws.Add(new Cube(.3, -.8, .8, .8, cm1p1p1));


            var cm0m1m1 = new FaceCubeColors();
            cm0m1m1.Back = Color.Blue;
            cm0m1m1.Bottom = Color.Yellow;
            draws.Add(new Cube(.3, 0, -.8, -.8, cm0m1m1));

            var cm0m1p0 = new FaceCubeColors();
            cm0m1p0.Bottom = Color.Yellow;
            draws.Add(new Cube(.3, 0, -.8, 0, cm0m1p0));



            var cm0m1p1 = new FaceCubeColors();
            cm0m1p1.Bottom = Color.Yellow;
            cm0m1p1.Front = Color.Green;

            var generic = new FaceCubeColors(Color.Green, Color.Blue, Color.White, Color.Yellow, Color.Orange, Color.Red);

            draws.Add(new Cube(.3, 0, -.8, .8, generic));


            draws.Add(new Cube(.3, 0, 0, -.8, generic));



            draws.Add(new Cube(.3, 0, 0, 0, generic));
            draws.Add(new Cube(.3, 0, 0, .8, generic));
            draws.Add(new Cube(.3, 0, .8, -.8, generic));
            draws.Add(new Cube(.3, 0, .8, 0, generic));
            draws.Add(new Cube(.3, 0, .8, .8, generic));

            draws.Add(new Cube(.3, .8, -.8, -.8, generic));
            draws.Add(new Cube(.3, .8, -.8, 0, generic));
            draws.Add(new Cube(.3, .8, -.8, .8, generic));
            draws.Add(new Cube(.3, .8, 0, -.8, generic));
            draws.Add(new Cube(.3, .8, 0, 0, generic));
            draws.Add(new Cube(.3, .8, 0, .8, generic));
            draws.Add(new Cube(.3, .8, .8, -.8, generic));
            draws.Add(new Cube(.3, .8, .8, 0, generic));
            draws.Add(new Cube(.3, .8, .8, .8, generic));





            //for (int x = -1; x < 2; x++)
            //{
            //    for (int y = -1; y < 2; y++)
            //    {
            //        for (int z = -1; z < 2; z++)
            //        {
            //            draws.Add(new Cube(.8, x, y, z));
            //        }
            //    }
            //}
        }

        public void Rotate()
        {

        }

        public void Draw()
        {
            foreach (var item in draws)
            {
                item.Draw();
            }
        }
    }
}
