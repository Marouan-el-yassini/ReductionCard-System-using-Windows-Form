namespace ReductionCardSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAge_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonSubmi_Click(object sender, EventArgs e)
        {
            
            Rreduction redd = new Rreduction(textBox1.Text, Convert.ToInt32(textBoxAge.Text), textBoxProduct.Text, Convert.ToDouble(textBoxPrice.Text));
            Facture fact = new Facture(redd);
            fact.Show();
            this.Hide();
        }
    }
}
