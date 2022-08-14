namespace LinkURL
{
    partial class form
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
            this.btnCars = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCars
            // 
            this.btnCars.Location = new System.Drawing.Point(45, 42);
            this.btnCars.Name = "btnCars";
            this.btnCars.Size = new System.Drawing.Size(75, 23);
            this.btnCars.TabIndex = 0;
            this.btnCars.Text = "Cars";
            this.btnCars.UseVisualStyleBackColor = true;
            this.btnCars.Click += new System.EventHandler(this.btnCars_Click);
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCars);
            this.Name = "form";
            this.Text = "URL Linking";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCars;
    }
}

