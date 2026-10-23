using System.Windows.Forms;

namespace LibFactory
{
    public class AmericanEspresso : ICoffee
    {
        public void Serve()
        {
            MessageBox.Show("Американська кав'ярня: Еспресо готове!");
        }
    }
}
