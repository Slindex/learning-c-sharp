using System;
using System.Dynamic;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // Hola mundo
            Console.WriteLine("Hello, C#!");

            /*
            Esto
            es
            un
            comentario
            */

            string myString = "Esto es una cadena de texto";
            myString = "Aqui cambio el valor de la cadena de texto";
            Console.WriteLine(myString);

            int myInt = 7;
            myInt += 4;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);

            double myDouble = 6.5;
            Console.WriteLine(myDouble);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);
            Console.WriteLine(myInt + myFloat + myDouble);

            bool myBool = true;
            myBool = false;
            Console.WriteLine(myBool);

            dynamic myDynamic = 6;
            myDynamic = "Mi dato dinamico (Cambia según la entrada)";
            Console.WriteLine(myDynamic);

            var myVar = "Mi variable de tipo inferido (Infiere la primera vez el tipo)";
            // myVar = 6; Error
            Console.WriteLine(myVar);

            Console.WriteLine($"El valor de mi entero es {myInt} y el de mi bool es {myBool}");

            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            // Estructuras

            var myArray = new string[] {"David", "Echajaya", "Slindex"};
            Console.WriteLine(myArray[0]);

            myArray[0] = "24";
            Console.WriteLine(myArray[0]);

            var myDictionary = new Dictionary<string, int>
            {
                {"Slindex", 24},
                {"Anyul", 60},
                {"Laura", 28},
            };

            Console.WriteLine(myDictionary["Laura"]);

            var mySet = new HashSet<string> {"David", "Echajaya", "Slindex"};
            Console.WriteLine(mySet);

            var myTuple = ("David", "Echajaya", "Laura");
            Console.WriteLine(myTuple);

            // Bucles

            for (int index = 0; index < 10; index++)
            {
                Console.WriteLine(index);
            }

            foreach (var myItem in myArray)
            {
                Console.WriteLine(myItem);        
            }

            foreach (var myItem in myDictionary)
            {
                Console.WriteLine(myItem);        
            }

            foreach (var myItem in mySet)
            {
                Console.WriteLine(myItem);        
            }

            //Flujos (Capacidad para decidir si se ejecuta un código o no)

            myInt = 12;

            if (myInt == 11 && myBool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 || myBool == false)
            {
                Console.WriteLine("El valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es 11 ni 12");
            }

            // Funciones

            MyFunction();
            Console.WriteLine(MyFunctionWithReturn(5));

            // Clases

            var myClass = new MyClass("Perrito");
            myClass.Name = "Gatito";
            Console.WriteLine(myClass.Name);
        }

        static void MyFunction()
        {
            Console.WriteLine("Mi funcion");
        }

        static int MyFunctionWithReturn(int param)
        {
            return 10 + param;
        }

        class MyClass(string name)
        {
            public string Name { get;set; } = name;
        }
    }

    
}
