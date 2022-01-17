using MediatorPattern.Demo;

var callCenter = new CabCallCenter();

var passenger1 = new Passenger("Passender1", "123 Street", 10);
var passenger2 = new Passenger("Passender2", "456 Street", 25);

var cab1 = new Cab("Cab1", 11, true);
var cab2 = new Cab("Cab2", 22, true);

callCenter.Register(cab1);
callCenter.Register(cab2);

callCenter.BookCab(passenger1);
callCenter.BookCab(passenger2);

Console.ReadLine();