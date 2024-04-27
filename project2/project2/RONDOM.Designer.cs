namespace project2
{
    partial class RONDOM
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
            label2 = new Label();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.1F);
            label2.Location = new Point(1009, 584);
            label2.Name = "label2";
            label2.Size = new Size(241, 89);
            label2.TabIndex = 0;
            label2.Text = "limited";
            label2.Click += label1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.1F);
            button2.Location = new Point(139, 568);
            button2.Name = "button2";
            button2.Size = new Size(306, 159);
            button2.TabIndex = 1;
            button2.Text = "limited";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 20.1F);
            button1.Location = new Point(139, 172);
            button1.Name = "button1";
            button1.Size = new Size(495, 159);
            button1.TabIndex = 2;
            button1.Text = "between 0 to 1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1F);
            label1.Location = new Point(679, 207);
            label1.Name = "label1";
            label1.Size = new Size(479, 89);
            label1.TabIndex = 3;
            label1.Text = "between 0 to 1";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.1F);
            textBox1.Location = new Point(511, 472);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.RightToLeft = RightToLeft.Yes;
            textBox1.Size = new Size(411, 120);
            textBox1.TabIndex = 4;
            textBox1.Text = "مقدار کوچکتر";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.1F);
            textBox2.Location = new Point(511, 708);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.RightToLeft = RightToLeft.Yes;
            textBox2.Size = new Size(411, 120);
            textBox2.TabIndex = 5;
            textBox2.Text = "مقدار بزرگتر";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(563, 606);
            label3.Name = "label3";
            label3.Size = new Size(260, 81);
            label3.TabIndex = 6;
            label3.Text = "between";
            // 
            // RONDOM
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 990);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label2);
            Name = "RONDOM";
            Text = "RONDOM";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
    }
}