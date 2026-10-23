using System.Windows.Forms;

namespace LibFactory
{
    public class AmericanLatte : ICoffee
    {
        public void Serve()
        {
            MessageBox.Show("Американська кав'ярня: Лате готове!");
        }
    }
}
