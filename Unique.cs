/******************************************************************************\
* Name: Jason D. F. D'Oyley
* Date: November 06, 2022
* Assignment: CIS214 Final Practical Exam
* Description: class for retrieving the unique values from the use
*   -Constructor
  -Private member variable to store 5 unique values (hint: use an Array or a List)
  -Public function to get 5 unique values from the user and store them in the member variable
      - loop to get the numbers, if a number is already stored, ignore it and
      keep
      - looping until you have 5 unique numbers
      - if a number is out of range, don't store the value, throw an exception and handle it in such a way that you don't break the loop but do message the user that the value was out of range
  - Public functions to return the following based on the stored values:
    - Largest number
    - Smallest number
    - Sum of all numbers
    - Average of the numbers entered
    - Last number entered divided by the first number entered
  - Hint: How you approach the ability to get the above values is up to you - you may process the stored values within each function, you may use member variables to store the information as you retrieve it from the user, or you may use a combination of both techniques
\******************************************************************************/

namespace aa_final_practical_exam
{
    public class Unique
    {
        // Attributes
        private List<int> Values { get; set; }

        // Constructor
        public Unique()
        {
            Values = new List<int> { };
        }

        public Unique(List<int> values)
        {
            Values = values;
        }

        // Class Methods
        public void GetNumbers()
        {
            int counter = 0;
            do
            {
                try
                {
                    Console.Write("Please enter an integer value: ");
                    string? val = Console.ReadLine();
                    int number = Convert.ToInt32(val);

                    if (number < 0 || number > 100)
                    {
                        throw new Exception(
                            "You must enter a value between 0 and 100, " +
                            "inclusive."
                        );
                    }

                    // if a number is out of range, don't store the value,
                    // throw an exception and handle it in such a way that you
                    // don't break the loop but do message the user that the
                    // value was out of range
                    if (Values.Contains(number))
                        continue;

                    Values.Add(number);
                    counter++;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

            } while (counter < 5);
        }

        public void DisplayUniqueValue()
        {
            Console.WriteLine("Unique Values Entered:");

            // All unique values entered by the user
            foreach (int item in Values)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine("");
        }

        // The smallest number entered
        public void DisplayMinValue()
        {
            int minVal = -1;
            foreach (int item in Values)
            {
                if (Values.IndexOf(item) == 0)
                    minVal = item;

                if (item < minVal)
                    minVal = item;
            }
            Console.WriteLine($"Min Value Entered: {minVal}\n");
        }

        // The largest number entered
        public void DisplayMaxValue()
        {
            int maxVal = -1;
            foreach (int item in Values)
            {
                if (Values.IndexOf(item) == 0)
                    maxVal = item;

                if (item > maxVal)
                    maxVal = item;
            }
            Console.WriteLine($"Max Value Entered: {maxVal}\n");
        }

        // The sum of all numbers entered
        protected int Sum()
        {
            int sum = 0;
            foreach (int item in Values)
            {
                sum += item;
            }
            return sum;
        }

        public void DisplayNumSum()
        {
            Console.WriteLine($"Sum of Values Entered: {Sum()}\n");
        }

        public void DisplayAverage()
        {
            Console.WriteLine(
                $"Average of Values Entered: {Sum() / Values.Count}\n"
            );
        }

        // The last number entered divided by the first number entered
        // (handle division by 0 exception properly)
        public void DisplayQuotient()
        {
            int firstVal = Values.First();
            int lastVal = Values.Last();

            try
            {
                int quotient = lastVal / firstVal;
                Console.WriteLine(
                    $"Last Value Divided by First Value: {quotient}\n"
                );
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("All processing completed!");
            }
        }
    }
}