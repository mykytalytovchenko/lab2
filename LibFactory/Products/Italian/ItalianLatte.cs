using System.Windows.Forms;

namespace LibFactory
{
    public class ItalianLatte : ICoffee
    {
        public void Serve()
        {
            MessageBox.Show("Італійська кав'ярня: Лате готове!");
        }
    }
}
