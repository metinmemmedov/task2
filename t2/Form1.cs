namespace t2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Check if numbers are valid AND an item is actually selected in the ComboBox
            if (float.TryParse(textBox1.Text, out float value1) &&
                float.TryParse(textBox2.Text, out float value2) &&
                comboBox1.SelectedIndex != -1)
            {
                string op = comboBox1.SelectedItem.ToString();

                if (op == "add")
                {
                    label4.Text = $"ANSWER: {value1 + value2}";
                }
                else if (op == "subtract")
                {
                    label4.Text = $"ANSWER: {value1 - value2}";
                }
                else if (op == "multiply")
                {
                    label4.Text = $"ANSWER: {value1 * value2}";
                }
                else if (op == "divide")
                {
                    // Prevent Division by Zero crash
                    if (value2 == 0)
                    {
                        label4.Text = "ERROR: Cannot divide by zero!";
                    }
                    else
                    {
                        label4.Text = $"ANSWER: {value1 / value2}";
                    }
                }
            }
            else
            {
                label4.Text = "ERROR: Please enter valid numbers and select an operation.";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "ANSWER: ";
            comboBox1.SelectedIndex = -1;

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
