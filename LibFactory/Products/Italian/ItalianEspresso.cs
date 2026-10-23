using System.Windows.Forms;

namespace LibFactory
{
    public class ItalianEspresso : ICoffee
    {
        public void Serve()
        {
            MessageBox.Show("Італійська кав'ярня: Еспресо готове!");
        }
    }
}
