class MedicalAppointments{
    private string _patientName;
    private DateTime _date;

var result = new Rectangle(2,2);

System.Console.WriteLine(result);
class Rectangle
{
    // these are called fields
    int height;
    int width;


    // this here is a constructor
    public Rectangle(int height_, int width_){
        height = height_;
        width = width_;
    }


    public int calaculateArea(){
        return height * width;
    }

}

