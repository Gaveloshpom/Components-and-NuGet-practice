namespace NuGet_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void symbolCounter1_SymbolTextChanged(object sender, EventArgs e)
        {
            label1.Text = "������� �������: " + symbolCounter1.CurrentTextLength.ToString();
            label2.Text = "������� ����������: " + (symbolCounter1.MaxTextLength - symbolCounter1.CurrentTextLength).ToString();
        }
    }
}
