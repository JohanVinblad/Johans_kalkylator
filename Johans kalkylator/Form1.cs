using System.Windows.Forms;

namespace Johans_kalkylator
{
    public partial class Form1 : Form
    {

        //Hej Github
        double första;
        double andra;
        bool haskomma = false;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void Button_Listener(object sender, System.EventArgs e)
        {
            Button knapp = (Button)sender;
            richTextBox1.Text += knapp.Text;
        }

        private void Button_uträkningar(object sender, System.EventArgs e)
        {
            Button knapp = (Button)sender;


            if (knapp.Text == "*")
            {
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "*";
            }
            if (knapp.Text == "+")
            {
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "+";
               
            }
            if (knapp.Text == "-")
            {
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "-";
            }
            if (knapp.Text == "/")
            {
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "/";
            }
            if (knapp.Text == "=")
            {
                andra = double.Parse(richTextBox1.Text);
                if (operation == "+")
                {
                    richTextBox1.Text = (första + andra).ToString();
                }

                if (operation == "*")
                {
                    richTextBox1.Text = (första * andra).ToString();
                }

                if (operation == "-")
                {
                    richTextBox1.Text = (första - andra).ToString();
                }

                if (operation == "/")
                {
                    richTextBox1.Text = (första / andra).ToString();
                }
            }
            if (knapp.Text == "CE")
            {
                
                richTextBox1.Clear();
                haskomma = false;
                
            }
            if (knapp.Text == "C")
            {
                första = 0;
                andra = 0;
                richTextBox1.Clear();
                haskomma = false;
            }


        }

        private void Button_Komma(object sender, System.EventArgs e)
        {
            
                if (haskomma == false)
                {
                    haskomma = true;
                    richTextBox1.Text += ",";
                }
            

        }

    }

}

