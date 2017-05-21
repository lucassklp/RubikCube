using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RubikCube
{
    public partial class ControllerForm : Form
    {
        RubikCubeForm rubikForm;
        public ControllerForm()
        {
            InitializeComponent();
            rubikForm = new RubikCubeForm();
            rubikForm.Show();
        }

        private void btnFirstXUp_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.First, Spin.Clockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnSecondXUp_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Second, Spin.Clockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnThirdXUp_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Third, Spin.Clockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnFirstYRight_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.First, Spin.Anticlockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }

        private void btnSecondYRight_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Second, Spin.Anticlockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }

        private void btnThirdYRight_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Third, Spin.Anticlockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }

        private void btnThirdXDown_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Third, Spin.Anticlockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnSecondXDown_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Second, Spin.Anticlockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnFirstXDown_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.First, Spin.Anticlockwise, Axis.X);
            rubikForm.Manipulate(moviment);
        }

        private void btnThirdYLeft_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Third, Spin.Clockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }

        private void btnSecondYLeft_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.Second, Spin.Clockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }

        private void btnFirstYLeft_Click(object sender, EventArgs e)
        {
            RubikCubeMoviment moviment = new RubikCubeMoviment(Depth.First, Spin.Clockwise, Axis.Y);
            rubikForm.Manipulate(moviment);
        }
    }
}
