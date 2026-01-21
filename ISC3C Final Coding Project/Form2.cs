
using System.Diagnostics.Eventing.Reader;

namespace ISC3C_Final_Coding_Project
{
    public partial class Form2 : Form
    {
        Boolean Blue = false;
        Boolean Green = false;
        Boolean Red1 = false;
        Boolean Red2 = false;
        Boolean Yellow = false;
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            blueButton.BackColor = Color.Blue;
            Refresh();
            Thread.Sleep(500);

            blueButton.BackColor = Color.DodgerBlue;
            Refresh();
            Thread.Sleep(500);

            greenButton.BackColor = Color.Lime;
            Refresh();
            Thread.Sleep(500);

            greenButton.BackColor = Color.Green;
            Refresh();
            Thread.Sleep(500);

            redButton.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            redButton.BackColor = Color.Maroon;
            Refresh();
            Thread.Sleep(500);

            redButton.BackColor = Color.Red;
            Refresh();
            Thread.Sleep(500);

            redButton.BackColor = Color.Maroon;
            Refresh();
            Thread.Sleep(500);

            yellowButton.BackColor = Color.Yellow;
            Refresh();
            Thread.Sleep(500);

            yellowButton.BackColor = Color.Goldenrod;
            Refresh();
            Thread.Sleep(500);
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            if (Blue == false && Green == false && Red1 == false && Red2 == false && Yellow == false);
            Blue = true;
            else outputLabel.text = "Try again!";
        }

        private void redButton_Click(object sender, EventArgs e)
        {

        }
    }
}
