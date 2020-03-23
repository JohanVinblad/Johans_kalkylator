using System;
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
        private void Button_SQRT(object sender, System.EventArgs e)
        {
            try
            {
                richTextBox1.Text = Math.Sqrt(double.Parse(richTextBox1.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Fältet får inte vara tomt");
            }

           
        }
        private void Button_edX(object sender, System.EventArgs e)
        {
            try
            {
                richTextBox1.Text = (1 / double.Parse(richTextBox1.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Något blev fel");
            }

           
       
                
        }
        private void Button_pm(object sender, System.EventArgs e)
        {
            try
            {


                if (richTextBox1.Text[0] == '-')
                {

                    double tal = Math.Abs(double.Parse(richTextBox1.Text));
                    richTextBox1.Text = tal.ToString();
                }
                else
                {
                    double tal = double.Parse(richTextBox1.Text) * -1;
                    richTextBox1.Text = tal.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Något blev fel");
            }

        }
        public void Button_tbks(object sender, System.EventArgs e)
        {
            Button knapp = (Button)sender;
            string text = richTextBox1.Text;

           if(text.Length > 0 && knapp.Text == "<--")
            {
                text = text.Remove(text.Length - 1);
                richTextBox1.Text = text.ToString();
                
            }
            





        }



    }

}

