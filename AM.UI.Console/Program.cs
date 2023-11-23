// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;
using AM.Core.Services;
using AM.Data;
using static AM.Core.Services.IFlightService;
/*
Console.WriteLine("Hello, World!");
Flight fl = new Flight();
Console.WriteLine(fl.ToString());
Plane plane = new Plane();
plane.Capacity = 200;
plane.ManufactureDate= DateTime.Now;
plane.PlaneId = 7;
plane.MyPlaneType = 0;
Console.WriteLine(plane.ToString());
Plane p=new Plane(PlaneType.Boing,100,new DateTime(2022,01,01));    
Console.WriteLine(p.ToString());
Plane p1 = new Plane()
{
Capacity = 200,
ManufactureDate= DateTime.Now,
PlaneId = 7,
MyPlaneType = PlaneType.AirBus,
};
Console.WriteLine(p1.ToString());
Passenger passenger = new Passenger();
Passenger staff = new Staff();
Passenger traveller = new Traveller();
Console.WriteLine(passenger.GetPassengerType());
Console.WriteLine(staff.GetPassengerType());
Console.WriteLine(traveller.GetPassengerType());

/* int age = 0;
DateTime date = new DateTime(2000, 1, 1);
Passenger ps = new Passenger()
{
BirthDate = new DateTime(2000, 1, 1),
};
ps.GetAge(date, ref age);
Console.WriteLine(age);
ps.GetAge(ps);
Console.WriteLine(ps.Age);*/
//GetScore meth1 = delegate (Passenger p)
//{
//    return p.Flights.Count();
//};
//GetScore meth2 = delegate (Passenger p)
//{
//    return p.Flights.Where(f=>f.Destination=="Tunisia" || f.Departure=="Tunisia").Count();
//};
//IFlightService fl=new FlightService();
//Console.WriteLine(fl.GetSeniorPassenger(meth1));
//Console.WriteLine(fl.GetSeniorPassenger(meth2));
/*
Flight flight1 = new Flight()
{
    FlightDate = DateTime.Now,
    Comment = "msg",
    Departure = "Tunis",
    Destination = "Paris",
    EffectiveArrival = DateTime.Now.AddHours(2),
    EstimatedDuration = 120
};
AMContext context= new AMContext();
context.Flights.Add(flight1);   
context.SaveChanges();
//Console.WriteLine(flight1.Comment);
*/
#region 4/11/2022 
//Passenger p1= new Passenger()
//{
//    PassportNumber="1234577",
//    BirthDate=new DateTime(2000,1,1),
//    EmailAddress="passenger@gmail.com",
//    Name=new FullName() { 
//    FirstName="heni",
//    LastName="walha"
//    },
//    TelNumber="99548023"
//};
//Traveller t1 = new Traveller()
//{
//    PassportNumber = "1234578",
//    BirthDate = new DateTime(2000, 1, 1),
//    EmailAddress = "passenger@gmail.com",
//    Name = new FullName()
//    {
//        FirstName = "heni",
//        LastName = "walha"
//    },
//    TelNumber = "99548023",
//    HealthInformation="malade",
//    Nationality="Tunisian"
//};
//Staff s1 = new Staff()
//{
//    PassportNumber = "1234579",
//    BirthDate = new DateTime(2000, 1, 1),
//    EmailAddress = "passenger@gmail.com",
//    Name = new FullName()
//    {
//        FirstName = "heni",
//        LastName = "walha"
//    },
//    TelNumber = "99548023",
//    EmployementDate = new DateTime(2000,7,16),
//    Function="HR",
//    Salary=2500.0
//};
//AMContext context = new AMContext();
//context.Passengers.Add(p1);
//context.Passengers.Add(t1);
//context.Passengers.Add(s1);
//context.SaveChanges();
#endregion
#region 11/11/2022

//Flight flg = new Flight()
//{
//    FlightDate = DateTime.Now,
//    Comment = "msg",
//    Departure = "Tunis",
//    Destination = "Paris",
//    EffectiveArrival = DateTime.Now.AddHours(2),
//    EstimatedDuration = 120
//};
//Passenger pas = new Passenger()
//{
//    PassportNumber="1111111",
//    BirthDate=new DateTime(2000,1,1),
//    EmailAddress="passenger@gmail.com",
//   Name=new FullName() { 
//    FirstName="heni",
//   LastName="walha"
//   },
//    TelNumber="99548023"
//};
//Reservation rv1 = new Reservation()
//{
//    MyPassenger=pas ,
//    MyFlight=flg,
//    Price = 260.0,
//    Seat = "C2",
//    Vip = true
//};
//AMContext context = new AMContext();
//context.Add(rv1);
//context.Add(flg);
//context.Add(pas);
//context.SaveChanges();
////// ----------------- question 10-------------------
//Plane plane = new Plane()
//{
//    Capacity = 200,
//    ManufactureDate = DateTime.Now,
//    MyPlaneType = PlaneType.AirBus,
//};
//Flight flight = new Flight()
//{
//    FlightDate = DateTime.Now,
//    MyPlane = plane,
//    Comment = "msg",
//    Departure = "Tunis",
//    Destination = "Paris",
//    EffectiveArrival = DateTime.Now.AddHours(2),
//    EstimatedDuration = 120
//};
//AMContext context = new AMContext();
//context.Add(flight);
//context.Add(plane);
//context.SaveChanges();
//Console.WriteLine(flight.MyPlane);
// ------------ question 11 --------------
AMContext context = new AMContext();
Flight flight=(Flight)context.Find(typeof(Flight), 4);
Console.WriteLine(flight.MyPlane);
#endregion