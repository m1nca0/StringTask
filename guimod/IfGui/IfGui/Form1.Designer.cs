namespace IfGui
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
            first = new TextBox();
            second = new TextBox();
            third = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // first
            // 
            first.Location = new Point(12, 42);
            first.Name = "first";
            first.Size = new Size(100, 23);
            first.TabIndex = 0;
            // 
            // second
            // 
            second.Location = new Point(118, 42);
            second.Name = "second";
            second.Size = new Size(100, 23);
            second.TabIndex = 1;
            // 
            // third
            // 
            third.Location = new Point(224, 42);
            third.Name = "third";
            third.Size = new Size(100, 23);
            third.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 3;
            label1.Text = "1 число";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 24);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 4;
            label2.Text = "2 число";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 24);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "3 число";
            // 
            // button1
            // 
            button1.Location = new Point(12, 71);
            button1.Name = "button1";
            button1.Size = new Size(312, 23);
            button1.TabIndex = 6;
            button1.Text = "Найти произведение меньших";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 102);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(third);
            Controls.Add(second);
            Controls.Add(first);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox first;
        private TextBox second;
        private TextBox third;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}
