
using System.ComponentModel;
using Practice.src.OopPrinciples.Abstraction;
using Practice.src.OopPrinciples.Encapsulation;
using Practice.src.OopPrinciples.Inheritance;
using Practice.src.OopPrinciples.Polymorphism;
using Practice.src.OopPrinciples.Coupling;
using Practice.src.OopPrinciples.Composition;

/****************
* Encapsulation *
*****************/
CheckBadBankAccount checkBadBankAccount = new CheckBadBankAccount();
checkBadBankAccount.CheckBalance();

CheckBankAccount checkBankAccount = new CheckBankAccount();
checkBankAccount.CheckBalance();

/**************
* Abstraction *
***************/
EmailService emailService = new EmailService();
emailService.SendEmail();

/**************
* Inheritance *
***************/
CheckCar checkCar = new CheckCar();
checkCar.CheckCarDetails();

CheckBike checkBike = new CheckBike();
checkBike.CheckBikeDetails();

/****************
* Polymorphism *
****************/
ListVehicles listVehicles = new ListVehicles();
listVehicles.AddVehicle(new PolyCar { Brand = "Pontiac", Model = "GTO", Year = 1969, NumberOfDoors = 2, NumberOfWheels = 4});
listVehicles.AddVehicle(new PolyMotorcycle { Brand = "Honda", Model ="Ninja", Year = 2021});
listVehicles.AddVehicle(new PolyPlane { Brand = "Boeing", Model = "747", Year = 2021});
listVehicles.ListAllVehicles();

/***********
* Coupling *
************/
var emailNotice = new Order(new EmailSender());
emailNotice.PlaceOrder();

var smsNotice = new Order(new SmsSender());
smsNotice.PlaceOrder();

/**************
* Composition *
***************/
CompCar car = new CompCar();
car.StartCompCar();