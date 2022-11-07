# Final Practical Exam

Your application will demonstrate the ability to retrieve 5 unique numbers in a range from 0 to 100 (inclusive), then determine the largest number, the smallest number, the sum of all the numbers, the average of the numbers entered, and divide the last number entered by the first number entered. Note: exception handling will be required – throw an exception if the value entered is out of range; handle the system exception if a division by 0 error is encountered. Incorporate the following requirements into your application:

- The program will consist of two files
- The Unique class provides the following:
  -Constructor
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
- The main application does the following
  - Print a line that states "Your Name - Final Practical Exam"
  - Creates an instance of the Unique class
  - Calls the Unique class's GetNumbers function to get the necessary values from the user
  - Calls the Unique class's function to print the following (each value with an appropriate label)
    - All unique values entered by the user
    - The largest number entered
    - The smallest number entered
    - The sum of all numbers entered
    - The average of all numbers entered
    - The last number entered divided by the first number entered (handle division by 0 exception properly)
