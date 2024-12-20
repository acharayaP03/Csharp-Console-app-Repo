namespace CurrencyConverter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainFormLoad(object sender, EventArgs e)
        {

        }

        private int _count = 0;

        private void IncreaseCounterButton_Click(object sender, EventArgs e)
        {
            _count++;
            CounterLabel.Text = _count.ToString();
        }

        private void HideButtonChecknbox_CheckboxChanged(object sender, EventArgs e)
        {
            IncreaseCounterButton.Visible = !IncreaseCounterButton.Visible;
        }
    }
}
