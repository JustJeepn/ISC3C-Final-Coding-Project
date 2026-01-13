using System;
using System.Windows.Forms;
namespace ISC3C_Final_Coding_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            //g.FillRectangle(blackBrush, ball);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            //hides Form1 (the instructions) and reveals the game itself in Form2
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
