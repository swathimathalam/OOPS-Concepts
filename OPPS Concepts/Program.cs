 //Abstraction//
//abstract// class Employee
//{
//    public abstract int getproject();
//}
//class Developer : Employee
//{
//    private int project;
//    public Developer(int project)
//    {
//        project = project;
//        {
//            public override int getproject()
//    {
//        return project;
//    }
//}
//class Driver : Employee
//{
//    private double salary;
//    public Driver(double s)
//    {
//        salary = s;
//    }
//    public override double getsalary()
//    {
//        return salary;
//    }
//    class Test
//    {
//        public static void Main(String[] args)
//        {
//            Developer d1 = new Developer(1);
//            Developer d2 = new Developer(2);
//            int a, b;
//            a = d1.getproject();
//            b = d2.getsalary();
//            Console.WriteLine("project of Developer : {a}");
//            Console.WriteLine("salary of driver : {b}");
//        }
//    }
//}


//compiletime-polymorphisam//
//class Bankaccount
//{
//    public void accountbalance(string name, int pin)
//    {
//        Console.WriteLine("checked balance");
//    }
//    public void accountbalance(long accountno, int pin)
//    {
//        Console.WriteLine("check balance");
//    }
//    public static void Main(string[] args)
//    {
//        Bankaccount a1 = new Bankaccount();
//        a1.accountbalance("swathi", 234);
//        a1.accountbalance(563462276363, 4567);
//        Console.ReadLine();
//    }
//}



//runtime-polymorphisam//
//class Login
//{
//    public void whatsapp(String name, int passwrd)
//   {
//      Console.WriteLine("login whatsapp");
//    }
//    public void whatsapp(String name, String password)
//    {
//        Console.WriteLine("login facebook");
//    }
//    public static void Main(String[] args)
//    {
//        Login l1 = new Login();
//        l1.whatsapp("swati", 1234);
//        l1.whatsapp("roja", "1234a");
//        Console.ReadLine();
//    }
//}



//Multiple Inheritece//
//class Bankaccount
//{
//    public void accountbalance(string name, int pin)
//    {
//        Console.WriteLine("checked balance");
//    }
//    public void accountbalance(long accountno, int pin)
//    {
//        Console.WriteLine("check balance");
//    }
//    public static void Main(string[] args)
//    {
//        Bankaccount a1 = new Bankaccount();
//        a1.accountbalance("swathi", 234);
//        a1.accountbalance(563462276363, 4567);
//        Console.ReadLine();
//    }
//}

//Multi-level inheritance//
//class Son : Father
//{
//    public void DisplayTwo()
//    {
//        Console.WriteLine("Son.. ");
//    }
//    static void Main(string[] args)
//    {
//        Son s = new Son();
//        s.Display();
//        s.DisplayOne();
//        s.DisplayTwo();
//        Console.Read();
//    }
//}
//class Grandfather
//{
//    public void Display()
//    {
//        Console.WriteLine("Grandfather...");
//    }
//}
//class Father : Grandfather
//{
//    public void DisplayOne()
//    {
//        Console.WriteLine("Father...");
//    }
//}

////single level inheritance//
//public class parent
//{
//    public static void displayparentsab()
//    {
//        Console.WriteLine("a and b are my parents");
//    }
//}
//public class son : parent
//{
//    public void displaysonc()
//    {
//        Console.WriteLine("i am the son c");
//    }

//    internal void displayparents()
//    {
//        throw new NotImplementedException();
//    }
//}
//public class program
//{
//    public static void main(string[] args)
//    {
//        son s = new son();
//        s.displaysonc();
//        s.displayparents();
//    }
//}


//hirerachial inheritance//
//bstract class Employee
//{
//    public abstract int getproject();
//}
//class Developer : Employee
//{
//    private int project;
//    public Developer(int project)
//    {
//        project = project;
//        {
//            public override int getproject()
//    {
//        return project;
//    }
//}
//class Driver : Employee
//{
//    private double salary;
//    public Driver(double s)
//    {
//        salary = s;
//    }
//    public override double getsalary()
//    {
//        return salary;
//    }
//    class Test
//    {
//        public static void Main(String[] args)
//        {
//            Developer d1 = new Developer(1);
//            Developer d2 = new Developer(2);
//            int a, b;
//            a = d1.getproject();
//            b = d2.getsalary();
//        }
//    }



    //interface//
//    lass Bankaccount
//    {
//    public void accountbalance(string name, int pin)
//    {
//        Console.WriteLine("checked balance");
//    }
//    public void accountbalance(long accountno, int pin)
//    {
//        Console.WriteLine("check balance");
//    }
//    public static void Main(string[] args)
//    {
//        Bankaccount a1 = new Bankaccount();
//        a1.accountbalance("swathi", 234);
//        a1.accountbalance(563462276363, 4567);
//        Console.ReadLine();
//    }
//}


//interface//
//public interface Drawable
//{
//    void draw();
//}
//public class Rectangle : Drawable
//{
//    public void draw()
//    {
//        Console.WriteLine("drawing rectangle");
//    }
//}
//public class circle : Drawable
//{
//    public void draw()
//    {
//        Console.WriteLine("drawing circle");
//    }
//}
//public class Testinterface
//{
//    public static void Main(String[] args)
//    {
//        Drawable d;
//        d = new Rectangle();
//        d.draw();
//        d = new circle();
//        d.draw();
//    }
//}



















