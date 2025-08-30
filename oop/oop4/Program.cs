using oop4;

Employee emp = new Employee("Ali", 25);
emp.ShowData();

Console.WriteLine("---------------------");

Manager mgr = new Manager("Omar", 35, "IT");
mgr.ShowData();



Console.WriteLine("#################################3");

Employee refrence = new Manager ("mohamed_No_Poly " , 28 , "It") ;
refrence.ShowData();// no polymorphism

Console.WriteLine("---------------------");


Line line = new Line(new Point(5, 5), new Point(10, 10), new Color("Red"));
Line line2 = new Line(null , null, new Color("Red"));
Line line3 = new Line(null, null);


line.Draw();
line2.Draw();
line3.Draw();
