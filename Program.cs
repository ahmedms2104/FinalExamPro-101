using System.Reflection.Metadata.Ecma335;

public class Vechicle{
    public string Name;
    private int Speed ;
    public static void TotalVechiclas(){}
    
    public virtual void Start(){
        Console.WriteLine("vehicle is starting!");
    }
    public virtual void Accelerate(int increment){
        Speed = Speed*increment;
    }
    public virtual void GetSpeed(){
       int Speed ;
       return  ;
    }

}

public class Car : Vechicle{
    int speed =10 ;
    public override void Start()
    {
        Console.WriteLine("The car is starting with a smoth engine sound!");
    }
    String FuelEfficiency =" to sore fuel efficiency in miles per gallon";
}
public class Motorcycle : Vechicle{
    int speed = 20;
    public override void Start()
    {
        Console.WriteLine("The motorcycle roars to life!");
    }
}
public class Truck : Vechicle{
    int Speed = 10 ;
    public override void Start()
    {
        Console.WriteLine("The truck's heavy engine rumbles as it starts!");
    }
    string CargoCapacity="to story the wight of cargo the truck can carry";
}
class Program{
    public static void Main(){
        Car car = new Car();
        car.Start();
        Motorcycle motorcycle = new Motorcycle();
        motorcycle.Start();
        Truck truck = new Truck();
        truck.Start();
        truck.GetSpeed();
        Console.WriteLine($"Car Speed : 10 mph "); 
        Console.WriteLine($"Car Speed : 40 mph "); 
        Console.WriteLine($"Car Speed : 15 mph "); 
    }
}