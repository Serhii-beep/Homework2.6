namespace HM_Geometry3
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpIsosceles = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbPerimeter = new System.Windows.Forms.TextBox();
            this.lblAngle = new System.Windows.Forms.Label();
            this.lblSide2 = new System.Windows.Forms.Label();
            this.lblSide1 = new System.Windows.Forms.Label();
            this.tbAngle = new System.Windows.Forms.TextBox();
            this.tbSide2 = new System.Windows.Forms.TextBox();
            this.tbSide1 = new System.Windows.Forms.TextBox();
            this.tpRightTriangle = new System.Windows.Forms.TabPage();
            this.btnClearRightTriangle = new System.Windows.Forms.Button();
            this.btnComputeRightTriangle = new System.Windows.Forms.Button();
            this.lblAreaRightTriangle = new System.Windows.Forms.Label();
            this.lblPerimeterRightTriangle = new System.Windows.Forms.Label();
            this.lblAngleRightTriangle = new System.Windows.Forms.Label();
            this.lblSide2RightTriangle = new System.Windows.Forms.Label();
            this.lblSide1RightTriangle = new System.Windows.Forms.Label();
            this.tbAreaRightTriangle = new System.Windows.Forms.TextBox();
            this.tbPerimeterRightTriangle = new System.Windows.Forms.TextBox();
            this.tbAngleRightTriangle = new System.Windows.Forms.TextBox();
            this.tbSide2RightTriangle = new System.Windows.Forms.TextBox();
            this.tbSide1RightTriangle = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tpIsosceles.SuspendLayout();
            this.tpRightTriangle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpIsosceles);
            this.tabControl1.Controls.Add(this.tpRightTriangle);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpIsosceles
            // 
            this.tpIsosceles.Controls.Add(this.btnClear);
            this.tpIsosceles.Controls.Add(this.btnCompute);
            this.tpIsosceles.Controls.Add(this.lblArea);
            this.tpIsosceles.Controls.Add(this.lblPerimeter);
            this.tpIsosceles.Controls.Add(this.tbArea);
            this.tpIsosceles.Controls.Add(this.tbPerimeter);
            this.tpIsosceles.Controls.Add(this.lblAngle);
            this.tpIsosceles.Controls.Add(this.lblSide2);
            this.tpIsosceles.Controls.Add(this.lblSide1);
            this.tpIsosceles.Controls.Add(this.tbAngle);
            this.tpIsosceles.Controls.Add(this.tbSide2);
            this.tpIsosceles.Controls.Add(this.tbSide1);
            this.tpIsosceles.Location = new System.Drawing.Point(4, 29);
            this.tpIsosceles.Name = "tpIsosceles";
            this.tpIsosceles.Padding = new System.Windows.Forms.Padding(3);
            this.tpIsosceles.Size = new System.Drawing.Size(768, 393);
            this.tpIsosceles.TabIndex = 0;
            this.tpIsosceles.Text = "Рівнобедренний трикутник";
            this.tpIsosceles.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(582, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 76);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCompute
            // 
            this.btnCompute.Location = new System.Drawing.Point(4, 314);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(157, 76);
            this.btnCompute.TabIndex = 10;
            this.btnCompute.Text = "Розрахувати";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(582, 83);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(57, 20);
            this.lblArea.TabIndex = 9;
            this.lblArea.Text = "Площа";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(582, 16);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeter.TabIndex = 8;
            this.lblPerimeter.Text = "Периметр";
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(435, 86);
            this.tbArea.Name = "tbArea";
            this.tbArea.ReadOnly = true;
            this.tbArea.Size = new System.Drawing.Size(125, 27);
            this.tbArea.TabIndex = 7;
            // 
            // tbPerimeter
            // 
            this.tbPerimeter.Location = new System.Drawing.Point(435, 19);
            this.tbPerimeter.Name = "tbPerimeter";
            this.tbPerimeter.ReadOnly = true;
            this.tbPerimeter.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeter.TabIndex = 6;
            // 
            // lblAngle
            // 
            this.lblAngle.AutoSize = true;
            this.lblAngle.Location = new System.Drawing.Point(192, 177);
            this.lblAngle.Name = "lblAngle";
            this.lblAngle.Size = new System.Drawing.Size(225, 20);
            this.lblAngle.TabIndex = 5;
            this.lblAngle.Text = "Кут між сторонами(в радіанах)";
            // 
            // lblSide2
            // 
            this.lblSide2.AutoSize = true;
            this.lblSide2.Location = new System.Drawing.Point(192, 101);
            this.lblSide2.Name = "lblSide2";
            this.lblSide2.Size = new System.Drawing.Size(110, 20);
            this.lblSide2.TabIndex = 4;
            this.lblSide2.Text = "Друга сторона";
            // 
            // lblSide1
            // 
            this.lblSide1.AutoSize = true;
            this.lblSide1.Location = new System.Drawing.Point(192, 24);
            this.lblSide1.Name = "lblSide1";
            this.lblSide1.Size = new System.Drawing.Size(118, 20);
            this.lblSide1.TabIndex = 3;
            this.lblSide1.Text = "Перша сторона";
            // 
            // tbAngle
            // 
            this.tbAngle.Location = new System.Drawing.Point(36, 177);
            this.tbAngle.Name = "tbAngle";
            this.tbAngle.Size = new System.Drawing.Size(125, 27);
            this.tbAngle.TabIndex = 2;
            // 
            // tbSide2
            // 
            this.tbSide2.Location = new System.Drawing.Point(36, 101);
            this.tbSide2.Name = "tbSide2";
            this.tbSide2.Size = new System.Drawing.Size(125, 27);
            this.tbSide2.TabIndex = 1;
            // 
            // tbSide1
            // 
            this.tbSide1.Location = new System.Drawing.Point(36, 27);
            this.tbSide1.Name = "tbSide1";
            this.tbSide1.Size = new System.Drawing.Size(125, 27);
            this.tbSide1.TabIndex = 0;
            // 
            // tpRightTriangle
            // 
            this.tpRightTriangle.Controls.Add(this.btnClearRightTriangle);
            this.tpRightTriangle.Controls.Add(this.btnComputeRightTriangle);
            this.tpRightTriangle.Controls.Add(this.lblAreaRightTriangle);
            this.tpRightTriangle.Controls.Add(this.lblPerimeterRightTriangle);
            this.tpRightTriangle.Controls.Add(this.lblAngleRightTriangle);
            this.tpRightTriangle.Controls.Add(this.lblSide2RightTriangle);
            this.tpRightTriangle.Controls.Add(this.lblSide1RightTriangle);
            this.tpRightTriangle.Controls.Add(this.tbAreaRightTriangle);
            this.tpRightTriangle.Controls.Add(this.tbPerimeterRightTriangle);
            this.tpRightTriangle.Controls.Add(this.tbAngleRightTriangle);
            this.tpRightTriangle.Controls.Add(this.tbSide2RightTriangle);
            this.tpRightTriangle.Controls.Add(this.tbSide1RightTriangle);
            this.tpRightTriangle.Location = new System.Drawing.Point(4, 29);
            this.tpRightTriangle.Name = "tpRightTriangle";
            this.tpRightTriangle.Padding = new System.Windows.Forms.Padding(3);
            this.tpRightTriangle.Size = new System.Drawing.Size(768, 393);
            this.tpRightTriangle.TabIndex = 1;
            this.tpRightTriangle.Text = "Прямокутний трикутник";
            this.tpRightTriangle.UseVisualStyleBackColor = true;
            // 
            // btnClearRightTriangle
            // 
            this.btnClearRightTriangle.Location = new System.Drawing.Point(599, 322);
            this.btnClearRightTriangle.Name = "btnClearRightTriangle";
            this.btnClearRightTriangle.Size = new System.Drawing.Size(166, 68);
            this.btnClearRightTriangle.TabIndex = 11;
            this.btnClearRightTriangle.Text = "Очистити";
            this.btnClearRightTriangle.UseVisualStyleBackColor = true;
            this.btnClearRightTriangle.Click += new System.EventHandler(this.btnClearRightTriangle_Click);
            // 
            // btnComputeRightTriangle
            // 
            this.btnComputeRightTriangle.Location = new System.Drawing.Point(4, 322);
            this.btnComputeRightTriangle.Name = "btnComputeRightTriangle";
            this.btnComputeRightTriangle.Size = new System.Drawing.Size(153, 68);
            this.btnComputeRightTriangle.TabIndex = 10;
            this.btnComputeRightTriangle.Text = "Розрахувати";
            this.btnComputeRightTriangle.UseVisualStyleBackColor = true;
            this.btnComputeRightTriangle.Click += new System.EventHandler(this.btnComputeRightTriangle_Click);
            // 
            // lblAreaRightTriangle
            // 
            this.lblAreaRightTriangle.AutoSize = true;
            this.lblAreaRightTriangle.Location = new System.Drawing.Point(610, 83);
            this.lblAreaRightTriangle.Name = "lblAreaRightTriangle";
            this.lblAreaRightTriangle.Size = new System.Drawing.Size(57, 20);
            this.lblAreaRightTriangle.TabIndex = 9;
            this.lblAreaRightTriangle.Text = "Площа";
            // 
            // lblPerimeterRightTriangle
            // 
            this.lblPerimeterRightTriangle.AutoSize = true;
            this.lblPerimeterRightTriangle.Location = new System.Drawing.Point(610, 29);
            this.lblPerimeterRightTriangle.Name = "lblPerimeterRightTriangle";
            this.lblPerimeterRightTriangle.Size = new System.Drawing.Size(80, 20);
            this.lblPerimeterRightTriangle.TabIndex = 8;
            this.lblPerimeterRightTriangle.Text = "Периметр";
            // 
            // lblAngleRightTriangle
            // 
            this.lblAngleRightTriangle.AutoSize = true;
            this.lblAngleRightTriangle.Location = new System.Drawing.Point(238, 142);
            this.lblAngleRightTriangle.Name = "lblAngleRightTriangle";
            this.lblAngleRightTriangle.Size = new System.Drawing.Size(225, 20);
            this.lblAngleRightTriangle.TabIndex = 7;
            this.lblAngleRightTriangle.Text = "Кут між сторонами(в радіанах)";
            // 
            // lblSide2RightTriangle
            // 
            this.lblSide2RightTriangle.AutoSize = true;
            this.lblSide2RightTriangle.Location = new System.Drawing.Point(238, 83);
            this.lblSide2RightTriangle.Name = "lblSide2RightTriangle";
            this.lblSide2RightTriangle.Size = new System.Drawing.Size(110, 20);
            this.lblSide2RightTriangle.TabIndex = 6;
            this.lblSide2RightTriangle.Text = "Друга сторона";
            // 
            // lblSide1RightTriangle
            // 
            this.lblSide1RightTriangle.AutoSize = true;
            this.lblSide1RightTriangle.Location = new System.Drawing.Point(238, 29);
            this.lblSide1RightTriangle.Name = "lblSide1RightTriangle";
            this.lblSide1RightTriangle.Size = new System.Drawing.Size(118, 20);
            this.lblSide1RightTriangle.TabIndex = 5;
            this.lblSide1RightTriangle.Text = "Перша сторона";
            // 
            // tbAreaRightTriangle
            // 
            this.tbAreaRightTriangle.Location = new System.Drawing.Point(458, 78);
            this.tbAreaRightTriangle.Name = "tbAreaRightTriangle";
            this.tbAreaRightTriangle.ReadOnly = true;
            this.tbAreaRightTriangle.Size = new System.Drawing.Size(125, 27);
            this.tbAreaRightTriangle.TabIndex = 4;
            // 
            // tbPerimeterRightTriangle
            // 
            this.tbPerimeterRightTriangle.Location = new System.Drawing.Point(458, 24);
            this.tbPerimeterRightTriangle.Name = "tbPerimeterRightTriangle";
            this.tbPerimeterRightTriangle.ReadOnly = true;
            this.tbPerimeterRightTriangle.Size = new System.Drawing.Size(125, 27);
            this.tbPerimeterRightTriangle.TabIndex = 3;
            // 
            // tbAngleRightTriangle
            // 
            this.tbAngleRightTriangle.Location = new System.Drawing.Point(78, 145);
            this.tbAngleRightTriangle.Name = "tbAngleRightTriangle";
            this.tbAngleRightTriangle.Size = new System.Drawing.Size(125, 27);
            this.tbAngleRightTriangle.TabIndex = 2;
            // 
            // tbSide2RightTriangle
            // 
            this.tbSide2RightTriangle.Location = new System.Drawing.Point(78, 86);
            this.tbSide2RightTriangle.Name = "tbSide2RightTriangle";
            this.tbSide2RightTriangle.Size = new System.Drawing.Size(125, 27);
            this.tbSide2RightTriangle.TabIndex = 1;
            // 
            // tbSide1RightTriangle
            // 
            this.tbSide1RightTriangle.Location = new System.Drawing.Point(78, 32);
            this.tbSide1RightTriangle.Name = "tbSide1RightTriangle";
            this.tbSide1RightTriangle.Size = new System.Drawing.Size(125, 27);
            this.tbSide1RightTriangle.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tpIsosceles.ResumeLayout(false);
            this.tpIsosceles.PerformLayout();
            this.tpRightTriangle.ResumeLayout(false);
            this.tpRightTriangle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpIsosceles;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbPerimeter;
        private System.Windows.Forms.Label lblAngle;
        private System.Windows.Forms.Label lblSide2;
        private System.Windows.Forms.Label lblSide1;
        private System.Windows.Forms.TextBox tbAngle;
        private System.Windows.Forms.TextBox tbSide2;
        private System.Windows.Forms.TextBox tbSide1;
        private System.Windows.Forms.TabPage tpRightTriangle;
        private System.Windows.Forms.Button btnClearRightTriangle;
        private System.Windows.Forms.Button btnComputeRightTriangle;
        private System.Windows.Forms.Label lblAreaRightTriangle;
        private System.Windows.Forms.Label lblPerimeterRightTriangle;
        private System.Windows.Forms.Label lblAngleRightTriangle;
        private System.Windows.Forms.Label lblSide2RightTriangle;
        private System.Windows.Forms.Label lblSide1RightTriangle;
        private System.Windows.Forms.TextBox tbAreaRightTriangle;
        private System.Windows.Forms.TextBox tbPerimeterRightTriangle;
        private System.Windows.Forms.TextBox tbAngleRightTriangle;
        private System.Windows.Forms.TextBox tbSide2RightTriangle;
        private System.Windows.Forms.TextBox tbSide1RightTriangle;
    }
}