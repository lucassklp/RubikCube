using RubikCube.Draws;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubikCube
{
    class Animation
    {
        private List<Cube> animationCubes;
        public bool AnimationEnded;
        private RubikCubeMoviment moviment;
        int leftDegree;

        public Animation(List<Cube> animationCubes, int degree, RubikCubeMoviment moviment)
        {
            this.animationCubes = animationCubes;
            this.leftDegree = degree;
            this.moviment = moviment;
            this.AnimationEnded = false;
        }

        public void Animate()
        {
            int rotateFactor = 10;

            if (moviment.Axis == Axis.X)
            {
                if(moviment.Spin == Spin.Clockwise)
                {
                    rotateFactor = -rotateFactor;
                }
                foreach (var item in animationCubes)
                {
                    item.Rotate(rotateFactor, 0, 0);
                }
            }
            if (moviment.Axis == Axis.Y)
            {
                if (moviment.Spin == Spin.Clockwise)
                {
                    rotateFactor = -rotateFactor;
                }
                foreach (var item in animationCubes)
                {
                    item.Rotate(0, rotateFactor, 0);
                }
            }
            if (moviment.Axis == Axis.Z)
            {
                if (moviment.Spin == Spin.Clockwise)
                {
                    rotateFactor = -rotateFactor;
                }
                foreach (var item in animationCubes)
                {
                    item.Rotate(0, 0, rotateFactor);
                }
            }

            leftDegree -= Math.Abs(rotateFactor);
            if (leftDegree <= 0)
            {
                this.AnimationEnded = true;
                this.Place();
            }
        }

        public void Place()
        {
            foreach (var item in animationCubes)
            {
                item.Place(moviment);
            }
        }
    }
}
