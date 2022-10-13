using System;
class BigStudent: Person{
    private string id;
    private string email;
    private string password;

    public BigStudent (string title, string name, string surname, string age, string allergy, string religion, bool BeAdmin)
    : base(title,name,surname,age,allergy,religion,BeAdmin)
    {
        this.id = id;
    }
    public string GetStudentID()
    {
        return this.id;
    }
    public string Getemail(){
            return this.email;
        }
        public string Getpassword(){
            return this.password;
        }
    

}