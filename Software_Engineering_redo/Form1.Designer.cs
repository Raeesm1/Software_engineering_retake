namespace Software_Engineering_redo
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
            this.single_line = new System.Windows.Forms.TextBox();
            this.multi_line = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.run_button = new System.Windows.Forms.Button();
            this.syntax_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // single_line
            // 
            this.single_line.Location = new System.Drawing.Point(29, 462);
            this.single_line.Name = "single_line";
            this.single_line.Size = new System.Drawing.Size(552, 26);
            this.single_line.TabIndex = 0;
            // 
            // multi_line
            // 
            this.multi_line.Location = new System.Drawing.Point(29, 35);
            this.multi_line.Multiline = true;
            this.multi_line.Name = "multi_line";
            this.multi_line.Size = new System.Drawing.Size(552, 385);
            this.multi_line.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(819, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 385);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // run_button
            // 
            this.run_button.Location = new System.Drawing.Point(833, 464);
            this.run_button.Name = "run_button";
            this.run_button.Size = new System.Drawing.Size(158, 45);
            this.run_button.TabIndex = 3;
            this.run_button.Text = "Run";
            this.run_button.UseVisualStyleBackColor = true;
            // 
            // syntax_button
            // 
            this.syntax_button.Location = new System.Drawing.Point(1088, 464);
            this.syntax_button.Name = "syntax_button";
            this.syntax_button.Size = new System.Drawing.Size(158, 45);
            this.syntax_button.TabIndex = 4;
            this.syntax_button.Text = "syntax";
            this.syntax_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1450, 600);
            this.Controls.Add(this.syntax_button);
            this.Controls.Add(this.run_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.multi_line);
            this.Controls.Add(this.single_line);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox single_line;
        private System.Windows.Forms.TextBox multi_line;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button run_button;
        private System.Windows.Forms.Button syntax_button;
    }
}

