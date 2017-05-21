namespace RubikCube
{
    partial class ControllerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnFirstXUp = new System.Windows.Forms.Button();
            this.btnSecondXUp = new System.Windows.Forms.Button();
            this.btnThirdXUp = new System.Windows.Forms.Button();
            this.btnSecondYLeft = new System.Windows.Forms.Button();
            this.btnFirstXDown = new System.Windows.Forms.Button();
            this.btnFirstYLeft = new System.Windows.Forms.Button();
            this.btnThirdYLeft = new System.Windows.Forms.Button();
            this.btnThirdYRight = new System.Windows.Forms.Button();
            this.btnFirstYRight = new System.Windows.Forms.Button();
            this.btnSecondYRight = new System.Windows.Forms.Button();
            this.btnSecondXDown = new System.Windows.Forms.Button();
            this.btnThirdXDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFirstXUp
            // 
            this.btnFirstXUp.Location = new System.Drawing.Point(40, 12);
            this.btnFirstXUp.Name = "btnFirstXUp";
            this.btnFirstXUp.Size = new System.Drawing.Size(30, 23);
            this.btnFirstXUp.TabIndex = 0;
            this.btnFirstXUp.Text = "/\\";
            this.btnFirstXUp.UseVisualStyleBackColor = true;
            this.btnFirstXUp.Click += new System.EventHandler(this.btnFirstXUp_Click);
            // 
            // btnSecondXUp
            // 
            this.btnSecondXUp.Location = new System.Drawing.Point(76, 12);
            this.btnSecondXUp.Name = "btnSecondXUp";
            this.btnSecondXUp.Size = new System.Drawing.Size(30, 23);
            this.btnSecondXUp.TabIndex = 1;
            this.btnSecondXUp.Text = "/\\";
            this.btnSecondXUp.UseVisualStyleBackColor = true;
            this.btnSecondXUp.Click += new System.EventHandler(this.btnSecondXUp_Click);
            // 
            // btnThirdXUp
            // 
            this.btnThirdXUp.Location = new System.Drawing.Point(112, 12);
            this.btnThirdXUp.Name = "btnThirdXUp";
            this.btnThirdXUp.Size = new System.Drawing.Size(30, 23);
            this.btnThirdXUp.TabIndex = 2;
            this.btnThirdXUp.Text = "/\\";
            this.btnThirdXUp.UseVisualStyleBackColor = true;
            this.btnThirdXUp.Click += new System.EventHandler(this.btnThirdXUp_Click);
            // 
            // btnSecondYLeft
            // 
            this.btnSecondYLeft.Location = new System.Drawing.Point(10, 70);
            this.btnSecondYLeft.Name = "btnSecondYLeft";
            this.btnSecondYLeft.Size = new System.Drawing.Size(28, 23);
            this.btnSecondYLeft.TabIndex = 3;
            this.btnSecondYLeft.Text = "<-";
            this.btnSecondYLeft.UseVisualStyleBackColor = true;
            this.btnSecondYLeft.Click += new System.EventHandler(this.btnSecondYLeft_Click);
            // 
            // btnFirstXDown
            // 
            this.btnFirstXDown.Location = new System.Drawing.Point(40, 128);
            this.btnFirstXDown.Name = "btnFirstXDown";
            this.btnFirstXDown.Size = new System.Drawing.Size(30, 23);
            this.btnFirstXDown.TabIndex = 4;
            this.btnFirstXDown.Text = "\\/";
            this.btnFirstXDown.UseVisualStyleBackColor = true;
            this.btnFirstXDown.Click += new System.EventHandler(this.btnFirstXDown_Click);
            // 
            // btnFirstYLeft
            // 
            this.btnFirstYLeft.Location = new System.Drawing.Point(10, 99);
            this.btnFirstYLeft.Name = "btnFirstYLeft";
            this.btnFirstYLeft.Size = new System.Drawing.Size(28, 23);
            this.btnFirstYLeft.TabIndex = 9;
            this.btnFirstYLeft.Text = "<-";
            this.btnFirstYLeft.UseVisualStyleBackColor = true;
            this.btnFirstYLeft.Click += new System.EventHandler(this.btnThirdYLeft_Click);
            // 
            // btnThirdYLeft
            // 
            this.btnThirdYLeft.Location = new System.Drawing.Point(10, 41);
            this.btnThirdYLeft.Name = "btnThirdYLeft";
            this.btnThirdYLeft.Size = new System.Drawing.Size(28, 23);
            this.btnThirdYLeft.TabIndex = 12;
            this.btnThirdYLeft.Text = "<-";
            this.btnThirdYLeft.UseVisualStyleBackColor = true;
            this.btnThirdYLeft.Click += new System.EventHandler(this.btnFirstYLeft_Click);
            // 
            // btnThirdYRight
            // 
            this.btnThirdYRight.Location = new System.Drawing.Point(144, 41);
            this.btnThirdYRight.Name = "btnThirdYRight";
            this.btnThirdYRight.Size = new System.Drawing.Size(28, 23);
            this.btnThirdYRight.TabIndex = 15;
            this.btnThirdYRight.Text = "->";
            this.btnThirdYRight.UseVisualStyleBackColor = true;
            this.btnThirdYRight.Click += new System.EventHandler(this.btnFirstYRight_Click);
            // 
            // btnFirstYRight
            // 
            this.btnFirstYRight.Location = new System.Drawing.Point(144, 99);
            this.btnFirstYRight.Name = "btnFirstYRight";
            this.btnFirstYRight.Size = new System.Drawing.Size(28, 23);
            this.btnFirstYRight.TabIndex = 14;
            this.btnFirstYRight.Text = "->";
            this.btnFirstYRight.UseVisualStyleBackColor = true;
            this.btnFirstYRight.Click += new System.EventHandler(this.btnThirdYRight_Click);
            // 
            // btnSecondYRight
            // 
            this.btnSecondYRight.Location = new System.Drawing.Point(144, 70);
            this.btnSecondYRight.Name = "btnSecondYRight";
            this.btnSecondYRight.Size = new System.Drawing.Size(28, 23);
            this.btnSecondYRight.TabIndex = 13;
            this.btnSecondYRight.Text = "->";
            this.btnSecondYRight.UseVisualStyleBackColor = true;
            this.btnSecondYRight.Click += new System.EventHandler(this.btnSecondYRight_Click);
            // 
            // btnSecondXDown
            // 
            this.btnSecondXDown.Location = new System.Drawing.Point(76, 128);
            this.btnSecondXDown.Name = "btnSecondXDown";
            this.btnSecondXDown.Size = new System.Drawing.Size(30, 23);
            this.btnSecondXDown.TabIndex = 16;
            this.btnSecondXDown.Text = "\\/";
            this.btnSecondXDown.UseVisualStyleBackColor = true;
            this.btnSecondXDown.Click += new System.EventHandler(this.btnSecondXDown_Click);
            // 
            // btnThirdXDown
            // 
            this.btnThirdXDown.Location = new System.Drawing.Point(112, 128);
            this.btnThirdXDown.Name = "btnThirdXDown";
            this.btnThirdXDown.Size = new System.Drawing.Size(30, 23);
            this.btnThirdXDown.TabIndex = 17;
            this.btnThirdXDown.Text = "\\/";
            this.btnThirdXDown.UseVisualStyleBackColor = true;
            this.btnThirdXDown.Click += new System.EventHandler(this.btnThirdXDown_Click);
            // 
            // Controller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 174);
            this.Controls.Add(this.btnThirdXDown);
            this.Controls.Add(this.btnSecondXDown);
            this.Controls.Add(this.btnThirdYRight);
            this.Controls.Add(this.btnFirstYRight);
            this.Controls.Add(this.btnSecondYRight);
            this.Controls.Add(this.btnThirdYLeft);
            this.Controls.Add(this.btnFirstYLeft);
            this.Controls.Add(this.btnFirstXDown);
            this.Controls.Add(this.btnSecondYLeft);
            this.Controls.Add(this.btnThirdXUp);
            this.Controls.Add(this.btnSecondXUp);
            this.Controls.Add(this.btnFirstXUp);
            this.MaximizeBox = false;
            this.Name = "Controller";
            this.Text = "Controller";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstXUp;
        private System.Windows.Forms.Button btnSecondXUp;
        private System.Windows.Forms.Button btnThirdXUp;
        private System.Windows.Forms.Button btnSecondYLeft;
        private System.Windows.Forms.Button btnFirstXDown;
        private System.Windows.Forms.Button btnFirstYLeft;
        private System.Windows.Forms.Button btnThirdYLeft;
        private System.Windows.Forms.Button btnThirdYRight;
        private System.Windows.Forms.Button btnFirstYRight;
        private System.Windows.Forms.Button btnSecondYRight;
        private System.Windows.Forms.Button btnSecondXDown;
        private System.Windows.Forms.Button btnThirdXDown;
    }
}