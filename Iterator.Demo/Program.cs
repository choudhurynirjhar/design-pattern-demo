
using Iterator.Demo;

var persons = new Aggregate<Person>();
persons[0] = new Person("John", 30);
persons[1] = new Person("Jane", 20);
persons[3] = new Person("Michael", 10);

var iterator = persons.Iterator;

while (iterator.IsLeft())
{
    Console.WriteLine(iterator.Current);
    iterator.Next();
}