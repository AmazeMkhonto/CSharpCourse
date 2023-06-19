Console.WriteLine("Hello");

string userInput;
List<string> TODOs = new List<string>();

do{
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

userInput = Console.ReadLine();

switch(userInput.ToUpper()){
    case "S":
        seeTodos();
        break;

    case "A":
        addTodos();
        break;

    case "R":
        removeTodos();
        break;

    case "E":
        System.Console.WriteLine("Exit");
        break;

    default:
        Console.WriteLine("Incorrect input");
        break;
    }

} while(userInput.ToUpper() != "E");



void seeTodos(){
    if(TODOs.Count > 0){
            for(int i = 0; i < TODOs.Count; i++){
                System.Console.WriteLine((i+1)+". "+TODOs[i]);
            } 
        } else {
            System.Console.WriteLine("No TODOs have been added yet.");
        }
}

string description;
void addTodos(){
    do{
        System.Console.WriteLine("Enter the TODO description:");
        string description = Console.ReadLine(); 
        if((TODOs.Contains(description)) ){
            System.Console.WriteLine("The description must be unique");

        } else if((description.Length == 0)){
            System.Console.WriteLine("The description cannot be empty");
        } else {
            TODOs.Add(description);
            System.Console.WriteLine("TODO successfully added: "+description);
            break;
        }
    } while(!(TODOs.Contains(description)) && (description.Length != 0));

}


void removeTodos(){
    System.Console.WriteLine("Select the index of the TODO you want to remove:");
        seeTodos();
        string theIndex;
        bool isParsingSuccessful;
        do{
            theIndex = Console.ReadLine();
            isParsingSuccessful = int.TryParse(theIndex, out int number);
            if((isParsingSuccessful) && (number <= TODOs.Count)){
                int index = number-1;
                System.Console.WriteLine("TODO removed: "+TODOs[index]);
                TODOs.RemoveAt(index);
                break;
            }  else {
                System.Console.WriteLine("THE NUMBER "+number);
                System.Console.WriteLine("nope bro");
                
            }

        } while(!isParsingSuccessful );
}












