using System;

namespace CreateClass
{
    public class Person
    {
        public string name;
        DateTime birthdate;
        enum Genders {Male,Female};
        Genders gender;

        public Person (string name, DateTime birthdate)
        {
            this.name = name;
            this.birthdate = birthdate;
        }

        public void setMale()
        {
            this.gender =Genders.Male;
        }

        public void setFemale()
        {
            this.gender = Genders.Female;
        }

        public override string ToString()
        {
            return name + " "+birthdate + " " + gender;
        }
    }

    public class Employee : Person
    {
        public int salary;
        public string position;
        Room room;

        public Employee(string name, DateTime birthdate,int salary,string position,Room room) : base(name, birthdate)
        {
            this.salary = salary;
            this.position = position;
            this.room = room;
        }
    }

    public class Room
    {
        int roomNumber;

        public Room(int rnumber) {
            this.roomNumber = rnumber;
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Person ferfi = new Person("johnny", DateTime.Now);
            ferfi.setMale();

            Person no = new Person("Amanda", DateTime.Now);
            no.setFemale();

            Console.WriteLine(ferfi);
            Console.WriteLine(no);
            Console.ReadKey();
        }
    }
}