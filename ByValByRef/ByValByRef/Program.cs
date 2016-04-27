using System;

namespace ByValByRef
{ 
        class Program1
        {

            static void Main(string[] args)
            {
                // demo of passing value types vy value, ref and out
                int input = 5;
                Console.WriteLine("In Main: input = {0}", input);
                PassByValue(input);
                Console.WriteLine("In Main after calling PassByValue: input = {0}\n", input);
                PassByRef(ref input);
                Console.WriteLine("In Main after calling PassByRef: input = {0}\n", input);
                PassByOut(out input);
                Console.WriteLine("In Main after calling PassByOut: input = {0}\n", input);

                // demo of passing objects by value and ref
                Employee emp = new Employee() { Id = 5, Name = "Test" };
                Console.WriteLine("In Main: Employee Name = {0}", emp.Name);
                PassingObjectsByValue(emp);
                Console.WriteLine("In Main after calling PassingObjectsByValue: Employee Name = {0}\n", emp.Name);
                PassingObjectsByRef(ref emp);
                Console.WriteLine("In Main after calling PassingObjectsByRef: Employee Name = {0}\n", emp.Name);
                Console.ReadLine();
            }

            /// <summary>
            /// When a value type is passed by value
            /// changes to the passed parameter
            /// does not affect the original value
            /// </summary>
            /// <param name="input"></param>
            public static void PassByValue(int input)
                {
                    input = input + 10;
                    Console.WriteLine("In function PassByValue: input = {0}", input);
                }

            /// <summary>
            /// when a value is passed by reference
            /// any changes to the parameter in the 
            /// function affects the parameter
            /// outside the function
            /// </summary>
            /// <param name="input"></param>
            public static void PassByRef(ref int input)
            {
                input = input + 50;
                Console.WriteLine("In function PassByRef: input = {0}", input);
            }

            /// <summary>
            /// when a value is passed by reference
            /// any changes to the parameter in the 
            /// function affects the parameter
            /// outside the function
            /// </summary>
            /// <param name="input"></param>
            public static void PassByOut(out int input)
            {
                // when out is used, the parameter needs to be
                // initialized before it can be used
                input = 75;
                Console.WriteLine("In function PassByOut: input = {0}", input);
            }

            /// <summary>
            /// When objects are passed, they are implicitly passed
            /// as reference
            /// any changes made in the function
            /// will reflect outside also
            /// </summary>
            /// <param name="emp"></param>
            public static void PassingObjectsByValue(Employee emp)
            {
                emp.Name = "PassingObjectsByValue";
                Console.WriteLine("In function PassingObjectsByValue: employee name = {0}", emp.Name);
            }

            /// <summary>
            /// When objects are passed, they are implicitly passed
            /// as reference
            /// any changes made in the function
            /// will reflect outside also
            /// THE REF KEYWORD IS NOT NEEDED HERE
            /// IT IS EXACTLY THE SAME AS ABOVE FUNCTION
            /// </summary>
            /// <param name="emp"></param>
            public static void PassingObjectsByRef(ref Employee emp)
            {
                emp.Name = "PassingObjectsByRef";
                Console.WriteLine("In function PassingObjectsByRef: employee name = {0}", emp.Name);
            }

        }

        /// <summary>
        /// Dummy class for demonstrating passing objects
        /// </summary>
        class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    
}

