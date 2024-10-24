using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int randomnumber;
        private void Form1_Load(object sender, EventArgs e)
        {
            Random rand = new Random();
            randomnumber = rand.Next(1, 101);
        }

        int count;
        private void button1_Click(object sender, EventArgs e)
        {
          
            int userGuess;
            if (int.TryParse(txt.Text, out userGuess))
            {
                if (userGuess > randomnumber)
                {
                    result.Text = "Too high! Try again.";
                }
                else if (userGuess < randomnumber)
                {
                    result.Text = "Too low! Try again.";
                }
                else
                {
                    result.Text = "Congratulations! You guessed the right number";
                }
                previous.Text = $"{userGuess} is previous";
                count++;
                ammount.Text = $"{count} times guessed";
            }
            else
            {
                result.Text = "Please enter a valid number.";
            }
        }
    }
}
