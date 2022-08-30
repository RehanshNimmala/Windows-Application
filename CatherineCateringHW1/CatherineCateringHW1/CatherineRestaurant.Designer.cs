namespace CatherineCateringHW1
{
    partial class CatherineRestaurant
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
            this.catherineLabel = new System.Windows.Forms.Label();
            this.numberofGuestsLabel = new System.Windows.Forms.Label();
            this.numberofGuestsTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pastaRadioButton = new System.Windows.Forms.RadioButton();
            this.chickenRadioButton = new System.Windows.Forms.RadioButton();
            this.primeribRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxOpenBar = new System.Windows.Forms.CheckBox();
            this.checkBoxWine = new System.Windows.Forms.CheckBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.preTaxTip = new System.Windows.Forms.Label();
            this.amountDueLabel = new System.Windows.Forms.Label();
            this.totalGuestsLabel = new System.Windows.Forms.Label();
            this.totalAmountDue = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // catherineLabel
            // 
            this.catherineLabel.Location = new System.Drawing.Point(214, 9);
            this.catherineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.catherineLabel.Name = "catherineLabel";
            this.catherineLabel.Size = new System.Drawing.Size(315, 66);
            this.catherineLabel.TabIndex = 0;
            this.catherineLabel.Text = "Catherine\'s Catering";
            // 
            // numberofGuestsLabel
            // 
            this.numberofGuestsLabel.AutoSize = true;
            this.numberofGuestsLabel.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberofGuestsLabel.Location = new System.Drawing.Point(42, 56);
            this.numberofGuestsLabel.Name = "numberofGuestsLabel";
            this.numberofGuestsLabel.Size = new System.Drawing.Size(134, 19);
            this.numberofGuestsLabel.TabIndex = 1;
            this.numberofGuestsLabel.Text = "Number of Guests";
            // 
            // numberofGuestsTextBox
            // 
            this.numberofGuestsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numberofGuestsTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.numberofGuestsTextBox.Location = new System.Drawing.Point(242, 56);
            this.numberofGuestsTextBox.Name = "numberofGuestsTextBox";
            this.numberofGuestsTextBox.Size = new System.Drawing.Size(100, 30);
            this.numberofGuestsTextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pastaRadioButton);
            this.groupBox1.Controls.Add(this.chickenRadioButton);
            this.groupBox1.Controls.Add(this.primeribRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(46, 120);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 135);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // pastaRadioButton
            // 
            this.pastaRadioButton.AutoSize = true;
            this.pastaRadioButton.Location = new System.Drawing.Point(6, 94);
            this.pastaRadioButton.Name = "pastaRadioButton";
            this.pastaRadioButton.Size = new System.Drawing.Size(73, 26);
            this.pastaRadioButton.TabIndex = 2;
            this.pastaRadioButton.TabStop = true;
            this.pastaRadioButton.Text = "Pasta";
            this.pastaRadioButton.UseVisualStyleBackColor = true;
            // 
            // chickenRadioButton
            // 
            this.chickenRadioButton.AutoSize = true;
            this.chickenRadioButton.Location = new System.Drawing.Point(6, 62);
            this.chickenRadioButton.Name = "chickenRadioButton";
            this.chickenRadioButton.Size = new System.Drawing.Size(95, 26);
            this.chickenRadioButton.TabIndex = 1;
            this.chickenRadioButton.TabStop = true;
            this.chickenRadioButton.Text = "Chicken";
            this.chickenRadioButton.UseVisualStyleBackColor = true;
            // 
            // primeribRadioButton
            // 
            this.primeribRadioButton.AutoSize = true;
            this.primeribRadioButton.Location = new System.Drawing.Point(6, 28);
            this.primeribRadioButton.Name = "primeribRadioButton";
            this.primeribRadioButton.Size = new System.Drawing.Size(112, 26);
            this.primeribRadioButton.TabIndex = 0;
            this.primeribRadioButton.TabStop = true;
            this.primeribRadioButton.Text = "Prime Rib";
            this.primeribRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxWine);
            this.groupBox2.Controls.Add(this.checkBoxOpenBar);
            this.groupBox2.Location = new System.Drawing.Point(394, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 135);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bar";
            // 
            // checkBoxOpenBar
            // 
            this.checkBoxOpenBar.AutoSize = true;
            this.checkBoxOpenBar.Location = new System.Drawing.Point(6, 29);
            this.checkBoxOpenBar.Name = "checkBoxOpenBar";
            this.checkBoxOpenBar.Size = new System.Drawing.Size(108, 26);
            this.checkBoxOpenBar.TabIndex = 0;
            this.checkBoxOpenBar.Text = "Open Bar";
            this.checkBoxOpenBar.UseVisualStyleBackColor = true;
            // 
            // checkBoxWine
            // 
            this.checkBoxWine.AutoSize = true;
            this.checkBoxWine.Location = new System.Drawing.Point(7, 62);
            this.checkBoxWine.Name = "checkBoxWine";
            this.checkBoxWine.Size = new System.Drawing.Size(73, 26);
            this.checkBoxWine.TabIndex = 1;
            this.checkBoxWine.Text = "Wine";
            this.checkBoxWine.UseVisualStyleBackColor = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(46, 279);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(118, 36);
            this.calculateButton.TabIndex = 5;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(242, 279);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(106, 36);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(444, 280);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(121, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Suggested Tip(20% pre-tax):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 22);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount Due(Including Tax):";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalAmountDue);
            this.groupBox3.Controls.Add(this.totalGuestsLabel);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(46, 437);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(538, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total Number of Guests";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Amount Due:";
            // 
            // preTaxTip
            // 
            this.preTaxTip.AutoSize = true;
            this.preTaxTip.Location = new System.Drawing.Point(288, 350);
            this.preTaxTip.Name = "preTaxTip";
            this.preTaxTip.Size = new System.Drawing.Size(0, 22);
            this.preTaxTip.TabIndex = 11;
            // 
            // amountDueLabel
            // 
            this.amountDueLabel.AutoSize = true;
            this.amountDueLabel.Location = new System.Drawing.Point(284, 389);
            this.amountDueLabel.Name = "amountDueLabel";
            this.amountDueLabel.Size = new System.Drawing.Size(0, 22);
            this.amountDueLabel.TabIndex = 12;
            // 
            // totalGuestsLabel
            // 
            this.totalGuestsLabel.AutoSize = true;
            this.totalGuestsLabel.Location = new System.Drawing.Point(223, 35);
            this.totalGuestsLabel.Name = "totalGuestsLabel";
            this.totalGuestsLabel.Size = new System.Drawing.Size(0, 22);
            this.totalGuestsLabel.TabIndex = 2;
            // 
            // totalAmountDue
            // 
            this.totalAmountDue.AutoSize = true;
            this.totalAmountDue.Location = new System.Drawing.Point(172, 70);
            this.totalAmountDue.Name = "totalAmountDue";
            this.totalAmountDue.Size = new System.Drawing.Size(0, 22);
            this.totalAmountDue.TabIndex = 3;
            // 
            // CatherineRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 551);
            this.Controls.Add(this.amountDueLabel);
            this.Controls.Add(this.preTaxTip);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numberofGuestsTextBox);
            this.Controls.Add(this.numberofGuestsLabel);
            this.Controls.Add(this.catherineLabel);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CatherineRestaurant";
            this.ShowIcon = false;
            this.Text = "Catherine \'s Catering";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label catherineLabel;
        private System.Windows.Forms.Label numberofGuestsLabel;
        private System.Windows.Forms.TextBox numberofGuestsTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton pastaRadioButton;
        private System.Windows.Forms.RadioButton chickenRadioButton;
        private System.Windows.Forms.RadioButton primeribRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxWine;
        private System.Windows.Forms.CheckBox checkBoxOpenBar;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label totalAmountDue;
        private System.Windows.Forms.Label totalGuestsLabel;
        private System.Windows.Forms.Label preTaxTip;
        private System.Windows.Forms.Label amountDueLabel;
    }
}

