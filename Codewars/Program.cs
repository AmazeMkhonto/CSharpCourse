// using System;

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
static string Bmi(double weight, double height)
  {
    double heightSquared = Math.Pow(height,2);
    double bmi = weight/heightSquared;

    switch(bmi){
      case <= 18.5:
        return "Underweight";
      case <= 25.0:
        return "Normal";
      case <= 30.0:
        return "Overweight";
      case > 30:
        return "Obese";
    }
    return "";
  }


string a = Bmi(63,1.66);
System.Console.WriteLine(a);

