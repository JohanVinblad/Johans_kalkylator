using System.Windows.Forms;

namespace Johans_kalkylator
{
    public partial class Form1 : Form
    {

        //Hej Github
        int första;
        int andra;
        bool haskomma;

        public Form1()
        {
            haskomma = false;
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


            if(knapp.Text == "*")
            {
                första = int.Parse(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            if (knapp.Text == "+")
            {
                första = int.Parse(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            if (knapp.Text == "-")
            {
                första = int.Parse(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            if (knapp.Text == "/")
            {
                första = int.Parse(richTextBox1.Text);
                richTextBox1.Text = "";
            }
            if (knapp.Text == "=")
            {
                andra = int.Parse(richTextBox1.Text);
                richTextBox1.Text = (första + andra).ToString();
            }
            if (knapp.Text == ",")
            {

                char[] arr = richTextBox1.Text.ToCharArray();

                for(int i = 0; i < arr.Length; i++)
                {
                    if(arr[i] == '.')
                    {
                        haskomma = true;
                    }

                }

                if(!haskomma)
                    richTextBox1.Text += ".";
                
            }

        }
    }
}
