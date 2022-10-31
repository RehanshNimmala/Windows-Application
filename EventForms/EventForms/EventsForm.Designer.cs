namespace EventForms
{
    partial class EventsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.carComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.goButton = new System.Windows.Forms.Button();
            this.nabinCheckBox = new System.Windows.Forms.CheckBox();
            this.nawinCheckBox = new System.Windows.Forms.CheckBox();
            this.navinCheckBox = new System.Windows.Forms.CheckBox();
            this.naveenCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.newCarComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.carComboBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(67, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Events sample with just car dealer class";
            // 
            // carComboBox
            // 
            this.carComboBox.FormattingEnabled = true;
            this.carComboBox.Items.AddRange(new object[] {
            "Honda CR-V",
            "Acura MDX",
            "BMW",
            "Audi",
            "MBenz"});
            this.carComboBox.Location = new System.Drawing.Point(187, 34);
            this.carComboBox.Name = "carComboBox";
            this.carComboBox.Size = new System.Drawing.Size(155, 24);
            this.carComboBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select New Car";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.goButton);
            this.groupBox2.Controls.Add(this.nabinCheckBox);
            this.groupBox2.Controls.Add(this.nawinCheckBox);
            this.groupBox2.Controls.Add(this.navinCheckBox);
            this.groupBox2.Controls.Add(this.naveenCheckBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.newCarComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(67, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(378, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Events sample with car dealer class and Consumer class";
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(50, 299);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(123, 36);
            this.goButton.TabIndex = 2;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // nabinCheckBox
            // 
            this.nabinCheckBox.AutoSize = true;
            this.nabinCheckBox.Location = new System.Drawing.Point(50, 243);
            this.nabinCheckBox.Name = "nabinCheckBox";
            this.nabinCheckBox.Size = new System.Drawing.Size(65, 20);
            this.nabinCheckBox.TabIndex = 7;
            this.nabinCheckBox.Text = "Nabin";
            this.nabinCheckBox.UseVisualStyleBackColor = true;
            // 
            // nawinCheckBox
            // 
            this.nawinCheckBox.AutoSize = true;
            this.nawinCheckBox.Location = new System.Drawing.Point(50, 207);
            this.nawinCheckBox.Name = "nawinCheckBox";
            this.nawinCheckBox.Size = new System.Drawing.Size(66, 20);
            this.nawinCheckBox.TabIndex = 6;
            this.nawinCheckBox.Text = "Nawin";
            this.nawinCheckBox.UseVisualStyleBackColor = true;
            // 
            // navinCheckBox
            // 
            this.navinCheckBox.AutoSize = true;
            this.navinCheckBox.Location = new System.Drawing.Point(50, 169);
            this.navinCheckBox.Name = "navinCheckBox";
            this.navinCheckBox.Size = new System.Drawing.Size(64, 20);
            this.navinCheckBox.TabIndex = 5;
            this.navinCheckBox.Text = "Navin";
            this.navinCheckBox.UseVisualStyleBackColor = true;
            // 
            // naveenCheckBox
            // 
            this.naveenCheckBox.AutoSize = true;
            this.naveenCheckBox.Location = new System.Drawing.Point(50, 129);
            this.naveenCheckBox.Name = "naveenCheckBox";
            this.naveenCheckBox.Size = new System.Drawing.Size(77, 20);
            this.naveenCheckBox.TabIndex = 4;
            this.naveenCheckBox.Text = "Naveen";
            this.naveenCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subscribe Customer Name";
            // 
            // newCarComboBox
            // 
            this.newCarComboBox.FormattingEnabled = true;
            this.newCarComboBox.Items.AddRange(new object[] {
            "Honda CR-V",
            "Acura MDX",
            "BMW",
            "Audi",
            "MBenz"});
            this.newCarComboBox.Location = new System.Drawing.Point(187, 55);
            this.newCarComboBox.Name = "newCarComboBox";
            this.newCarComboBox.Size = new System.Drawing.Size(155, 24);
            this.newCarComboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select New Car";
            // 
            // EventsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 566);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "EventsForm";
            this.Text = "Events Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox carComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox nabinCheckBox;
        private System.Windows.Forms.CheckBox nawinCheckBox;
        private System.Windows.Forms.CheckBox navinCheckBox;
        private System.Windows.Forms.CheckBox naveenCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox newCarComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button goButton;
    }
}

