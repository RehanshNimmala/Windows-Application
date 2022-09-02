namespace WeightWatchers
{
    partial class WeightWatchers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.activityComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.durationTextBox = new System.Windows.Forms.TextBox();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.caloriesBurntLabel = new System.Windows.Forms.Label();
            this.caloriesListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Watch your Calories";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Activity";
            // 
            // activityComboBox
            // 
            this.activityComboBox.BackColor = System.Drawing.Color.White;
            this.activityComboBox.FormattingEnabled = true;
            this.activityComboBox.Items.AddRange(new object[] {
            "Yoga",
            "Walking ",
            "Dancing, Ballroom",
            "Swimmimg",
            "Shoveling Snow",
            "Tennis",
            "Jogging",
            "BiCycling",
            "Running"});
            this.activityComboBox.Location = new System.Drawing.Point(213, 124);
            this.activityComboBox.Name = "activityComboBox";
            this.activityComboBox.Size = new System.Drawing.Size(121, 24);
            this.activityComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Duration (Mins)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Weight(Pounds)";
            // 
            // durationTextBox
            // 
            this.durationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.durationTextBox.Location = new System.Drawing.Point(213, 182);
            this.durationTextBox.Name = "durationTextBox";
            this.durationTextBox.Size = new System.Drawing.Size(121, 22);
            this.durationTextBox.TabIndex = 5;
            // 
            // weightTextBox
            // 
            this.weightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weightTextBox.Location = new System.Drawing.Point(213, 257);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(121, 22);
            this.weightTextBox.TabIndex = 6;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(66, 438);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(182, 68);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(422, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(182, 68);
            this.exitButton.TabIndex = 8;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Calories Burnt";
            // 
            // caloriesBurntLabel
            // 
            this.caloriesBurntLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.caloriesBurntLabel.Location = new System.Drawing.Point(213, 351);
            this.caloriesBurntLabel.Name = "caloriesBurntLabel";
            this.caloriesBurntLabel.Size = new System.Drawing.Size(474, 59);
            this.caloriesBurntLabel.TabIndex = 10;
            // 
            // caloriesListBox
            // 
            this.caloriesListBox.FormattingEnabled = true;
            this.caloriesListBox.ItemHeight = 16;
            this.caloriesListBox.Location = new System.Drawing.Point(378, 117);
            this.caloriesListBox.Name = "caloriesListBox";
            this.caloriesListBox.Size = new System.Drawing.Size(410, 212);
            this.caloriesListBox.TabIndex = 11;
            // 
            // WeightWatchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.caloriesListBox);
            this.Controls.Add(this.caloriesBurntLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.durationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.activityComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "WeightWatchers";
            this.Text = "Weight Watchers";
            this.Load += new System.EventHandler(this.WeightWatchers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox activityComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox durationTextBox;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label caloriesBurntLabel;
        private System.Windows.Forms.ListBox caloriesListBox;
    }
}

