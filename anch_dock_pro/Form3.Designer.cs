namespace anch_dock_pro
{
    partial class Form3
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
            this.String_textBox = new System.Windows.Forms.TextBox();
            this.len_textBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.birth_date = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.birth_year = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.birth_day = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.birtT_month = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // String_textBox
            // 
            this.String_textBox.Location = new System.Drawing.Point(42, 73);
            this.String_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.String_textBox.Name = "String_textBox";
            this.String_textBox.Size = new System.Drawing.Size(116, 23);
            this.String_textBox.TabIndex = 0;
            this.String_textBox.TextChanged += new System.EventHandler(this.String_textBox_TextChanged);
            // 
            // len_textBox
            // 
            this.len_textBox.Location = new System.Drawing.Point(42, 130);
            this.len_textBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.len_textBox.Name = "len_textBox";
            this.len_textBox.Size = new System.Drawing.Size(116, 23);
            this.len_textBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 190);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calculate Length";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birth_date
            // 
            this.birth_date.Location = new System.Drawing.Point(446, 99);
            this.birth_date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birth_date.Name = "birth_date";
            this.birth_date.Size = new System.Drawing.Size(116, 23);
            this.birth_date.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Birth Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Birth Year:";
            // 
            // birth_year
            // 
            this.birth_year.Location = new System.Drawing.Point(446, 148);
            this.birth_year.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birth_year.Name = "birth_year";
            this.birth_year.Size = new System.Drawing.Size(116, 23);
            this.birth_year.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Birth Day:";
            // 
            // birth_day
            // 
            this.birth_day.Location = new System.Drawing.Point(446, 262);
            this.birth_day.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birth_day.Name = "birth_day";
            this.birth_day.Size = new System.Drawing.Size(116, 23);
            this.birth_day.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birth Month:";
            // 
            // birtT_month
            // 
            this.birtT_month.Location = new System.Drawing.Point(446, 205);
            this.birtT_month.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.birtT_month.Name = "birtT_month";
            this.birtT_month.Size = new System.Drawing.Size(116, 23);
            this.birtT_month.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(359, 306);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 26);
            this.button2.TabIndex = 11;
            this.button2.Text = "Show result";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 497);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.birth_day);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.birtT_month);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.birth_year);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birth_date);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.len_textBox);
            this.Controls.Add(this.String_textBox);
            this.Font = new System.Drawing.Font("Sitka Text", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox String_textBox;
        private TextBox len_textBox;
        private Button button1;
        private TextBox birth_date;
        private Label label1;
        private Label label2;
        private TextBox birth_year;
        private Label label3;
        private TextBox birth_day;
        private Label label4;
        private TextBox birtT_month;
        private Button button2;
    }
}