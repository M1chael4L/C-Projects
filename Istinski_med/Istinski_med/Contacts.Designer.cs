namespace Istinski_med
{
    partial class Contacts
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button1 = new Button();
            label6 = new Label();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngtree_business_bee_dapper_suit_and_tie_mascot_illustration_png_image_13339235;
            pictureBox1.Location = new Point(549, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(336, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 20);
            label1.Name = "label1";
            label1.Size = new Size(169, 28);
            label1.TabIndex = 1;
            label1.Text = "Обратна връзка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(70, 78);
            label2.Name = "label2";
            label2.Size = new Size(40, 28);
            label2.TabIndex = 2;
            label2.Text = "До";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(70, 135);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 3;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 195);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 4;
            label4.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(70, 254);
            label5.Name = "label5";
            label5.Size = new Size(108, 28);
            label5.TabIndex = 5;
            label5.Text = "Коментар";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(186, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(186, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(156, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(184, 258);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(372, 122);
            textBox3.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.SandyBrown;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(350, 395);
            button1.Name = "button1";
            button1.Size = new Size(168, 39);
            button1.TabIndex = 10;
            button1.Text = "Изпрати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(528, 57);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 11;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Кралицата", "Пчела1", "Пчела2", "Пчела3", "Пчела4" });
            comboBox1.Location = new Point(186, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(134, 28);
            comboBox1.TabIndex = 12;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Contacts";
            Size = new Size(824, 449);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button1;
        private Label label6;
        private ComboBox comboBox1;
    }
}
