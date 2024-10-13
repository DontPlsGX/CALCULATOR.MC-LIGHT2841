namespace SimpleCalculator
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        private bool isPlus = false;
        private bool isMinus = false;
        private bool isDivide = false;
        private bool isModulus = false;
        private bool isMultiply = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "0";
            }
            else
            {
                TxtBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TxtBox.Text.Contains("."))
            {
                TxtBox.Text += ".";
            }
        }

        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "1";
            }
            else
            {
                TxtBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "2";
            }
            else
            {
                TxtBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "3";
            }
            else
            {
                TxtBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "4";
            }
            else
            {
                TxtBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "5";
            }
            else
            {
                TxtBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "6";
            }
            else
            {
                TxtBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "7";
            }
            else
            {
                TxtBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "8";
            }
            else
            {
                TxtBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text == "0")
            {
                TxtBox.Text = "9";
            }
            else
            {
                TxtBox.Text += "9";
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            TxtBox.Text = "0";
        }

        private void MinusPlusBtn_Click(object sender, EventArgs e)
        {
            if (TxtBox.Text.Contains("-"))
            {
                TxtBox.Text = TxtBox.Text.Trim('-');
            }
            else
            {
                TxtBox.Text = '-' + TxtBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            if (isMinus == false)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "-";
                isMinus = true;
            }
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            if (isPlus == false)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "+";
                isPlus = true;
            }
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            if (isDivide == false)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "/";
                isDivide = true;
            }
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            if (isMultiply == false)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "*";
                isMultiply = true;
            }
        }

        private void ModuloBtn_Click(object sender, EventArgs e)
        {
            if (isModulus == false)
            {
                valueFirst = decimal.Parse(TxtBox.Text);
                TxtBox.Clear();
                operators = "%";
                isModulus = true;
            }
        }
        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst - valueSecond;
                    TxtBox.Text = Result.ToString();
                    isMinus = false;
                    break;
                case "+":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst + valueSecond;
                    TxtBox.Text = Result.ToString();
                    isPlus = false;
                    break;
                case "*":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst * valueSecond;
                    TxtBox.Text = Result.ToString();
                    isMultiply = false;
                    break;
                case "/":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    if (valueSecond == 0)
                    {
                        TxtBox.Text = "Value Error";
                        isDivide = false;
                        break;
                    }
                    Result = valueFirst / valueSecond;
                    TxtBox.Text = Result.ToString();
                    isDivide = false;
                    break;
                case "%":
                    valueSecond = decimal.Parse(TxtBox.Text);
                    Result = valueFirst % valueSecond;
                    TxtBox.Text = Result.ToString();
                    isModulus = false;
                    break;
            }
        }
    }
}