namespace Activity_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clickMe = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clickNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clickMe
            // 
            this.clickMe.Location = new System.Drawing.Point(364, 259);
            this.clickMe.Name = "clickMe";
            this.clickMe.Size = new System.Drawing.Size(75, 23);
            this.clickMe.TabIndex = 0;
            this.clickMe.Text = "Click Me";
            this.clickMe.UseVisualStyleBackColor = true;
            this.clickMe.Click += new System.EventHandler(this.clickMe_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(167)))), ((int)(((byte)(154)))));
            this.label1.Location = new System.Drawing.Point(351, 341);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // clickNext
            // 
            this.clickNext.Location = new System.Drawing.Point(351, 288);
            this.clickNext.Name = "clickNext";
            this.clickNext.Size = new System.Drawing.Size(102, 23);
            this.clickNext.TabIndex = 2;
            this.clickNext.Text = "Click me next";
            this.clickNext.UseVisualStyleBackColor = true;
            this.clickNext.Click += new System.EventHandler(this.clickNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(18)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clickNext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clickMe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clickMe;
        private Label label1;
        private Button clickNext;
    }
}