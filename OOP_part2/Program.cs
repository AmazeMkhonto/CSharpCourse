Names names = new Names();

StringsTextualRepository stringsText = new StringsTextualRepository();

var path = names.BuildFilePath();

if(File.Exists(path)){
    System.Console.WriteLine("File already exists. Loading names...");
    var stringsFromFile = stringsText.Read(path);
    names.AddNames(stringsFromFile);
    

} else {
    System.Console.WriteLine("names file does not exist yet");

    names.AddName("Claire");
    names.AddName("This should not be a valid name");
    names.AddName("Tony");
    names.AddName("Amaze");
    names.AddName("123 not you");

    System.Console.WriteLine("Svaing names to the file");
    stringsText.Write(path, names.All);

}

System.Console.WriteLine(names.Format());



class NamesValidator{
    public bool isValid(string name){
        return name.Length >= 2 
                && name.Length < 25 
                && char.IsUpper(name[0]) 
                && name.All(char.IsLetter);
    } 
}


class StringsTextualRepository {

    private static readonly string _separator = Environment.NewLine;

    public List<string> Read(string filePath){
        var fileContents = File.ReadAllText(filePath);
        return  fileContents.Split(_separator).ToList();
    }

    public void Write(string filePath, List<string> strings){
        File.WriteAllText(filePath, string.Join(_separator, strings));
    }

}

class Names {

    public List<string> All {get;} = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();


    public void AddNames(List<string> stringsFromFile){
        foreach (var name in stringsFromFile){
            AddName(name);
        }
    }

    public void AddName(string name){
        if(_namesValidator.isValid(name)){
            All.Add(name);
        }
    }


    public string BuildFilePath(){
        return "names.txt";
    }

    public string Format(){
        return string.Join(Environment.NewLine, All);

    }

   


}