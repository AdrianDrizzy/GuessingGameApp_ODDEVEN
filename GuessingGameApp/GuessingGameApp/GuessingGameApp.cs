
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGameApp
{

    /*GuessingGame.cs   
 * This program generates a random number
 * 0 - 100, asks the user to play along
 * (providing clues to the target), and
 * displays a message when the target 
 * value is correctly guessed.
*/
    public partial class GuessingGameAppForm : Form
    {
        //Declare class variables
        private int guess;
        private int target;
        private int countOfGuesses;
        private Random ranValue; //declaring the instance of a random number that will be used to generate the random number.

        public GuessingGameAppForm()
        {
            InitializeComponent();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {

            //Check if user entered an integer. TryParse return boolean values TRUE or FALSE. Good option to use in Boolean expressions
            if (int.TryParse(txtBxGuess.Text, out guess) == false)
            {
                lblMsg.Text = "Value must be numeric";
            }
            else
            {

                lblMsg.Text = "";
                //We are incrementing our counter and displaying it to a label in a single statement. 
                lblAnswer.Text = (++countOfGuesses).ToString();

                if (guess == target)
                {
                    BackColor = Color.Purple;
                    MessageBox.Show(" Your guess is " + guess + " You got it... You Won!");

                    lblMsg.Text = " Reset  the game to start again";

                }
                else

                {
                    txtBxGuess.Clear();
                    txtBxGuess.Focus();

                    // The While loop allows the user to keep trying until they get the correct guess.
                    // The program will exit the while loop only when target equals to guess meaning that when boolean expression evaluate to false
                    while (target != guess)
                    {
                       
                        //The only addition for Workshop 4 is line 70-77  also Improving line 81 and 87
                        string OddEven = "";
                        
                        if (target % 2 == 1)
                        {
                            OddEven = " the target is Odd ";
                        }
                        else
                             OddEven = "the target is even ";

                        if (guess > target)
                        {
                            MessageBox.Show(guess + " is too high " + "and " + OddEven);
                            BackColor = Color.Red;
                            break;
                        }
                        else
                        {
                            MessageBox.Show(guess + " is too low " + "and " + OddEven);
                            BackColor = Color.Green;
                            break;

                        }
                    }
                }
            }
            } 

      //this is a form load event handler. To get it this event handler double click the form
    private void GuessingGameAppForm_Load(object sender, EventArgs e)
        {

            // the random number is generated when a program start
           // here we are initialising the randonm number instance ranValue
             ranValue = new Random();

            //generate the random number 
            target = ranValue.Next(0, 101);

            //set the count to zero 
            countOfGuesses = 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
             //Here we are reseting the textboxes, labels and the random number generator will generate a new target value.
            target = ranValue.Next(0, 101);
            countOfGuesses = 0;
            BackColor = Color.Purple;
            txtBxGuess.Clear();
            lblAnswer.Text = "";
            lblMsg.Text = "";
            txtBxGuess.Focus();
        }
    }
}
