namespace RunescapeTimer
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.LightGoldenrodYellow;
            button1.Location = new Point(30, 108);
            button1.Name = "button1";
            button1.Size = new Size(61, 40);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Popup;
            button2.ForeColor = Color.LightGoldenrodYellow;
            button2.Location = new Point(122, 108);
            button2.Name = "button2";
            button2.Size = new Size(61, 40);
            button2.TabIndex = 1;
            button2.Text = "Stop";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = Color.LightGoldenrodYellow;
            button3.Location = new Point(206, 108);
            button3.Name = "button3";
            button3.Size = new Size(61, 40);
            button3.TabIndex = 2;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.LightGoldenrodYellow;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(292, 65);
            label1.TabIndex = 3;
            label1.Text = "00:00:00.000";
            // 
            // timer1
            // 
            timer1.Interval = 1;
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Red;
            label3.Cursor = Cursors.Hand;
            label3.Location = new Point(270, 0);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(12, 15);
            label3.TabIndex = 7;
            label3.Text = "-";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Red;
            label2.Cursor = Cursors.Hand;
            label2.Location = new Point(284, 0);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 8;
            label2.Text = "x";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 18, 27);
            ClientSize = new Size(299, 164);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = Color.Yellow;
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            MouseDown += Form1_MouseDown;
            MouseMove += Form1_MouseMove;
            MouseUp += Form1_MouseUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
        private Label label2;
    }
}