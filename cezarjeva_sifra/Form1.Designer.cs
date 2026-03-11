namespace cezarjeva_sifra
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
            labelSifrVnos = new Label();
            richTextBox1 = new RichTextBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            numericUpDown1 = new NumericUpDown();
            labelSifKljuc = new Label();
            groupBox2 = new GroupBox();
            button2 = new Button();
            numericUpDown2 = new NumericUpDown();
            richTextBox2 = new RichTextBox();
            label2 = new Label();
            label1 = new Label();
            richTextBox3 = new RichTextBox();
            label4 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // labelSifrVnos
            // 
            labelSifrVnos.AutoSize = true;
            labelSifrVnos.Location = new Point(42, 36);
            labelSifrVnos.Name = "labelSifrVnos";
            labelSifrVnos.Size = new Size(107, 20);
            labelSifrVnos.TabIndex = 0;
            labelSifrVnos.Text = "Vnesi besedilo:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(155, 36);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(196, 153);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            richTextBox1.Enter += richTextBox1_TextChanged;
            richTextBox1.Leave += richTextBox1_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(labelSifKljuc);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(labelSifrVnos);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 282);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Šifriranje";
            // 
            // button1
            // 
            button1.Location = new Point(155, 238);
            button1.Name = "button1";
            button1.Size = new Size(196, 29);
            button1.TabIndex = 5;
            button1.Text = "ŠIFRIRAJ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(155, 196);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // labelSifKljuc
            // 
            labelSifKljuc.AutoSize = true;
            labelSifKljuc.Location = new Point(24, 203);
            labelSifKljuc.Name = "labelSifKljuc";
            labelSifKljuc.Size = new Size(125, 20);
            labelSifKljuc.TabIndex = 3;
            labelSifKljuc.Text = "Vnesi šifrirni ključ:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(numericUpDown2);
            groupBox2.Controls.Add(richTextBox2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(431, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 281);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dešifriranej";
            // 
            // button2
            // 
            button2.Location = new Point(196, 237);
            button2.Name = "button2";
            button2.Size = new Size(186, 29);
            button2.TabIndex = 4;
            button2.Text = "DEŠIFRIRAJ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(196, 197);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(150, 27);
            numericUpDown2.TabIndex = 3;
            numericUpDown2.TextAlign = HorizontalAlignment.Center;
            numericUpDown2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown2.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(196, 38);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(186, 150);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            richTextBox2.TextChanged += richTextBox2_TextChanged;
            richTextBox2.Enter += richTextBox2_TextChanged;
            richTextBox2.Leave += richTextBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 204);
            label2.Name = "label2";
            label2.Size = new Size(142, 20);
            label2.TabIndex = 1;
            label2.Text = "Vnesi dešifrirni ključ:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 35);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 0;
            label1.Text = "Vnesi Šifrirano besedilo:";
            // 
            // richTextBox3
            // 
            richTextBox3.Location = new Point(267, 300);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(292, 165);
            richTextBox3.TabIndex = 5;
            richTextBox3.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 303);
            label4.Name = "label4";
            label4.Size = new Size(204, 20);
            label4.TabIndex = 7;
            label4.Text = "šifrirano/dešifrirano besedilo:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(858, 477);
            Controls.Add(label4);
            Controls.Add(richTextBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Cezarjeva šifra";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSifrVnos;
        private RichTextBox richTextBox1;
        private GroupBox groupBox1;
        private Button button1;
        private NumericUpDown numericUpDown1;
        private Label labelSifKljuc;
        private GroupBox groupBox2;
        private RichTextBox richTextBox2;
        private Label label2;
        private Label label1;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private RichTextBox richTextBox3;
        private Label label4;
    }
}
