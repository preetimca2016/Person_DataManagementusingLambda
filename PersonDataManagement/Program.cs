namespace LambdaProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> listOfPersonInCity = new List<Person>();
            listOfPersonInCity.Add(new Person("101", "John", "12 Main Street NewYork NY", 15));
            listOfPersonInCity.Add(new Person("102", "SAM", "13 Main Ct NewYork NY", 25));
            listOfPersonInCity.Add(new Person("103", "Ram", "14 Main Street NewYork NY", 35));
            listOfPersonInCity.Add(new Person("104", "Mac", "12 Main Street NewYork NY", 45));
            listOfPersonInCity.Add(new Person("105", "Den", "126 Main Street NewYork NY", 55));
            listOfPersonInCity.Add(new Person("106", "Elan", "34 Main Street Gujrat India", 65));
            listOfPersonInCity.Add(new Person("107", "SAM", "1208 Main Street NewYork ", 85));
            listOfPersonInCity.Add(new Person("101", "Parth", "126 Main Street UtterPradesh UP", 65));
            listOfPersonInCity.Add(new Person("101", "SAM", "128 Main Street Gurugram India", 95));


            //retrieve the first two personsfrom the list
            Console.WriteLine("Retrieve top two Aged Person from the list Who are older than 60 Years");
            foreach (Person person in listOfPersonInCity.FindAll(e => (e.Age >= 60)).Take(2).ToList())
            {
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age); ;
            }

            //check any person age between  13 and 18 years
            Console.WriteLine("\n Checking whether any Person is teen-ager or not...");
            foreach (Person person in listOfPersonInCity.FindAll(e => (e.Age >= 13 && e.Age <= 18)))
            {
                Console.WriteLine("Name: " + person.Name + "\t\tAge: " + person.Age); ;
            }
            //code get the Average of all peoples age
            Console.WriteLine("\nGetting Average of All prson age:");
            double AvgAge = listOfPersonInCity.Average(e => e.Age);
            Console.WriteLine("the Average of  all Person age is : " +AvgAge);

            //checking whether a person having name 'SAM' exists or not in a list
            Console.WriteLine("\nchecking whether a person having name 'SAM' exists or not in a list");
            if(listOfPersonInCity.Exists(e => e.Name == "SAM"))
            {
                Console.WriteLine("Yes, A person Having Name 'SAM' exists in ArgumentOutOfRangeException list");
            }
        }

    }
}