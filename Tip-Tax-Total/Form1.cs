namespace Tip_Tax_Total
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal price = decimal.Parse(priceBox.Text);
            decimal tax = decimal.Parse(taxBox.Text)/100;
            decimal tip = decimal.Parse(tipBox.Text);

            decimal taxAmount = price * tax;

            decimal total =price+tip+taxAmount;
            totalBox.Text = total.ToString("c2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}