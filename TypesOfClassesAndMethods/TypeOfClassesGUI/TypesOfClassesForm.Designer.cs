namespace TypeOfClassesGUI
{
    partial class TypesOfClassesForm
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
            this.aboutButton = new System.Windows.Forms.Button();
            this.baseClassButton = new System.Windows.Forms.Button();
            this.staticClassButton = new System.Windows.Forms.Button();
            this.derivedClassButton = new System.Windows.Forms.Button();
            this.sealedClassButton = new System.Windows.Forms.Button();
            this.abstractImpleButton = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.definitionLabel = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutButton
            // 
            this.aboutButton.Location = new System.Drawing.Point(38, 69);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(93, 38);
            this.aboutButton.TabIndex = 0;
            this.aboutButton.Text = "&About";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // baseClassButton
            // 
            this.baseClassButton.Location = new System.Drawing.Point(137, 69);
            this.baseClassButton.Name = "baseClassButton";
            this.baseClassButton.Size = new System.Drawing.Size(124, 38);
            this.baseClassButton.TabIndex = 0;
            this.baseClassButton.Text = "Base Class";
            this.baseClassButton.UseVisualStyleBackColor = true;
            this.baseClassButton.Click += new System.EventHandler(this.baseClassButton_Click);
            // 
            // staticClassButton
            // 
            this.staticClassButton.Location = new System.Drawing.Point(267, 69);
            this.staticClassButton.Name = "staticClassButton";
            this.staticClassButton.Size = new System.Drawing.Size(116, 38);
            this.staticClassButton.TabIndex = 0;
            this.staticClassButton.Text = "Static Class";
            this.staticClassButton.UseVisualStyleBackColor = true;
            this.staticClassButton.Click += new System.EventHandler(this.staticClassButton_Click);
            // 
            // derivedClassButton
            // 
            this.derivedClassButton.Location = new System.Drawing.Point(402, 69);
            this.derivedClassButton.Name = "derivedClassButton";
            this.derivedClassButton.Size = new System.Drawing.Size(121, 38);
            this.derivedClassButton.TabIndex = 0;
            this.derivedClassButton.Text = "Derived Class";
            this.derivedClassButton.UseVisualStyleBackColor = true;
            this.derivedClassButton.Click += new System.EventHandler(this.derivedClassButton_Click);
            // 
            // sealedClassButton
            // 
            this.sealedClassButton.Location = new System.Drawing.Point(545, 69);
            this.sealedClassButton.Name = "sealedClassButton";
            this.sealedClassButton.Size = new System.Drawing.Size(113, 38);
            this.sealedClassButton.TabIndex = 0;
            this.sealedClassButton.Text = "Sealed Class";
            this.sealedClassButton.UseVisualStyleBackColor = true;
            this.sealedClassButton.Click += new System.EventHandler(this.sealedClassButton_Click);
            // 
            // abstractImpleButton
            // 
            this.abstractImpleButton.Location = new System.Drawing.Point(677, 69);
            this.abstractImpleButton.Name = "abstractImpleButton";
            this.abstractImpleButton.Size = new System.Drawing.Size(143, 38);
            this.abstractImpleButton.TabIndex = 0;
            this.abstractImpleButton.Text = "Abstract Imple";
            this.abstractImpleButton.UseVisualStyleBackColor = true;
            this.abstractImpleButton.Click += new System.EventHandler(this.abstractImpleButton_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(845, 69);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(93, 38);
            this.button7.TabIndex = 0;
            this.button7.Text = "button1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(845, 69);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(93, 38);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // definitionLabel
            // 
            this.definitionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.definitionLabel.Location = new System.Drawing.Point(50, 147);
            this.definitionLabel.Name = "definitionLabel";
            this.definitionLabel.Size = new System.Drawing.Size(887, 108);
            this.definitionLabel.TabIndex = 1;
            // 
            // resultLabel
            // 
            this.resultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultLabel.Location = new System.Drawing.Point(50, 281);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(887, 155);
            this.resultLabel.TabIndex = 1;
            // 
            // TypesOfClassesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 503);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.definitionLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.abstractImpleButton);
            this.Controls.Add(this.sealedClassButton);
            this.Controls.Add(this.derivedClassButton);
            this.Controls.Add(this.staticClassButton);
            this.Controls.Add(this.baseClassButton);
            this.Controls.Add(this.aboutButton);
            this.Name = "TypesOfClassesForm";
            this.Text = "TypesOfClassesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button baseClassButton;
        private System.Windows.Forms.Button staticClassButton;
        private System.Windows.Forms.Button derivedClassButton;
        private System.Windows.Forms.Button sealedClassButton;
        private System.Windows.Forms.Button abstractImpleButton;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label definitionLabel;
        private System.Windows.Forms.Label resultLabel;
    }
}

