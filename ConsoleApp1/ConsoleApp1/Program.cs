using System;
//(else System.Console.Write)
namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            //Console.WriteLine("What is your name?");
            //string name= Console.ReadLine();
            //Console.WriteLine($"Hello {name}");

            //bool canIvOTE = true;
            //Console.WriteLine(int.MaxValue);

            //  Integral Types:
            //byte: 8 - bit unsigned integer. Range: 0 to 255.
            //sbyte: 8 - bit signed integer. Range: -128 to 127.
            //short: 16 - bit signed integer. Range: -32,768 to 32,767.
            //ushort: 16 - bit unsigned integer. Range: 0 to 65,535.
            //int: 32 - bit signed integer. Range: -2,147,483,648 to 2,147,483,647.
            //uint: 32 - bit unsigned integer. Range: 0 to 4,294,967,295.
            //long: 64 - bit signed integer. Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
            //ulong: 64 - bit unsigned integer. Range: 0 to 18,446,744,073,709,551,615.


            //  Floating - Point Types:
            //float: 32 - bit single - precision floating - point number.
            //double: 64 - bit double-precision floating - point number.
            //decimal: 128 - bit decimal floating-point number.Used for financial calculations with higher precision.

            // Character Types:
            // char: 16 - bit Unicode character.

            // Boolean Type:
            // bool: Represents either true or false.

            // String Type:
            // string: Represents a sequence of characters.

            // Reference Types
            // object: The base type for all other types.All types, including value types, inherit from object.
            // dynamic: Allows you to defer type checking until runtime.
            // var: Implicitly types a variable based on the assigned value.

            // Nullable Value Types:
            // Nullable<T>: Wraps a value type to allow it to have a null value.For example, int ? represents a nullable integer.


            //CONVERSION from string
            //bool one = bool.Parse("True");
            //float two = float.Parse("234");
            //double three = double.Parse("243.32423");     

            ////To String
            //string four = one.ToString();
            //string five = two.ToString();
            //Console.WriteLine(four.GetType);

            ////Explicit Conversion
            //double fine2 = 32.23809283;
            //float fine3 = (float)fine2;

            ////Implicit Conversion            
            //float fine = 12.23245f;
            //double fine4 = fine;


            //Output formatting

            //Console.WriteLine("Currency {0:c}",12.2323);
            //Console.WriteLine("Pad {0:d4}",23);
            //Console.WriteLine("decimals {0:f3}", 12.2323);
            //Console.WriteLine("Commas {0:n0}", 122323);

            //nameof for commas and following number for decimal zeros


            //String functions

            //string randstr = "   I'm shahman";
            //Console.WriteLine(randstr);
            //Console.WriteLine(randstr.Length);
            //Console.WriteLine(randstr.Contains("is"));
            //Console.WriteLine(randstr.IndexOf("is"));
            //Console.WriteLine(randstr.Remove(5,1));
            //Console.WriteLine("Removed");
            //Console.WriteLine(randstr.Insert(5, "Addition"));
            //Console.WriteLine(randstr.Replace("my","yours",StringComparison.OrdinalIgnoreCase));


            //Console.WriteLine(String.Compare("A","B",StringComparison.OrdinalIgnoreCase)); output [-1,0,1]

            //Console.WriteLine("A = a ? {0}", String.Equals("A","a",StringComparison.OrdinalIgnoreCase));
            //equals output [T,F]
            // Console.WriteLine(randstr.PadLeft(20,'?'));
            // Console.WriteLine(randstr.Trim());
            // Console.WriteLine(randstr.ToUpper());
            //string newString = String.Format("Hello there {0}", "Shahman");
            // Console.Write(newString + "\n");

            //escape character \
            //Console.WriteLine("Hello \\n");
            //Console.WriteLine(@"Hello \n");


            //Arrays:
            //Fixed size
            int[] favNums = new int[3];
            int[] favNums2 = { 1, 2, 3, 4 };
            favNums[0] = 23;
            var vars = new[] { "cars", "dogs" };
            string[] vs = {"Cats"};

            for(int i=0; i<vars.Length; i++) {
              Console.WriteLine(vars[i]);     
            }

            //multi-dim array

            int[][] vs1 = new int[vars.Length][];











        }
    }
}