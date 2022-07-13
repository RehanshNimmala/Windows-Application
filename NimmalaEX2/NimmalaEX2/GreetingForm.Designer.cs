
namespace NimmalaEX2
{
    partial class GreetingForm
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnDisplayGreeting = new System.Windows.Forms.Button();
            this.btnResetGreeting = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreeting.Location = new System.Drawing.Point(278, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(100, 23);
            this.lblGreeting.TabIndex = 0;
            // 
            // btnDisplayGreeting
            // 
            this.btnDisplayGreeting.Location = new System.Drawing.Point(125, 131);
            this.btnDisplayGreeting.Name = "btnDisplayGreeting";
            this.btnDisplayGreeting.Size = new System.Drawing.Size(151, 35);
            this.btnDisplayGreeting.TabIndex = 1;
            this.btnDisplayGreeting.Text = "Display Greeting";
            this.btnDisplayGreeting.UseVisualStyleBackColor = true;
            this.btnDisplayGreeting.Click += new System.EventHandler(this.btnDisplayGreeting_Click);
            // 
            // btnResetGreeting
            // 
            this.btnResetGreeting.Location = new System.Drawing.Point(384, 131);
            this.btnResetGreeting.Name = "btnResetGreeting";
            this.btnResetGreeting.Size = new System.Drawing.Size(132, 35);
            this.btnResetGreeting.TabIndex = 2;
            this.btnResetGreeting.Text = "Reset Greeting";
            this.btnResetGreeting.UseVisualStyleBackColor = true;
            this.btnResetGreeting.Click += new System.EventHandler(this.btnResetGreeting_Click);
            // 
            // GreetingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 244);
            this.Controls.Add(this.btnResetGreeting);
            this.Controls.Add(this.btnDisplayGreeting);
            this.Controls.Add(this.lblGreeting);
            this.Name = "GreetingForm";
            this.Text = "Greeting Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnDisplayGreeting;
        private System.Windows.Forms.Button btnResetGreeting;
    }
}

