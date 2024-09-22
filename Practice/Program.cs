using Practice.src.OopPrinciples.Abstraction;
using Practice.src.OopPrinciples.Encapsulation;
using Practice.src.OopPrinciples.Inheritance;
using Practice.src.OopPrinciples.Polymorphism;
using Practice.src.OopPrinciples.Coupling;
using Practice.src.OopPrinciples.Composition;
using Practice.src.SOLID.S;
using Practice.src.SOLID.O;
using Practice.src.SOLID.L;
using Practice.src.SOLID.I;
using Practice.src.SOLID.D;

/****************
* Encapsulation *
*****************/
System.Console.WriteLine("Encapsulation \n----------------------------");
CheckBadBankAccount checkBadBankAccount = new CheckBadBankAccount();
checkBadBankAccount.CheckBalance();

CheckBankAccount checkBankAccount = new CheckBankAccount();
checkBankAccount.CheckBalance();
System.Console.WriteLine("----------------------------\n");

/**************
* Abstraction *
***************/
System.Console.WriteLine("Abstraction \n----------------------------");
EmailService emailService = new EmailService();
emailService.SendEmail();
System.Console.WriteLine("----------------------------\n");

/**************
* Inheritance *
***************/
System.Console.WriteLine("Inheritance \n----------------------------");
CheckCar checkCar = new CheckCar();
checkCar.CheckCarDetails();

CheckBike checkBike = new CheckBike();
checkBike.CheckBikeDetails();
System.Console.WriteLine("----------------------------\n");

/****************
* Polymorphism *
****************/
System.Console.WriteLine("Polymorphism \n----------------------------");
ListVehicles listVehicles = new ListVehicles();
listVehicles.AddVehicle(new PolyCar { Brand = "Pontiac", Model = "GTO", Year = 1969, NumberOfDoors = 2, NumberOfWheels = 4});
listVehicles.AddVehicle(new PolyMotorcycle { Brand = "Honda", Model ="Ninja", Year = 2021});
listVehicles.AddVehicle(new PolyPlane { Brand = "Boeing", Model = "747", Year = 2021});
listVehicles.ListAllVehicles();
System.Console.WriteLine("----------------------------\n");

/***********
* Coupling *
************/
System.Console.WriteLine("Coupling \n----------------------------");
var emailNotice = new Order(new EmailSender());
emailNotice.PlaceOrder();

var smsNotice = new Order(new SmsSender());
smsNotice.PlaceOrder();
System.Console.WriteLine("----------------------------\n");

/**************
* Composition *
***************/
System.Console.WriteLine("Composition \n----------------------------");
CompCar car = new CompCar();
car.StartCompCar();
System.Console.WriteLine("----------------------------\n");

/**********************************
* Single Responsibility Principle *
***********************************/
System.Console.WriteLine("Single Responsibility Principle \n----------------------------");
UserS user = new UserS { Username = "JanetDoe", Email = "JanetDoe@JD.io" };
UserServiceS userService = new UserServiceS();
userService.Register(user);
System.Console.WriteLine("----------------------------\n");

/************************
* Open/Closed Principle *
*************************/
System.Console.WriteLine("Open/Closed Principle \n----------------------------");
Circle circle = new Circle { Radius = 5 };
Rectangle rectangle = new Rectangle { Length = 5, Width = 5 };
Triangle triangle = new Triangle { Base = 5, Height = 5 };
Console.WriteLine($"Circle area: {circle.CalculateArea()}");
Console.WriteLine($"Rectangle area: {rectangle.CalculateArea()}");
Console.WriteLine($"Triangle area: {triangle.CalculateArea()}");
System.Console.WriteLine("----------------------------\n");

/********************************
* Liskov Substitution Principle *
*********************************/
System.Console.WriteLine("Liskov Substitution Principle \n----------------------------");
ShapeL rectangleL = new RectangleL { Width = 10, Height = 5 };
System.Console.WriteLine($"Rectangle area: {rectangleL.Area}");

ShapeL squareL = new SquareL { Side = 5 };
System.Console.WriteLine($"Square area: {squareL.Area}");

ShapeL circleL = new CircleL { Radius = 5 };
System.Console.WriteLine($"Circle area: {circleL.Area}");
System.Console.WriteLine("----------------------------\n");

/**********************************
* Interface Segregation Principle *
***********************************/
System.Console.WriteLine("Interface Segregation Principle \n----------------------------");

IShape2D circleI = new CircleI { Radius = 5 };
System.Console.WriteLine($"Circle area: {circleI.Area()}");

IShape3D sphereI = new SphereI { Radius = 5 };
System.Console.WriteLine($"Sphere area: {sphereI.Area()}");
System.Console.WriteLine($"Sphere volume: {sphereI.Volume()}");

System.Console.WriteLine("----------------------------\n");

/*********************************
* Dependency Inversion Principle *
**********************************/
System.Console.WriteLine("Dependency Inversion Principle \n----------------------------");

CarD gasCar = new CarD(new EngineD());
gasCar.Start();

CarD electricCar = new CarD(new ElectricEngineD());
electricCar.Start();

System.Console.WriteLine("----------------------------\n");
