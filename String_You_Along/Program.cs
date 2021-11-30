using System;
// John Cheney
// IT113
// NOTES: Reverse: I was able to get the Reverse working by using a similar stack idea we played with during one of the mini assignments
//
//        Reverse Overload: This functions similar to the base, but in order to figure out placement of Uppercase letters I used a boolean array to track placement of the Uppercase
//         letters and then set that place return the character as the Uppercase version
//
//        Symmetric: Functions using the Reverse method and then comparing if the strings are symmetrical
//
//        Equals: Just checks if, in the case of "Sunbeam Tiger", that they are the same string and if not a string it immediately returns false
//
//        ToString: I took the Hash idea we learned in class and set the string to a number. Then, with a little help from a classmate, I figured out how to
//         make a dictionary to compare the values of the ASCII and return them to a variable as the words themselves
//
// BEHAVIORS NOT IMPLIMENTED AND WHY: All behaviors implemented
namespace StringMaker_Cheney
{
    class Program
    {
        static void Main(string[] args)
        {
            StringManager manager = new StringManager();
            
            Console.WriteLine("Reverse w/out Preserving Case Location: " + manager.Reverse("Sunbeam Tiger"));
            
            Console.WriteLine("ToString() method returning ASCII: "+ manager);
           
            Console.WriteLine("Reverse Preserving Case Location: " + manager.Reverse("Sunbeam Tiger", true));
           
            Console.WriteLine("Is it Equal: " + manager.Equals("Sunbeam Tiger"));
           
            Console.WriteLine("Is it Symmetric: "+ manager.Symmetric("ABBA"));
            
            Console.WriteLine("Is it Symmetric: " + manager.Symmetric("ABA"));
            
            Console.WriteLine("Is it Symmetric: " + manager.Symmetric("ABba"));

        }
    }
}
