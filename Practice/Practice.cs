// System.Console.WriteLine("How many points did the student get");

// string userInput = Console.ReadLine();

// int points = int.Parse(userInput);

// char grade;

// switch (points){
//     case 9:
//     case 10:
//         grade = 'A';
//         break;
//     case 8:
//     case 7:
//     case 6: 
//         grade = 'B';
//         break;
//     case 5:
//     case 4:
//     case 3:
//         grade = 'C';
//         break;
//     case 2:
//     case 1:
//         grade = 'D';
//         break;
//     default:
//         grade = '!';
//         break;
// }

// System.Console.WriteLine("Your grade is: "+ grade);


// while loop

// int number = 0;
// while (number < 10){
//     System.Console.WriteLine("The number is less than 10: "+number);
//     //number = number + 1;
//     //number += 1;
//     number ++; // this one is used when you want to increment by 1
//     }
// System.Console.WriteLine("The loop");

/*

While loop - CalculateSumOfNumbersBetween

Using the while loop, implement the CalculateSumOfNumbersBetween method, 
which given two integers called firstNumber and lastNumber, should calculate 
the sum of numbers between them (including the numbers themselves).


If lastNumber is smaller than firstNumber, the result shall be 0.

For example:

    for firstNumber equal to 5 and lastNumber equal to 10, the result should be 45
     because this is the sum of numbers 5, 6, 7, 8, 9, 10

    for firstNumber equal to -5 and lastNumber equal to 5, the result should be 0 
    because this is the sum of numbers -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5

    for firstNumber equal to 10 and lastNumber also equal to 10, the result should be 10 
    because, to the sum, we include the only number, which is 10

    for firstNumber equal to 5 and lastNumber equal to 4, the result should be 0 because 
    the lastNumber is smaller than firstNumber

*/
// int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber){
    
//     }


int x = 5;
int y = 10;

int z = x;

int sum = 0;

while (z <= y){
    sum += z;
    z++;
    System.Console.WriteLine(z);
}

System.Console.WriteLine(sum);
