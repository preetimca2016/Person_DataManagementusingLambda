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
            
        }

    }
}
