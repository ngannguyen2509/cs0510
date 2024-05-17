namespace cs0510
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
            mybutton = new Button();
            SuspendLayout();
            // 
            // mybutton
            // 
            mybutton.BackColor = SystemColors.MenuHighlight;
            mybutton.Location = new Point(305, 87);
            mybutton.Name = "mybutton";
            mybutton.Size = new Size(222, 137);
            mybutton.TabIndex = 0;
            mybutton.Text = "button1";
            mybutton.UseVisualStyleBackColor = false;
            mybutton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mybutton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button mybutton;
    }
}