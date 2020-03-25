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

            if (knapp.Text == "*")    //Multiplikation
            {
                haskomma = false;
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "*";
            }
            
            if (knapp.Text == "+")    //Addition
            {
                haskomma = false;
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "+";  
            }

            if (knapp.Text == "-")    //Subtraktion
            {
                haskomma = false;
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "-";
            }

            if (knapp.Text == "/")    //Division
            {
                haskomma = false;
                första = double.Parse(richTextBox1.Text);
                richTextBox1.Clear();
                operation = "/";
            }

            if (knapp.Text == "=")    //Ifall användaren klickar på "=", så vänta på nästa instruktion (Gamla värdet kan byggas på)
            {
                
                andra = double.Parse(richTextBox1.Text);    //Första värdet = första, Andra värdet = andra
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

            if (knapp.Text == "CE")    //Ifall CE, töm bara fönstret
            { 
                richTextBox1.Clear();
                haskomma = false;              
            }

            if (knapp.Text == "C")    //Ifall C, töm hela skiten
            {
                första = 0;
                andra = 0;
                richTextBox1.Clear();
                haskomma = false;
            }
        }

        private void Button_Komma(object sender, System.EventArgs e)    //Ifall jag klickar "," så kan du inte skriva mer "," i samma tal
        {        
                if (haskomma == false) 
                {
                    haskomma = true;
                    richTextBox1.Text += ",";
                }            
        }

        private void Button_SQRT(object sender, System.EventArgs e)    //Gör sqrt beräkning med hjälp av math-bibblan
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

        private void Button_edX(object sender, System.EventArgs e)   // 1/X Där X är talet användaren skriver in
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
                if (richTextBox1.Text[0] == '-')    //Ifall första elementet i arrayen är - konverterar den det till ett positivt :) tal genom absolutbelopp
                {
                    double tal = Math.Abs(double.Parse(richTextBox1.Text));    
                    richTextBox1.Text = tal.ToString();
                }
                else  //Ifall talet inte är negativt :(, tar den talet gånger -1
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

        public void Button_tbks(object sender, System.EventArgs e)    //Skapar temporär string, tar bort sista elementet i arrayen, skriver tillbaka i richtextbox
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

