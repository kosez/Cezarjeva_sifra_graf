namespace cezarjeva_sifra
{

    public partial class Form1 : Form
    {
        Desifriranje des = new Desifriranje();
        Sifriranje sif = new Sifriranje();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sif.shift = 1;
            des.shift = 1;
           
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Maximum = 25;
            numericUpDown1.Minimum = 1;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Maximum = 25;
            numericUpDown2.Minimum = 1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sif.text = richTextBox1.Text;
            sif.encryption(sif.text,(int)numericUpDown1.Value);
            richTextBox3.Text = sif.rezultat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            des.text = richTextBox2.Text;
            des.decrypt(des.text,(int)numericUpDown2.Value);
            richTextBox3.Text = des.rezultat;
        }

        
    }
}

