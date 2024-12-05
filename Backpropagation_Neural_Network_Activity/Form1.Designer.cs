
namespace Backpropagation_Neural_Network_Activity
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 227);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(342, 23);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(182, 519);
            button1.Name = "button1";
            button1.Size = new Size(268, 71);
            button1.TabIndex = 3;
            button1.Text = "CreateBPNN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(556, 519);
            button2.Name = "button2";
            button2.Size = new Size(268, 71);
            button2.TabIndex = 4;
            button2.Text = "Train the neural net";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(945, 519);
            button3.Name = "button3";
            button3.Size = new Size(268, 71);
            button3.TabIndex = 5;
            button3.Text = "Test";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 314);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(342, 23);
            textBox3.TabIndex = 2;
            textBox3.TextChanged += textBox3_TextChanged_1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 404);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(342, 23);
            textBox4.TabIndex = 3;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(698, 268);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(342, 23);
            textBox5.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 794);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
    }
}
