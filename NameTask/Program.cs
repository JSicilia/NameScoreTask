
class NameScore
{

    //Function for calculation string value
    static int stringValue(string s, int n)
    {
        int value = 0;
        foreach (char c in s)
        {
            //Using ascii to calculate alphabet to 
            value += char.ToUpper(c) - 64;
        }
        value = value * n;
        return value;
    }
    public static void Main()
    {
        string path = @"names.txt";

        if (File.Exists(path) )
        {
            string fullnames = File.ReadAllText(path); //Read the text file into a string
            fullnames = fullnames.Replace("\"", ""); //Replace the quotation marks with blank values
            string[] names = fullnames.Split(","); //Split the names into an array using the comma as a seperator
            Array.Sort(names); //Sort the array alphabetically

            int value = 0; //Initial value setting to 0
            int index = 1; //As we are multiplying by the position in the array, since it loops through in order we just start at 1

            index = 1;
            //Loop through the sorted array
            foreach ( string name in names )
            {
                value = value + stringValue(name, index); //Adding current value with the value returned from the stringvalue function. Passing the name and the index as parameters
                index++; //Incrementing the index for the next value
            }

            Console.WriteLine("The name score is: " + value); //Final value = 871198282

        } else 

        { Console.WriteLine("The text file could not be found.");

        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}