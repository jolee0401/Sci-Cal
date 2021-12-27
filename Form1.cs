using System.Windows.Forms;

namespace Sci_Cal
{
    public partial class Form1 : Form
    {
        private bool isoptr;
        Double value = 0;
        String operations = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (!(textBox.Text != "0" || isoptr))
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;  
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (textBox.Text == "0" || isoptr)
            {
                textBox.Clear();
            }
            isoptr = false;
            Button button = (Button)sender;
            if (textBox.Text == ".")
            {
                if (!textBox.Text.Contains("."))
                {
                    textBox.Text += button.Text;
                }
            }
            else textBox.Text += button.Text;
            //textBox.Text = button.Text;   
        }

        private void button27_Click(object sender, EventArgs e)
        {
           
        }
    }
}