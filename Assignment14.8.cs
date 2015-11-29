using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Grade: 8
//Missing requirements:
//The red/blue change should be baesd on whether or not the guesses are getting closer to or farther from not if they are too low or too high (no points deducted this was not well understood)
//The textbox was to be disabled on a correct guess (points deducted)
//There should be a button to generate a new number if the user wants to play again (points deducted)

//Observations
//I was a bit disappointed in your user interface, the button text was button1, there just wasn't much effort here
namespace Assignment14._8
{
    public partial class Form1 : Form
    {
        Form form1 = new Form();  //Form object
        Random randomNumber = new Random();  // Random number generator
        int userAnswer = 0;
        int answer;

        
        public Form1()
        {
            InitializeComponent();
            
            label1.Text = "Guess the number";                 // Label text
            answer = randomNumber.Next(1, 1000);              // Generated random number
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)  // Text box changed event
        {
            
            userAnswer = Convert.ToInt32(textBox1.Text);

            if (textBox1.Text == "" || textBox1.Text == null)
            {
               
            }
            else
            {
               
            }
        
        }

        public void button1_Click(object sender, EventArgs e)  // Button click event
        {
            userAnswer = Convert.ToInt32(textBox1.Text);  // Converts user answer into a integer

            if (userAnswer > answer)
            {
                label1.Text = "Too high";
                this.BackColor = Color.Red; // Color change for the background if user answer is too high
                
            }
            else if (userAnswer < answer)
            {
                label1.Text = "Too low";
                this.BackColor = Color.Blue; // Color change for the background if user answer is too low
            }

            if (userAnswer == answer)
            {
                label1.Text = "Correct!";
                this.BackColor = Color.Green;  // Color change for the background if user answer is correct
            }
            
        }
    }
}
