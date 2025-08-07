namespace Demo02
{
    // 4 things can be written in a namespace
    // 1) Struct
    // 1) Enum
    // 1) Class
    // 1) Interface
    class Program
    {
        static void Main(string[] args)
        {

            #region Variable Declaration and Initialization

            int number = 8; // Stored on STACK
            // string class = "Shaden"; Invalid because class is a reserved word            int number;
            
            string name = "Shaden";
            // name=>1234(address) is stored on STACK
            // 1234(address) is stored on HEAP

            #endregion

            #region ValueType Data Types
            int x; // Declare variable of type int (x)
            // CLR will allocate 4 unassigned bytes to x on STACK
            // Console.WriteLine(x); => Compile Error: Use of unassigned variable 'x'
            x = 10; // Assid value 10 to x
            Console.WriteLine(x); // 10

            Int32 y = 20; // Declare variable of type int (x)
            // CLR will allocate 4 assigned bytes to y on STACK
            Console.WriteLine(y); // y is 20
            y = x; // Copy value of x to y
            Console.WriteLine("y After assignment"); 
            Console.WriteLine(y); // y is now 10

            x++;
            Console.WriteLine("x & y after increment");
            Console.WriteLine(x); // x is now 11
            Console.WriteLine(y); // y is still 10


            #endregion

            #region ReferenceType Data Types
            Point p1; 
            // Declare for reference from Type Point (p1) referencing to null
            // CLR will allocate 4 bytes(by default) to p1 on STACK
            // p1 can refer to an object of type Point
            // 4 bytes in STACK & 0 bytes in HEAPP

            p1 = new Point();
            // 1) Allocate the required bytes on HEAP (8 bytes)
            // 2) Initialize allocated bytes of object with Default value ( 0 to int )
            // 3) Call user-defined constructor (if exists)
            // 4) Assign the Reference(p1) to allocated object

            Console.WriteLine("\n\np1 after initialization");
            Console.WriteLine($"p1.x= {p1.x}"); 
            Console.WriteLine($"p1.y= {p1.y} \n\n");

            Point p2 = new Point() { x=10, y=20 };
            Console.WriteLine("p2 after initialization");
            Console.WriteLine($"p2.x= {p2.x}");
            Console.WriteLine($"p2.y= {p2.y}\n\n");

            p2 = p1; // p2 now refers to the same object as p1
            // Object that o2 was referring to is now eligible for garbage collection as it became unreachable
            Console.WriteLine("After p2=p1"); 
            Console.WriteLine($"p1.x= {p1.x}");
            Console.WriteLine($"p1.y= {p1.y}");
            Console.WriteLine($"p2.x= {p2.x}");
            Console.WriteLine($"p2.y= {p2.y}\n\n");

            p1.x = 100;
            p1.y = 200;
            Console.WriteLine("p1 & p2 after changing x and y values:");
            Console.WriteLine($"p1.x= {p1.x}");
            Console.WriteLine($"p1.y= {p1.y}");
            Console.WriteLine($"p2.x= {p2.x}");
            Console.WriteLine($"p2.y= {p2.y}\n\n");
            #endregion


        }


        #region Comments
        // This method returns the sum of two integers (Single-line comment)

        /* 
         * Multi-line
         * Comment
        */

        /// <summary>
        /// A function that returns a summations of two input values and these two values must be integers
        /// </summary>
        /// <param name="a">First parameter(integer)</param>
        /// <param name="b">Second parameter(integer)</param>
        /// <returns>Returns sum of two values(integer)</returns>
        public int sumNumbers(int a, int b)
        {
            return a + b;
        }

        #region Subtaction Method
        public int subtractNumbers(int a, int b)
        {
            return a - b;
        }

        #endregion


        #endregion


    }
}
