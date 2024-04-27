namespace project2
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(411, 89);
            label1.TabIndex = 0;
            label1.Text = "ساعت چنده ؟";
            label1.Click += label1_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(387, 0);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(245, 89);
            label2.TabIndex = 0;
            label2.Text = "ساعت :";
            label2.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(196, 228, 255);
            button1.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(173, 191);
            button1.Name = "button1";
            button1.Size = new Size(505, 494);
            button1.TabIndex = 1;
            button1.Text = "معادله درجه 2";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(196, 228, 255);
            button2.Font = new Font("Segoe UI", 20.1F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(881, 191);
            button2.Name = "button2";
            button2.Size = new Size(505, 494);
            button2.TabIndex = 1;
            button2.Text = "عدد تصادفی";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1561, 937);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
