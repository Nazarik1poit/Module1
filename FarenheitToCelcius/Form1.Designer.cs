namespace FarenheitToCelcius
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
            domainUpDown1 = new DomainUpDown();
            domainUpDown2 = new DomainUpDown();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(67, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(67, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(54, 119);
            button1.Name = "button1";
            button1.Size = new Size(151, 29);
            button1.TabIndex = 2;
            button1.Text = "Конвертировать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // domainUpDown1
            // 
            domainUpDown1.Items.Add("C");
            domainUpDown1.Items.Add("F");
            domainUpDown1.Location = new Point(21, 87);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(40, 27);
            domainUpDown1.TabIndex = 3;
            domainUpDown1.Text = "F";
            // 
            // domainUpDown2
            // 
            domainUpDown2.Items.Add("F");
            domainUpDown2.Items.Add("C");
            domainUpDown2.Location = new Point(21, 37);
            domainUpDown2.Name = "domainUpDown2";
            domainUpDown2.Size = new Size(40, 27);
            domainUpDown2.TabIndex = 4;
            domainUpDown2.Text = "C";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(241, 302);
            Controls.Add(domainUpDown2);
            Controls.Add(domainUpDown1);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "FtoC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private DomainUpDown domainUpDown1;
        private DomainUpDown domainUpDown2;
    }
}
