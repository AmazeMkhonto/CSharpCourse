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


class NamesValidator{
    public bool isValidName(string name){
        return name.Length >= 2 && name.Length < 25 && char.IsUpper(name[0]) && name.All(char.IsLetter);
    } 


}

class Names {

    private List<string> _names = new List<string>();

    public void AddName(string name){
        if(new NamesValidator().isValidName(name)){
            _names.Add(name);
        }
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