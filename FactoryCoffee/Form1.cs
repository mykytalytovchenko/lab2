using LibFactory;
using System.Windows.Forms;

namespace FactoryCoffee
{
    public partial class Form1 : Form
    {
        CoffeeShop coffeeShop;

        public Form1()
        {
            InitializeComponent();
        }

        private void rbtnItalian_CheckedChanged(object sender, System.EventArgs e)
        {
            coffeeShop = new ItalianCoffeeShop();
        }

        private void rbtnAmerican_CheckedChanged(object sender, System.EventArgs e)
        {
            coffeeShop = new AmericanCoffeeShop();
        }

        private void btnEspresso_Click(object sender, System.EventArgs e)
        {
            coffeeShop?.orderCoffee("espresso");
        }

        private void btnLatte_Click(object sender, System.EventArgs e)
        {
            coffeeShop?.orderCoffee("latte");
        }

        private void btnAmericano_Click(object sender, System.EventArgs e)
        {
            coffeeShop?.orderCoffee("americano");
        }
    }
}
