namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void symbolCounter1_SymbolTextChanged(object sender, EventArgs e)
        {
            label1.Text = "Символів введено: " + symbolCounter1.CurrentTextLength.ToString();
            label2.Text = "Символів залишилося: " + (symbolCounter1.MaxTextLength - symbolCounter1.CurrentTextLength).ToString();
        }

        private void symbolCounter1_Load(object sender, EventArgs e)
        {
            symbolCounter1.SymbolTextChanged += symbolCounter1_SymbolTextChanged;
        }
    }
}
