using System;
using System.Xml.Linq;

class Hello
{
    // Functions
    static void printSome(string fullName)
    {
        Console.WriteLine("The full name is " + fullName);
    }
    static string makeFullName(string firstName, string lastName)
    {
        string fullName = firstName + " " + lastName;
        return fullName;
    }
    static void Main(string[] args)
    {
        printSome(makeFullName("Adjoa", "Akdogan"));
    }


    // For Loop
    /*
    static void Main(string[] srgs)
    {
        int[] intArray = { 1, 3, 5, 7, 9, 45, 3265 };
        List<string> nameList = new List<string>();
        nameList.Add("alperen akd");
        nameList.Add("azra akd");
        nameList.Add("esra akd");
        nameList.Add("sultan akd");
        nameList.Add("adjoa akd");
        foreach (int element in intArray)
        {
            Console.WriteLine(element);
        }
        foreach (string element in nameList)
        {
            Console.WriteLine(element);
        }
        for (int i=0; i<intArray.Length; i++)
        {
            Console.WriteLine(intArray[i]);
        }
        for (int i=0; i<nameList.Count; i++)
        {
            Console.WriteLine("Element number " +i + " is " + nameList[i]);
        }
    }
    */

    // Number guessing game with While Loop
    //static void Main(string[] args)
    //{
    //    Random rand = new Random();
    //    int randomNumber = rand.Next(1, 100);
    //    int guess;
    //    bool continueGame = true;
    //    while (continueGame)
    //    {
    //        Console.WriteLine("Enter a guess: ");
    //        guess = Convert.ToInt32(Console.ReadLine());
    //        if (guess < randomNumber)
    //        {
    //            Console.WriteLine("You have guessed low!");
    //        } else if (guess > randomNumber)
    //        {
    //            Console.WriteLine("You have guessed high!");
    //        } else
    //        {
    //            Console.WriteLine("You have guessed right!!");
    //            continueGame = false;
    //        }
    //    }
    //}


    // While Loop

    //static void Main(string[] args)
    //{
    //    int counter = 0;
    //    while (counter < 10)
    //    {
    //        System.Console.WriteLine("Counter: " + counter);
    //        counter++;
    //    }
    //}


    //static void Main(string[] args)
    //{
    //    bool loopControl = true;
    //    while (loopControl)
    //    {
    //        System.Console.WriteLine("this is a while loop output!!");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    // creating a dictionary
    //    System.Collections.Generic.Dictionary<string, string> myDict = new System.Collections.Generic.Dictionary<string, string>();
    //    myDict.Add("one", "two");
    //    myDict.Add("two", "four");
    //    myDict.Add("five", "ten");
    //    myDict.Add("nine", "eighteen");

    //    foreach (System.Collections.Generic.KeyValuePair<string, string> el in myDict )
    //    {
    //        System.Console.WriteLine(el);
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    System.Collections.Generic.List<int> theList = new System.Collections.Generic.List<int>();
    //    theList.Add(1234);
    //    theList.Add(4567);
    //    theList.Add(99);
    //    theList.Add(5);
    //    System.Console.WriteLine(theList.Count);
    //}

    //C# Arrays and Lists
    //static void Main(string[] args)
    //{
    //    int[] myList= { 12, 34, 45, 56, 67 };
    //    System.Console.WriteLine(myList[1]);
    //    myList[1] = 33;
    //    // creating a list from an array;
    //    System.Collections.Generic.List<int> myList2 = new System.Collections.Generic.List<int>(myList);
    //    //myList.Add(77);
    //    myList[0] = 99;
    //    foreach (int element in myList)
    //    {
    //        System.Console.WriteLine(element);
    //    }
    //    System.Console.WriteLine(myList);
    //}

    //Control flow
    //static void Main(string[] args)
    //{
    //    int timeOfday = 20;
    //    if (timeOfday >= 5 && timeOfday <= 12) // logical AND
    //    {
    //        System.Console.WriteLine("Good Morning");
    //    } else if (timeOfday >= 12 && timeOfday <= 18)
    //    {
    //        System.Console.WriteLine("Good afternoon");
    //    } else
    //    {
    //        System.Console.WriteLine("Good evening");
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    string message = "JS is the best programming language";
    //    int location = message.IndexOf("JS");
    //    string newMessage = "C#" + message.Substring(location + 2);
    //    System.Console.WriteLine(newMessage);
    //}

    //static void Main(string[] args)
    //{
    //    int b; // declaretion
    //    b = 456; // initialisation
    //    int a = 123; // declaration and assignment
    //    double c = 45.56;
    //    string firstName = "alperen";
    //    string lastName = "akdogan";
    //    System.Console.WriteLine(a);
    //    System.Console.WriteLine(b);
    //    System.Console.WriteLine(c);
    //    System.Console.WriteLine(c + a);
    //    System.Console.WriteLine(firstName);
    //    System.Console.WriteLine(firstName + "\'s last name is \"" + lastName + "\"");
    //}

    //static void Main(string[] args)
    //{
    //    int a = 12;
    //    double b = 1.6;
    //    System.Console.WriteLine(a / b);
    //}

    //static void Main(string[] args)
    //{
    //    System.Console.WriteLine(4 == 4); // comparision, true
    //    System.Console.WriteLine(4 != 9); // true
    //    System.Console.WriteLine(4 < 8); // true
    //    System.Console.WriteLine(3 > "10".Length); // true
    //    System.Console.WriteLine(System.Boolean.Parse("trUE")); // convert a string into a Boolean value
    //}
}