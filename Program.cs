/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 06, 2022
* Assignment: CIS214 Final Practical Exam
* Description:
* - The main application does the following
*   - Print a line that states "Your Name - Final Practical Exam"
*   - Creates an instance of the Unique class
*   - Calls the Unique class's GetNumbers function to get the necessary values
*     from the user
*   - Calls the Unique class's function to print the following (each value with
*     an appropriate label)
*     - All unique values entered by the user
*     - The largest number entered
*     - The smallest number entered
*     - The sum of all numbers entered
*     - The average of all numbers entered
*     - The last number entered divided by the first number entered (handle
*       division by 0 exception properly)
\******************************************************************************/

namespace aa_final_practical_exam
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Print a line that states "Your Name - Final Practical Exam"
            Console.WriteLine(
            "Jason D'Oyley - Final Practical Exam\n"
            );

            // Creates an instance of the Unique class
            Unique nums = new Unique();
            nums.GetNumbers();

            // Display Unique Number List
            nums.DisplayUniqueValue();

            // Display Minimum Value Entered
            nums.DisplayMinValue();

            // Display Maximum Value Entered
            nums.DisplayMaxValue();

            // Display The sum of all numbers entered
            nums.DisplayNumSum();

            // Display The average of all numbers entered
            nums.DisplayAverage();

            // Display the Quotient
            nums.DisplayQuotient();
        }
    }
}