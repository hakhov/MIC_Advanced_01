using Calculate;

namespace CalcForm
{
    public partial class Form1 : Form
    {
        Calc ob;
        double number1=0, number2=0;
        public Form1()
        {
            InitializeComponent();
            ob = new();
            Method();
        }

        
        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (ob.ValidNumber(textBox1.Text))
                number1 = double.Parse(textBox1.Text);
            else
            {
                MessageBox.Show("Error", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            number2 = ob.ValidNumber(textBox2.Text) ? double.Parse(textBox2.Text) : 0;

            var txt = ob.Sub(number1, number2).ToString();
            textBox3.Text = txt;
            MessageBox.Show(txt, "Result after adding", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            number2 = ob.ValidNumber(textBox2.Text) ? double.Parse(textBox2.Text) : 0;
            number1 = ob.ValidNumber(textBox1.Text) ? double.Parse(textBox1.Text) : 0;
            var txt = ob.Add(number1, number2).ToString();
            textBox3.Text = txt;
            MessageBox.Show(txt, "Result after substucting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        partial void Method();
    }
}