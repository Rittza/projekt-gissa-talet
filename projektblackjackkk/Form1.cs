namespace projektblackjackkk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(10);
            listBox1.Items.Add(20);
            listBox1.SelectedItem = listBox1.Items[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h�gstatal = listBox1.SelectedItem.ToString();
            int st�rtatal = int.Parse(h�gstatal);
            Random mellan = new Random();

            int datornstal = mellan.Next(1, st�rtatal + 1);
            int userstal = int.Parse(textBox1.Text);

            if(userstal == datornstal)
            {
                label6.Text = "GZ du vann";
                label3.Text = "Datorn valde talet" + datornstal;
            }
            else if(userstal < datornstal)
            {
                label6.Text = "Du torskade";
                label3.Text = "Datorn valde talet" + datornstal;
            }
            else
            {
                label6.Text = "Du f�rlorade";
                label3.Text = "Datorn valde talet" + datornstal;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}