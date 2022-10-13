using System;
class PersonList
{
    private List<Person> personList;

    public PersonList()
    {
        this.personList = new List<Person>();
    }
    public void AddNewPerson(Person person)
    {
        this.personList.Add(person);
    }
    
    public bool CheckPersonName(string title,string name,string surname){
        foreach(Person p in personList){
            if(p.GetTitle()==title&&p.GetName()==name&&p.GetSurname()==surname){
                return true;
            }
        }
        return false;
    }

    public bool Checkemail(string email){
        foreach(Person p in personList){
            if(p.GetAdmin()){
                if(p is BigStudent ){
                    BigStudent currstu = (BigStudent)p;
                    if((currstu.Getemail()==email)){return true;}
                }
                else if (p is Teacher){
                    Teacher teacher = (Teacher)p;
                    if((teacher.Getemail()==email)){return true;}
                }
            }
        }
        return false;
        
    }
    
}