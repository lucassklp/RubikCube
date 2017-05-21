using RubikCube.Draws;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.OpenGl;

namespace RubikCube
{
    public partial class RubikCubeForm : Form
    {
        Timer timer;

        RubiksCube rubiksCube;

        public RubikCubeForm()
        {
            InitializeComponent();
            this.timer = new Timer();
            timer.Tick += Tick;
            timer.Enabled = true;
            timer.Interval = 1;
            timer.Start();
            
            OpenGlControl.Width = this.Width;
            OpenGlControl.Height = this.Height;
            OpenGlControl.InitializeContexts();

            Gl.glViewport(0, 0, this.Width, this.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)this.Width / (double)this.Height, 0.01f, 5000.0f);
            Gl.glEnable(Gl.GL_CULL_FACE);
            Gl.glCullFace(Gl.GL_BACK);

            //Gl.glClearColor()
            Gl.glClearColor(.85f, .85f, .85f, 1);
            Gl.glClear(Gl.GL_CLEAR);

            rubiksCube = new RubiksCube();

        }

        private void Tick(object sender, EventArgs e)
        {
            this.OpenGlControl.Invalidate();
        }

        public void Manipulate(RubikCubeMoviment moviment)
        {
            rubiksCube.Manipulate(moviment);
        }


        private void OpenGlControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                rubiksCube.Rotate(0, 5, 0);
            }
            else if (e.KeyCode == Keys.A)
            {
                rubiksCube.Rotate(0, -5, 0);
            }
            else if (e.KeyCode == Keys.W)
            {
                rubiksCube.Rotate(-5, 0, 0);
            }
            else if (e.KeyCode == Keys.S)
            {
                rubiksCube.Rotate(5, 0, 0);
            }
        }

        private void OpenGlControl_Paint(object sender, PaintEventArgs e)
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            Gl.glEnable(Gl.GL_DEPTH_TEST);
            Gl.glDepthFunc(Gl.GL_LESS);

            Gl.glPointSize(3);
            Gl.glPolygonMode(Gl.GL_FRONT, Gl.GL_LINES);
            Gl.glPolygonMode(Gl.GL_BACK, Gl.GL_LINES);

            Gl.glTranslated(0, 0, -5);

            rubiksCube.Draw();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            OpenGlControl.Width = this.Width;
            OpenGlControl.Height = this.Height;
            Gl.glViewport(0, 0, this.Width, this.Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45.0f, (double)this.Width / (double)this.Height, 0.01f, 5000.0f);
        }
    }
}
