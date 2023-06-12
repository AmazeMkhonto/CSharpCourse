

/*
For loop - Factorial
Using the for loop, implement the Factorial method, which calculates the factorial of a given number.
Factorial of number N is the result of multiplying all integers from 1 to N.
N! = 1 * 2 * 3 * ... * (N-1) * N
For example:
    5! = 1*2*3*4*5 = 120
    4! = 1*2*3*4 = 24
    1! = 1
    0! = 1 (by convention)
Assume the number parameter is non-negative.*/

// int number = 0;
// int factorial =  1;
// for(int i = 1; i < number+1; i++){
//     factorial = factorial *i;
// }
// System.Console.WriteLine(factorial);

//use a do while look and break, to ask a user to enter a number larger than 10 if they type in stop
// you should stop the loop (also is the do wile loop the best one to use)

// int enteredNumber;
// do{
//     System.Console.WriteLine("Enter a number larger than 10: ");
//     string userInput = Console.ReadLine();
    
//     if(userInput == "stop"){
//         break;
//     }
//     enteredNumber =  int.Parse(userInput);
// } while (enteredNumber < 10);


// given numbers print all the numbers in the console unless it is divisible by 3, use continue
// int n = 10;
// for(int i = 1; i< n; i++){
//     if(i%3==0){
//         continue;
//     }
//     System.Console.WriteLine(i);
// }
// continue is used to skip while break is used to terminate the loop
// calculate the sum of all arrays

// int[] numbers = {1,2,3,4,5};

// int sum = 0;

// for(int i = 0; i <= numbers.Length ; i++){
//     sum = sum + i;
// }

// System.Console.WriteLine(sum);

//TODO : find a max value from a 1d array

// multi-dimensional arrays declare a 2d array 3 by 3

int[,] grid = new int[3,3]; // this is when you dont know the values

int[,] grid2 = {{1, 2, 3}, {1, 5, 5}, {4, 5, 1}}; // declaring and initializing a 2d array og size 3 by 3

// given a 3 by 2 array find the maximum value 

int[,] numbers = {{3,5}, {-1,12}, {4,0}};

int height = numbers.GetLength(0);
int width = numbers.GetLength(1);

