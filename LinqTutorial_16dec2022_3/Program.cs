namespace LinqTutorial_16dec2022_3;
// deferred execution
internal class Program
{
    static void Main(string[] args)
    {
        var words = new List<string> { "a", "bb", "ccc", "dddd" };
        var shortWords = words.Where(word => word.Length < 3).ToList(); /*ToList() method materialised the query, which means that shortWords is not a query anymore, but a list of data*/

        Console.WriteLine("First iteration");
        foreach (var word in shortWords) /*execution (materialisation) of LINQ query happens here*/
        {
            Console.WriteLine(word);
        }

        words.Add("e");

        Console.WriteLine("Second iteration");
        foreach (var word in shortWords)
        {
            Console.WriteLine(word);
        }

        //var people = new List<Person>
        //{
        //    new Person("John", "USA"),
        //    new Person("Betty", "UK")
        //};

        //var allAmericans = people.Where(person => person.Country == "USA");

        //var notAllAmericans = allAmericans.Take(100); /* Take(100) method takes the first 100 people of the original query*/

        var animals = new List<string>()
        {
            "Duck", "Lion", "Dolphin", "Tiger"
        };

        var animalsWithD = animals.Where(animal =>
        {
            Console.WriteLine("Checking animal: " + animal);
            return animal.StartsWith('D');
        });

        foreach (var animal in animalsWithD)
        {
            Console.WriteLine(animal);
        }
    }
}