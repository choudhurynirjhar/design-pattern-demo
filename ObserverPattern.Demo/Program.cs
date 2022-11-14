using ObserverPattern.Demo;

var subject = new Subject("Bob", 20);
var observer = new Observer();
subject.Subscribe(observer);

subject.UpdateUserAge(25);
await Task.Delay(1000);