namespace project2
{
    partial class math
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(119, 107);
            label1.Name = "label1";
            label1.Size = new Size(1086, 159);
            label1.TabIndex = 0;
            label1.Text = "a x 2 + b x + c = 0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.1F);
            label2.Location = new Point(146, 284);
            label2.Name = "label2";
            label2.Size = new Size(154, 89);
            label2.TabIndex = 1;
            label2.Text = "a = ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.1F);
            label3.Location = new Point(550, 284);
            label3.Name = "label3";
            label3.Size = new Size(159, 89);
            label3.TabIndex = 2;
            label3.Text = "b = ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.1F);
            label4.Location = new Point(876, 284);
            label4.Name = "label4";
            label4.Size = new Size(151, 89);
            label4.TabIndex = 3;
            label4.Text = "c = ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.1F);
            textBox1.Location = new Point(274, 289);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(95, 97);
            textBox1.TabIndex = 4;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.1F);
            textBox2.Location = new Point(675, 289);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(95, 97);
            textBox2.TabIndex = 4;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 20.1F);
            textBox3.Location = new Point(996, 289);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(95, 97);
            textBox3.TabIndex = 4;
            textBox3.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(474, 489);
            button1.Name = "button1";
            button1.Size = new Size(341, 148);
            button1.TabIndex = 5;
            button1.Text = "calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 20.1F);
            label5.Location = new Point(397, 673);
            label5.Name = "label5";
            label5.Size = new Size(582, 133);
            label5.TabIndex = 6;
            label5.Text = "answer :";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 20.1F);
            label6.Location = new Point(397, 806);
            label6.Name = "label6";
            label6.Size = new Size(582, 133);
            label6.TabIndex = 6;
            label6.Click += label6_Click;
            // 
            // math
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1368, 971);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "math";
            Text = "-";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}