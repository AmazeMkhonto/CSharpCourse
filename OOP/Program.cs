
// // var result = new Rectangle(2,2);

// // System.Console.WriteLine(result);
// // class Rectangle
// // {
// //     // these are called fields
// //     int height;
// //     int width;


// //     // this here is a constructor
// //     public Rectangle(int height_, int width_){
// //         height = height_;
// //         width = width_;
// //     }


// //     public int calaculateArea(){
// //         return height * width;
// //     }

// // }




// // a readonly field can only be assigned in the declaration or in the constructor
// // it cannot be possible to change the vale of a readonly
// // you can set them in the constructor though
// // value is a special case yes use value do not worry about that a lot 


// // object initializers 
// // fuck i am not understanding this at all


// // if the properties of a class are publictly setable we can use "object initializers"



// // we couls create oblect of the class using the constructor
// // var person = new Person("Amaze", 1920); 


// // or use an object initializer

// var person = new Person{
//     Name = "something",
//     YearOfBirth = 1900
// };
// class Person {
    

//     public string Name {get;set;}
//     public int YearOfBirth {get;set;}


// // because we used an oblect initializer we do not need to use a constructor
//     // public Person(string name, int yearOfBirth)
//     // {
//     //     Name = name;
//     //     YearOfBirth = yearOfBirth;
//     // }

// }



//this class here is violating the SRP, go to OOP_part2 to find the fixed one

Names names = new Names();
var path = names.BuildFilePath();
if(File.Exists(path)){
    System.Console.WriteLine("File already exists. Loading names...");
    names.readFromTextFile();

} else {
    System.Console.WriteLine("names file does not exist yet");

    names.AddName("Claire");
    names.AddName("This should not be a valid name");
    names.AddName("Tony");
    names.AddName("Amaze");
    names.AddName("123 not you");

    System.Console.WriteLine("Svaing names to the file");
    names.WriteToTextFile();

}

System.Console.WriteLine(names.Format());

class Names {

    private List<string> _names = new List<string>();

    public void AddName(string name){
        if(isValidName(name)){
            _names.Add(name);
        }
    }


    private bool isValidName(string name){
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    } 

    public void readFromTextFile(){
        var fileContents = File.ReadAllText(BuildFilePath());
        var nameFromFile = fileContents.Split(Environment.NewLine).ToList();
        foreach(var name in nameFromFile){
            AddName(name);
        }

    }

    public void WriteToTextFile(){
        File.WriteAllText(BuildFilePath(), Format());
    }

    public string BuildFilePath(){
        return "names.txt";
    }

    public string Format(){
        return string.Join(Environment.NewLine, _names);

    }


}