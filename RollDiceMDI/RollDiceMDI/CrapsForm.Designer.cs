namespace RollDiceMDI
{
    partial class CrapsForm
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
            this.die1 = new System.Windows.Forms.Label();
            this.die2 = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.pointLabel = new System.Windows.Forms.Label();
            this.die1Label = new System.Windows.Forms.Label();
            this.die2Label = new System.Windows.Forms.Label();
            this.rollButton = new System.Windows.Forms.Button();
            this.restartButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gamblers Paradise-Craps Created by Naveen";
            // 
            // die1
            // 
            this.die1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die1.Location = new System.Drawing.Point(59, 137);
            this.die1.Name = "die1";
            this.die1.Size = new System.Drawing.Size(69, 41);
            this.die1.TabIndex = 1;
            this.die1.Text = "Die 1";
            // 
            // die2
            // 
            this.die2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.die2.Location = new System.Drawing.Point(191, 137);
            this.die2.Name = "die2";
            this.die2.Size = new System.Drawing.Size(69, 41);
            this.die2.TabIndex = 2;
            this.die2.Text = "Die 2";
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(353, 201);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(404, 308);
            this.resultListBox.TabIndex = 3;
            // 
            // pointLabel
            // 
            this.pointLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pointLabel.Location = new System.Drawing.Point(353, 137);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(404, 41);
            this.pointLabel.TabIndex = 4;
            // 
            // die1Label
            // 
            this.die1Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die1Label.Location = new System.Drawing.Point(64, 178);
            this.die1Label.Name = "die1Label";
            this.die1Label.Size = new System.Drawing.Size(64, 63);
            this.die1Label.TabIndex = 5;
            // 
            // die2Label
            // 
            this.die2Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.die2Label.Location = new System.Drawing.Point(196, 178);
            this.die2Label.Name = "die2Label";
            this.die2Label.Size = new System.Drawing.Size(64, 63);
            this.die2Label.TabIndex = 6;
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(64, 280);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(221, 51);
            this.rollButton.TabIndex = 7;
            this.rollButton.Text = "&Come-Out Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // restartButton
            // 
            this.restartButton.Location = new System.Drawing.Point(64, 361);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(221, 51);
            this.restartButton.TabIndex = 8;
            this.restartButton.Text = "&Restart";
            this.restartButton.UseVisualStyleBackColor = true;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(64, 454);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(221, 51);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // CrapsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.rollButton);
            this.Controls.Add(this.die2Label);
            this.Controls.Add(this.die1Label);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.die2);
            this.Controls.Add(this.die1);
            this.Controls.Add(this.label1);
            this.Name = "CrapsForm";
            this.Text = "Craps";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label die1;
        private System.Windows.Forms.Label die2;
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label die1Label;
        private System.Windows.Forms.Label die2Label;
        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button exitButton;
    }
}

