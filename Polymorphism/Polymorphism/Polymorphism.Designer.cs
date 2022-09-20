namespace Polymorphism
{
    partial class Polymorphism
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
            this.shapeButton = new System.Windows.Forms.Button();
            this.circleButton = new System.Windows.Forms.Button();
            this.rectangleButton = new System.Windows.Forms.Button();
            this.upCastingButton = new System.Windows.Forms.Button();
            this.upCastingByAsmtButton = new System.Windows.Forms.Button();
            this.downCastingButton = new System.Windows.Forms.Button();
            this.okDownCastingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // shapeButton
            // 
            this.shapeButton.Location = new System.Drawing.Point(24, 53);
            this.shapeButton.Name = "shapeButton";
            this.shapeButton.Size = new System.Drawing.Size(94, 58);
            this.shapeButton.TabIndex = 0;
            this.shapeButton.Text = "Shape";
            this.shapeButton.UseVisualStyleBackColor = true;
            this.shapeButton.Click += new System.EventHandler(this.shapeButton_Click);
            // 
            // circleButton
            // 
            this.circleButton.Location = new System.Drawing.Point(154, 53);
            this.circleButton.Name = "circleButton";
            this.circleButton.Size = new System.Drawing.Size(94, 58);
            this.circleButton.TabIndex = 1;
            this.circleButton.Text = "Circle";
            this.circleButton.UseVisualStyleBackColor = true;
            this.circleButton.Click += new System.EventHandler(this.circleButton_Click);
            // 
            // rectangleButton
            // 
            this.rectangleButton.Location = new System.Drawing.Point(289, 53);
            this.rectangleButton.Name = "rectangleButton";
            this.rectangleButton.Size = new System.Drawing.Size(94, 58);
            this.rectangleButton.TabIndex = 2;
            this.rectangleButton.Text = "Rectangle";
            this.rectangleButton.UseVisualStyleBackColor = true;
            this.rectangleButton.Click += new System.EventHandler(this.rectangleButton_Click);
            // 
            // upCastingButton
            // 
            this.upCastingButton.Location = new System.Drawing.Point(436, 53);
            this.upCastingButton.Name = "upCastingButton";
            this.upCastingButton.Size = new System.Drawing.Size(94, 58);
            this.upCastingButton.TabIndex = 3;
            this.upCastingButton.Text = "Upcasting by Object Instantiation";
            this.upCastingButton.UseVisualStyleBackColor = true;
            this.upCastingButton.Click += new System.EventHandler(this.upCastingButton_Click);
            // 
            // upCastingByAsmtButton
            // 
            this.upCastingByAsmtButton.Location = new System.Drawing.Point(586, 53);
            this.upCastingByAsmtButton.Name = "upCastingByAsmtButton";
            this.upCastingByAsmtButton.Size = new System.Drawing.Size(94, 58);
            this.upCastingByAsmtButton.TabIndex = 4;
            this.upCastingByAsmtButton.Text = "Upcasting by Assignment";
            this.upCastingByAsmtButton.UseVisualStyleBackColor = true;
            this.upCastingByAsmtButton.Click += new System.EventHandler(this.upCastingByAsmtButton_Click);
            // 
            // downCastingButton
            // 
            this.downCastingButton.Location = new System.Drawing.Point(728, 53);
            this.downCastingButton.Name = "downCastingButton";
            this.downCastingButton.Size = new System.Drawing.Size(98, 58);
            this.downCastingButton.TabIndex = 5;
            this.downCastingButton.Text = "Down-Casting(How NOT to Downcast)";
            this.downCastingButton.UseVisualStyleBackColor = true;
            this.downCastingButton.Click += new System.EventHandler(this.downCastingButton_Click);
            // 
            // okDownCastingButton
            // 
            this.okDownCastingButton.Location = new System.Drawing.Point(868, 53);
            this.okDownCastingButton.Name = "okDownCastingButton";
            this.okDownCastingButton.Size = new System.Drawing.Size(99, 58);
            this.okDownCastingButton.TabIndex = 6;
            this.okDownCastingButton.Text = "Down Casting that is OK to do";
            this.okDownCastingButton.UseVisualStyleBackColor = true;
            this.okDownCastingButton.Click += new System.EventHandler(this.okDownCastingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1013, 53);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(94, 58);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Location = new System.Drawing.Point(44, 165);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultTextBox.Size = new System.Drawing.Size(1063, 273);
            this.resultTextBox.TabIndex = 8;
            // 
            // Polymorphism
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.okDownCastingButton);
            this.Controls.Add(this.downCastingButton);
            this.Controls.Add(this.upCastingByAsmtButton);
            this.Controls.Add(this.upCastingButton);
            this.Controls.Add(this.rectangleButton);
            this.Controls.Add(this.circleButton);
            this.Controls.Add(this.shapeButton);
            this.Name = "Polymorphism";
            this.Text = "Polymorphism";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button shapeButton;
        private System.Windows.Forms.Button circleButton;
        private System.Windows.Forms.Button rectangleButton;
        private System.Windows.Forms.Button upCastingButton;
        private System.Windows.Forms.Button upCastingByAsmtButton;
        private System.Windows.Forms.Button downCastingButton;
        private System.Windows.Forms.Button okDownCastingButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

