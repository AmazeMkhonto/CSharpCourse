using System;
using System.Linq;
using System.Text.RegularExpressions;

// public class RockPaperScissors {

//   public static string Rps(string p1, string p2){
//     string answer = "";
//     if(p1 == p2){
//       answer = "Draw!";
//     } else if((p1 == "rock" && p2 == "scissors") || 
//         (p1 == "scissors" && p2 == "paper") || (p1 == "paper" && p2 == "rock")){
//           answer = "Player 1 won!";
//         } else {
//           answer = "Player 2 won!";
//         }
//     return answer;
//   }

// public static void Main(string[] args)
//   {
//     string[] plays = {"scissors", "rock", "paper"};
//     string p1;
//     string p2;
//     System.Console.WriteLine();
//     do{
//       System.Console.WriteLine("Player 1 what do you want to play");
//       p1 = Console.ReadLine();
//       System.Console.WriteLine();
//       System.Console.WriteLine("Player 2 what do you want to play");
//       p2 = Console.ReadLine();

//       if(!plays.Contains(p1)){
//         System.Console.WriteLine("Player 1 your move was not valid");
//       } else if(!plays.Contains(p2)){
//         System.Console.WriteLine("Player 2 your move was no valid");
//       } 
//     } while(!plays.Contains(p1) || !plays.Contains(p2));
    

//     string answer = Rps(p1,p2);
//     System.Console.WriteLine(answer);
//   }

// }




/*
Given a non-negative integer, 3 for example, return a string with a 
murmur: "1 sheep...2 sheep...3 sheep...". Input will always be valid, i.e. no negative integers.
*/

// static string CountSheep(int n)
//   {
//     string answer = "";
//     for(int i = 1; i <= n; i++){
//       answer += $"{i} sheep...";
//     }
//     return answer;
//   }

// string result = CountSheep(3);
// System.Console.WriteLine(result);


// static string greet() => "hello world!";  // this is how simple you can make a function with only one piece of code




/*
Every day you rent the car costs $40. If you rent the car for 7 or more days, 
you get $50 off your total. Alternatively, if you rent the car for 3 or more days,
 you get $20 off your total.

Write a code that gives out the total amount for different days(d).
*/
// static int RentalCarCost(int d) {
//   int total = 0;
//   for(int i = 0; i < d; i++){
//     total += 40;
//   }
//   if((d>=3) && (d<7)) total -=20;
//   if(d>=7) total-=50;
//   return total;
// }
// int answer = RentalCarCost(7);
// System.Console.WriteLine(answer);





/*
Write function bmi that calculates body mass index (bmi = weight / height2).
if bmi <= 18.5 return "Underweight"
if bmi <= 25.0 return "Normal"
if bmi <= 30.0 return "Overweight"
if bmi > 30 return "Obese"
*/
// static string Bmi(double weight, double height)
//   {
//     double heightSquared = Math.Pow(height,2);
//     double bmi = weight/heightSquared;

//     switch(bmi){
//       case <= 18.5:
//         return "Underweight";
//       case <= 25.0:
//         return "Normal";
//       case <= 30.0:
//         return "Overweight";
//       case > 30:
//         return "Obese";
//     }
//     return "";
//   }


// string a = Bmi(63,1.66);
// System.Console.WriteLine(a);












/*
Given a set of numbers, return the additive inverse of each. 
Each positive becomes negatives, and the negatives become positives.

invert([1,2,3,4,5]) == [-1,-2,-3,-4,-5]
invert([1,-2,3,-4,5]) == [-1,2,-3,4,-5]
invert([]) == []
*/

//  static int[] InvertValues(int[] input)
//   {
//     for(int i = 0; i< input.Length ; i++){
//       input[i] = - input[i] ;
//     }
//     return input;
//   }

// int[] a = {1,2,3,4,5};
// int[] array = InvertValues(a);

// foreach(int i in array){
//   System.Console.WriteLine(i);
// }











/*
A hero is on his way to the castle to complete his mission. 
However, he's been told that the castle is surrounded with a 
couple of powerful dragons! each dragon takes 2 bullets to be 
defeated, our hero has no idea how many bullets he should carry..
Assuming he's gonna grab a specific given number of bullets and
move forward to fight another specific given number of dragons, will he survive?

Return true if yes, false otherwise :)
// */
// static bool Hero(int bullets, int dragons)
// {

//   return bullets >= 2 * dragons ;
  
// }

// System.Console.WriteLine(Hero(2,2)); //Hero(2,2) returns false ans Hero(2,1) should return true


