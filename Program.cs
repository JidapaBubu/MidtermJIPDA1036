class Program{
    static PersonList personList;
    static void Main(string[]args){
        Program.personList = new PersonList();
        PrintMenuSceen();
        
    }
    static void PrintMenuSceen(){
        noLogiMenu();
    }
    static void noLogiMenu(){
        
        Console.WriteLine("Welcome to Idia CAMP 2022 registration system");
        Console.WriteLine("**************************************************");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for Show attendees");
        Console.WriteLine("3 for Login");
        Console.WriteLine("4 for Exist");
        Console.WriteLine("**************************************************");
       
        int n = int.Parse(Console.ReadLine());
        switch(n){
            case 1:{RegisterMenu();break;}
           
            case 3:{LoginMenu();break;}
            case 4:break;
            default: break;
        }

        
    }
     public static void LoginMenu(){
        
        Console.WriteLine("Welcome to Idia CAMP 2022");
        Console.WriteLine("1 for Register");
        Console.WriteLine("2 for show all current students");
        Console.WriteLine("3 for show students");
        Console.WriteLine("4 for show teachers");
        Console.WriteLine("5 for Log Out");

        int n = int.Parse(Console.ReadLine());
        switch(n){
            case 1:{RegisterMenu();break;}
         
            case 5:break;
            default: break;
        }
          

        }
         static void RegisterMenu()
        {
           Console.WriteLine("Welcome, Please choose your type:");
           Console.WriteLine("1 for Current student");
           Console.WriteLine("2 for Students");
           Console.WriteLine("3 for Teachers");

           int n = int.Parse(Console.ReadLine());
           if (n == 1){InputCurrentstudent();}
           if (n == 2){InputNewStudent();}
           if (n == 3){InputNewTeacher();}
        }
       
        
        static void InputCurrentstudent(){
        Console.WriteLine("Register New Current student");
        Console.WriteLine("***************************");
        
        string title = ChooseTitle();

        Console.WriteLine("Please input Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please input Surname:");
        string surname = Console.ReadLine();

        while(personList.CheckPersonName(title,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");

            Console.WriteLine("Please input Name:");
            name = Console.ReadLine();

            Console.WriteLine("Please input Surname:");
            surname = Console.ReadLine();
        }

        Console.WriteLine("Please input ID:");
        string id = Console.ReadLine();

        Console.WriteLine("Please input Age:");
        string age = Console.ReadLine();

        Console.WriteLine("Please input Allergy:");
        string allergy = Console.ReadLine();

        Console.WriteLine("Please input Religion:");
        string religion = ChooseReligion();
        Console.WriteLine("***************************");
        
        bool BeAdmin = false;
        string email ="",password ="";
        Console.Write("Are you an Admin?(Y/N):");
        string n = Console.ReadLine();
        if (n=="Y"){BeAdmin = true;}

        if(personList.Checkemail(email)){
            Console.WriteLine("Invalid email. Please try again.");
            InputCurrentstudent();
            return;

        }
        PrintMenuSceen();
    
        }
        static void InputNewStudent(){
        Console.WriteLine("Register New student");    
        Console.WriteLine("***************************");
        
        string title = ChooseTitle();

        Console.WriteLine("Please input Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please input Surname:");
        string surname = Console.ReadLine();

         while(personList.CheckPersonName(title,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");

            Console.WriteLine("Please input Name:");
            name = Console.ReadLine();

            Console.WriteLine("Please input Surname:");
            surname = Console.ReadLine();
        }

        Console.WriteLine("Please input Age:");
        string age = Console.ReadLine();

        Console.WriteLine("Please input Grade:");
        string grade = ChooseGrade();

        Console.WriteLine("Please input Allergy:");
        string allergy = Console.ReadLine();

       
        string religion = ChooseReligion();

        Console.WriteLine("Please input School:");
        string school = Console.ReadLine();
        Console.WriteLine("***************************");
        PrintMenuSceen();
        }
       
        
        static void InputNewTeacher(){
        Console.WriteLine("Register New Teacher");
        Console.WriteLine("***************************");
        
        string title = ChooseTitle();

        Console.WriteLine("Please input Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please input Surname:");
        string surname = Console.ReadLine();

         while(personList.CheckPersonName(title,name,surname))
        {
            Console.WriteLine("User is already registered. Please try again.");

            Console.WriteLine("Please input Name:");
            name = Console.ReadLine();

            Console.WriteLine("Please input Surname:");
            surname = Console.ReadLine();
        }

        Console.WriteLine("Please input ID:");
        string id = Console.ReadLine();

        Console.WriteLine("Please input Age:");
        string age = Console.ReadLine();

        Console.WriteLine("Please input Position:");
        string position = ChoosePosition();

        Console.WriteLine("Please input Allergy:");
        string allergy = Console.ReadLine();

        
        string religion = ChooseReligion();
        Console.WriteLine("***************************");
        
        string car = "";
        Console.Write("Are you bring Car?(Y/N)");
        string n = Console.ReadLine();
        if (n=="Y"){car = Console.ReadLine();}
        

        bool BeAdmin = false;
        string email ="",password ="";
        Console.Write("Are you an Admin?(Y/N):");
        n = Console.ReadLine();
        if (n=="Y"){BeAdmin = true;}
        
        if(personList.Checkemail(email)){
            Console.WriteLine("Invalid email. Please try again.");
            InputNewTeacher();
            return;

        }
        PrintMenuSceen();
    
        }
        
        
        static string ChooseTitle(){
            Console.WriteLine("Please Choose Title:");
            Console.WriteLine("1 for Mr.");
            Console.WriteLine("2 for Ms.");
            Console.WriteLine("3 for Mrs.");
            int n = int.Parse(Console.ReadLine());
            switch(n){
                case 1: return "Mr.";
                case 2: return "Ms.";
                case 3: return "Mrs.";
                default : return ChooseTitle();break;
            }
            
           
        }
        static string ChooseReligion(){
            Console.WriteLine("Please Choose Religion:");
            Console.WriteLine("1 for Buddhist");
            Console.WriteLine("2 for Christ");
            Console.WriteLine("3 for islam");
            Console.WriteLine("4 for other");
           int n = int.Parse(Console.ReadLine());
           switch(n){
            case 1: return "Buddhist";
            case 2: return "Christ";
            case 3: return "islam";
            default : return ChooseReligion();break;
           } 
        }
        static string ChooseGrade(){
            Console.WriteLine("Please Choose Grade:");
            Console.WriteLine("1 for m4");
            Console.WriteLine("2 for m5");
            Console.WriteLine("3 for m6");
           int n = int.Parse(Console.ReadLine());
           switch(n){
            case 1: return "m4";
            case 2: return "m5";
            case 3: return "m6";
            default : return ChooseGrade();break;
           } 
        }
        static string ChoosePosition(){
            Console.WriteLine("Please Choose Position:");
            Console.WriteLine("1 for dean");
            Console.WriteLine("2 for department head");
            Console.WriteLine("3 for full-time teacher");
           int n = int.Parse(Console.ReadLine());
           switch(n){
            case 1: return "dean";
            case 2: return "department head";
            case 3: return "full-time teacher";
            default : return ChoosePosition();break;
           } 
        }



   
}