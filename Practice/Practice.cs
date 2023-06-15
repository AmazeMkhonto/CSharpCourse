

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


// int[] array = {7,1,2,3, 20 ,4,5,-2, 0};

// int maxNum = 0;

// for(int i = 0; i < array.Length; i++){
//     if(array[i] > maxNum){
//         maxNum = array[i];
//     }
// }
// System.Console.WriteLine(maxNum);


// multi-dimensional arrays declare a 2d array 3 by 3

int[,] grid = new int[3,3]; // this is when you dont know the values

int[,] grid2 = {{1, 2, 3}, {1, 5, 5}, {4, 5, 1}}; // declaring and initializing a 2d array og size 3 by 3

// given a 3 by 2 array find the maximum value 
// if the array is empty return -1

// int[,] numbers = {{3,5}, {-1,12}, {4,0}};
// int[,] numbers = {};

// int height = numbers.GetLength(0);
// int width = numbers.GetLength(1);

// int maxNumber = 0;

// System.Console.WriteLine(height);
// System.Console.WriteLine(width);
// if(height == 0 && width == 0){
//     maxNumber = -1;
// } else {
// for(int i = 0; i < height; i++){
//     for(int j = 0; j < width; j++){
//         if(numbers[i,j] > maxNumber){
//             maxNumber = numbers[i,j];
//         }
//     }
// }
// }

// System.Console.WriteLine(maxNumber);



// lists

//declare 
List<string> names1 = new List<string>();

// declare and initialise
List<string> names = new List<string>(){"amaze", "mkhonto"};

names.AddRange(new List<string>(){"fuck", "this", "shit"}); // pass in a list
names.AddRange(new string[] {"amy", "Jimmy"}); // pass in an array

//names.Clear(); // now the list should be empty

//names.Contains("fuck");

// System.Console.WriteLine("Is the word fuck in the List?: "+names.Contains("fuck")); // this should print out true or false

// System.Console.WriteLine("In what index is the word fuck?: "+names.IndexOf("fuck")); // returns the index in which the word is in
// foreach(string name in names){
//     System.Console.WriteLine(name);
// }



// System.Console.WriteLine("The length of the List is: "+names.Count);


// in this list only return the values with uppercase, if there are duplicates like 
//this one  {"one", "TWO", "THREE", "four", "TWO"} dont give me the duplicated value
// This {"one", "TWO123", "THREE!&^", "four"} should return an empty list
// we are returning lists

// List<string> theNumbers = new List<string>() {"one", "TWO", "THREE", "four", "TWO"};

// List<string> emptyList = new List<string>();

// foreach(string num in theNumbers){
//     bool isUpperCase = true;
//     bool isLetter = true;
//     foreach (char character in num){
//         isUpperCase =  char.IsUpper(character);
//         isLetter = char.IsLetter(character);
//     }
//     if(isUpperCase && isLetter && !(emptyList.Contains(num))){
//         emptyList.Add(num);
//     }
// }

// foreach(string words in emptyList){
//     System.Console.WriteLine(words);
// }




// // lets say you are given an array of numbers, you aregoing to take it in as a parameter 
// int[] numbers2 = {1, -1,2,-2,3,-3};
// int countNegative;

// List<int> GetPositiveNumbers(int[] numbers, out int countNegative) {
//     List<int> emptyList = new List<int>();
//     countNegative = 0;
//     foreach(int number in numbers ){
//         if(number > 0){
//             emptyList.Add(number);
//         } else {
//             countNegative ++;
//         }
//     }
//     return emptyList;
// }

// List<int> x = GetPositiveNumbers(numbers2, out countNegative); // because the function returns a list it means the variable that you assign to this is going to be a list as well
// foreach(int num in x){
//     System.Console.WriteLine(num);
// }
// System.Console.WriteLine("This is the number of negative numbers: "+countNegative);










// //tryparse situation
// System.Console.WriteLine("Enter any number");
// string userInput = Console.ReadLine();
// //int number = int.Parse(userInput); // if the user enters a non digit we are going to get a runtime error, so we are going to use tryParse so that we avoid that situation

// bool isParsingSuccessful = int.TryParse(userInput, out int number);


// if(isParsingSuccessful){
//     System.Console.WriteLine("parsing has worked "+ number);
// } else {
//     System.Console.WriteLine("parsing did now work "+ number);
// }

// Ask the user to enter a number until they give a valid input


bool isParsingSuccessful;

do{

    System.Console.WriteLine("Please enter a number");
    string userInput = Console.ReadLine();
    
    isParsingSuccessful = int.TryParse(userInput, out int number);

    if(isParsingSuccessful){
        System.Console.WriteLine("Congratufuckinglations i guess "+number);
    } else {
        System.Console.WriteLine("bro enter a valid number before i kick you in the teeth "+number);
    }
}while(!isParsingSuccessful);