// if its a square return an area if rectange return perimeter
// static int AreaOrPerimeter(int l, int w) {
//         return l == w ? l * w : (l + w) * 2;
//     }


    // static string EvenOrOdd(int number)
    // {
    //   return number % 2 == 0 ? "Even" : "Odd";
    // }

    // because the function above only has 1 line of code it can be written this way i am no sure if tat is the  best practice
    //  static string EvenOrOdd(int number) => number % 2 == 0 ? "Even" : "Odd";
    
    // now my question becomes does short code mean better code?








    /*
    A square of squares
You like building blocks. You especially like building blocks that are squares. 
And what you even like more, is to arrange them into a square of square building blocks!
However, sometimes, you can't arrange them into a square. Instead, you end up with an ordinary
 rectangle! Those blasted things! If you just had a way to know, whether you're currently working in vain… Wait! 
 That's it! You just have to check if your number of building blocks is a perfect square.

Task
Given an integral number, determine if it's a square number:

In mathematics, a square number or perfect square is an integer that is the square of an integer; 
in other words, it is the product of some integer with itself.

The tests will always use some integral number, so don't worry about that in dynamic typed languages.

Examples
-1  =>  false
 0  =>  true
 3  =>  false
 4  =>  true
25  =>  true
26  =>  false
    */


//  static bool IsSquare(int n)
//   {
//      int squareRoot = (int)Math.Sqrt(n);
//   return squareRoot * squareRoot == n;

//   }

//   System.Console.WriteLine(IsSquare(4));



/*
Complete the solution so that it returns true if the first 
argument(string) passed in ends with the 2nd argument (also a string).

Examples:

solution('abc', 'bc') // returns true
solution('abc', 'd') // returns false
*/
//  static bool Solution(string str, string ending)
//   {
//     return str.EndsWith(ending);
//   }











/*
Take 2 strings s1 and s2 including only letters from a to z. 
Return a new sorted string, the longest possible, 
containing distinct letters - each taken only once - coming from s1 or s2.

Examples:
a = "xyaabbbccccdefww"
b = "xxxxyyyyabklmopq"
longest(a, b) -> "abcdefklmopqwxy"

a = "abcdefghijklmnopqrstuvwxyz"
longest(a, a) -> "abcdefghijklmnopqrstuvwxyz"

*/

// string a = "xyaabbbccccdefww";
// string b = "xxxxyyyyabklmopq";
// static string Longest (string s1, string s2) 
//   {
//     string result = s1 + s2;
//     string res = new string(result.Distinct().ToArray());

//     char[] characters = res.ToCharArray();
//     Array.Sort(characters);
//     string sortedString = new string(characters);

//     return sortedString;
//   }
  
// string res = Longest(a,b);
// System.Console.WriteLine(res);













/*
This time no story, no theory. The examples below show you how to write function accum:

Examples:
accum("abcd") -> "A-Bb-Ccc-Dddd"
accum("RqaEzty") -> "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy"
accum("cwAt") -> "C-Ww-Aaa-Tttt"
The parameter of accum is a string which includes only letters from a..z and A..Z.
*/

// static String Accum(string s) 
//   {
//     string result = "";
//     for(int i=0; i < s.Length; i++){
//         result = result + s[i];
//     }
//     return "";
//   }

// string answer = Accum("abcd");
// System.Console.WriteLine(answer);







// this has to be a nightmare





















/*
Your task is to make a function that can take any non-negative integer 
as an argument and return it with its digits in descending order. Essentially, 
rearrange the digits to create the highest possible number.
Examples:
Input: 42145 Output: 54421
Input: 145263 Output: 654321
Input: 123456789 Output: 987654321
*/

// static int DescendingOrder(int num)
//   {
//     string numberString = num.ToString();

//     char[] charArray = numberString.ToCharArray();

//     Array.Sort(charArray);
//     Array.Reverse(charArray);

//     string sortedNumberString = new string(charArray);

//     int sortedNumber = int.Parse(sortedNumberString);

//     return sortedNumber;

//     // return int.Parse(string.Concat(num.ToString().OrderByDescending(x => x)));

//   }

//   int answer = DescendingOrder(42145);
//   System.Console.WriteLine(answer);


























/*
Given two integers a and b, which can be positive or negative, 
find the sum of all the integers between and including them and 
return it. If the two numbers are equal return a or b.

Note: a and b are not ordered!
Examples (a, b) --> output (explanation)

(1, 0) --> 1 (1 + 0 = 1)
(1, 2) --> 3 (1 + 2 = 3)
(0, 1) --> 1 (0 + 1 = 1)
(1, 1) --> 1 (1 since both are same)
(-1, 0) --> -1 (-1 + 0 = -1)
(-1, 2) --> 2 (-1 + 0 + 1 + 2 = 2)

Your function should only return a number, not the explanation about how you get that number.
*/


// int GetSum(int a, int b)
//   {
//     int sum = a;
//     for(int i = a; i <= b; i++){
//       sum = sum + i;
//     }
//     return sum;
//   }

// int answer = GetSum(1,3);
// System.Console.WriteLine(answer);

