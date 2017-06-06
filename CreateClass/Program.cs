using System;


namespace CreateClass
{
    class Person
    {
        string name;
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
            return name+" "+birthdate + " " + gender;
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