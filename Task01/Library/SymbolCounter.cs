using System.ComponentModel;

namespace Library
{
    [ToolboxBitmap(typeof(SymbolCounter), "SymbolCounter.ico")]
    public partial class SymbolCounter : UserControl
    {
        public SymbolCounter()
        {
            InitializeComponent();
            textBox1.TextChanged += TextBox1_TextChanged;
            textBox1.MaxLength = 10;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            CurrentTextLength = textBox1.Text.Length;
            SymbolTextChanged?.Invoke(this, EventArgs.Empty);
        }
        
        [DefaultValue(10)]
        public int MaxTextLength
        {
            get => textBox1.MaxLength;
            set => textBox1.MaxLength = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [DefaultValue(0)]
        public int CurrentTextLength
        {
            get;
            private set;
        }


        public event EventHandler SymbolTextChanged;
    }
}
