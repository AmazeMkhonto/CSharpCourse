//todo: write the todo to a point where you are asking the user for input and displaying
//to them what they have chosen, make use of 1.print, 2.get input, 3.conditionals and 4.methods

Console.WriteLine("Hello");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

// if(userChoice.ToUpper() == "S"){
//     userSelection("See all TODOS");
// } else if (userChoice.ToUpper() == "A"){
//     userSelection("Add all TODOs");
// } else if (userChoice.ToUpper() == "R"){
//     userSelection("Remove a TODO");
// } else if(userChoice.ToUpper() == "E"){
//     userSelection("Exit");
// } else{
//     System.Console.WriteLine("You did not select a valid option");
// }

switch(userChoice.ToUpper()){
    case "S":
        userSelection("See all TODOS");
        break;

    case "A":
        userSelection("Add all TODOs");
        break;

    case "R":
        userSelection("Remove a TODO");
        break;

    case "E":
        userSelection("Exit");
        break;

    default:
        Console.WriteLine("You did not select a valid option");
        break;
    }


void userSelection (string userCHoice){
    System.Console.WriteLine("You have chosen to: "+userCHoice);
}


