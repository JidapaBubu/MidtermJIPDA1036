public class Teacher: Person {
 private string position;
 private string car;
 private string email;
 private string password;

 public Teacher(string title,string name,string surname,string age,string position,string allergy,string religion,string car,bool BeAdmin,string email,string password)
    : base(title,name,surname,age,allergy,religion,BeAdmin) 
    {
        this.position = position;
        this.car = car;
        this.email = email;
        this.password = password;
    }
    public string Getemail(){
         return this.email;
    }
    public string Getpassword(){
        return this.password;
    }
}