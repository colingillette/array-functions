namespace ArrayFunctions
{
    partial class Form1
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
            this.firstButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.insertButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(21, 93);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(93, 40);
            this.firstButton.TabIndex = 0;
            this.firstButton.Text = "First Index Of";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(155, 93);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(93, 40);
            this.reverseButton.TabIndex = 1;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.reverseButton_Click);
            // 
            // insertButton
            // 
            this.insertButton.Location = new System.Drawing.Point(290, 93);
            this.insertButton.Name = "insertButton";
            this.insertButton.Size = new System.Drawing.Size(93, 40);
            this.insertButton.TabIndex = 2;
            this.insertButton.Text = "Insert";
            this.insertButton.UseVisualStyleBackColor = true;
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 198);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.firstButton);
            this.Name = "Form1";
            this.Text = "Array Functions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button insertButton;
    }
}