// int a = 0;
// int b = -1;
// int sum = 0;
// if(a < b){
//   for(int i = a; i <= b; i++){
//   System.Console.WriteLine(i);
//   sum = sum + i;
//   }
// } else{
//   for(int i = b; i <= a; i++){
//   System.Console.WriteLine(i);
//   sum = sum + i;
//   }
// }

// System.Console.WriteLine(sum);

// return (a + b) * (Math.Abs(a - b) + 1) / 2;

















/*
ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain
 anything but exactly 4 digits or exactly 6 digits.

If the function is passed a valid PIN string, return true, else return false.
Examples (Input --> Output)

"1234"   -->  true
"12345"  -->  false
"a234"   -->  false
*/
// using System.Text.RegularExpressions;

// static bool ValidatePin(string pin)
//   {
//     // this code checks if there is no new lines
//     //  if (pin.Contains("\n") || pin.Contains("\r"))
//     //     {
//     //         return false;
//     //     }
//     bool cond1 = Regex.IsMatch(pin, @"^\d{6}$");
//     bool cond2 = Regex.IsMatch(pin, @"^\d{4}$");
//     if(cond1 || cond2){
//       return true;
//     }
//     return false; 

//     // return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
    
//   }

  




























/*
Write a function to convert a name into initials. 
This kata strictly takes two words with one space in between them.
The output should be two capital letters with a dot separating them.
It should look like this:
Sam Harris => S.H
patrick feeney => P.F
*/
// static string AbbrevName(string name)
//   {
//     return "";
//   }
















/*
An isogram is a word that has no repeating letters, 
consecutive or non-consecutive. Implement a function 
that determines whether a string that contains only 
letters is an isogram. Assume the empty string is an 
isogram. Ignore letter case.

Example: (Input --> Output)

"Dermatoglyphics" --> true "aba" --> false "moOse" --> false (ignore letter case)

isIsogram "Dermatoglyphics" = true
isIsogram "moose" = false
isIsogram "aba" = false

*/

// string a = "Dermatoglyphics";
// string  b = "moOse";
// string c ="aba";
// string d = "Dermatoglypphics";


// static bool IsIsogram(string str) 
//   {
    
//     string lowercaseStr = str.ToLower();
//     string res = new string(lowercaseStr.Distinct().ToArray());
//     char[] characters = res.ToCharArray();
//     string result = new string (characters);
//     if (string.Equals(str, result, StringComparison.CurrentCultureIgnoreCase))
//     {
//         return true;
//     }
//     else
//     {
//     return false;
//     }
//     // return str.ToLower().Distinct().Count()==str.Length;
//   }
// bool result = IsIsogram(b);
// System.Console.WriteLine(result);



















/*
Given an array of ones and zeroes, convert the equivalent binary value to an integer.

Eg: [0, 0, 0, 1] is treated as 0001 which is the binary representation of 1.

Examples:

Testing: [0, 0, 0, 1] ==> 1
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 0, 1] ==> 5
Testing: [1, 0, 0, 1] ==> 9
Testing: [0, 0, 1, 0] ==> 2
Testing: [0, 1, 1, 0] ==> 6
Testing: [1, 1, 1, 1] ==> 15
Testing: [1, 0, 1, 1] ==> 11

However, the arrays can have varying lengths, not just limited to 4.


 static int binaryArrayToNumber(int[] BinaryArray)
  {
    //Code here
  }

  namespace Solution {
  using NUnit.Framework;
  using System;
  [TestFixture]
  public class SolutionTest
  {
    int[] Test1 = new int[] {0,0,0,0};
    int[] Test2 = new int[] {1,1,1,1};
    int[] Test3 = new int[] {0,1,1,0};
    int[] Test4 = new int[] {0,1,0,1};
    [Test]
    public void BasicTesting()
    {
      Assert.AreEqual(0 , Kata.binaryArrayToNumber(Test1));
      Assert.AreEqual(15 , Kata.binaryArrayToNumber(Test2));
      Assert.AreEqual(6 , Kata.binaryArrayToNumber(Test3));
      Assert.AreEqual(5 , Kata.binaryArrayToNumber(Test4));
    }
  }
}
*/





















/*
Given a list of integers, determine whether the sum of its elements is odd or even.

Give your answer as a string matching "odd" or "even".

If the input array is empty consider it as: [0] (array with a zero).
Examples:

Input: [0]
Output: "even"

Input: [0, 1, 4]
Output: "odd"

Input: [0, -1, -5]
Output: "even"

*/


static string OddOrEven(int[] array)
  {
    int sum = 0;
    for(int i = 0; i < array.Length ; i++){
      sum = sum + array[i];
    }

    if(sum % 2 == 0){
      return "even";
    } else {
      return "odd";
    }

    //return array.Sum() % 2 == 0 ? "even" : "odd";
  }

int[] array = {0, -1, -5};

string answer = OddOrEven(array);
System.Console.WriteLine(answer);