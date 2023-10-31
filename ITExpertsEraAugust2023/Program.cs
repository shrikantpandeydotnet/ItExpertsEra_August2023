// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.WriteLine("Welcome to ITExpertsEra 2023 August Batch");
//Console.Write("There is a story" + " A boy named nitin"); // concatenation

// Sum
//Console.WriteLine("Please enter your first number");

//int firstNumber =Convert.ToInt32( Console.ReadLine());

//Console.WriteLine("Please enter your second number");

//int seconNumber = Convert.ToInt32(Console.ReadLine());

//int result = firstNumber + seconNumber;

//Console.WriteLine("Your result is " + result);

// Homework, Subtract, Multiplication and Division. 

// If and else : Conditions

// Check the number even and number is greater than 500 

//Console.WriteLine("Please enter you number");

//int number = Convert.ToInt32(Console.ReadLine());

//if (number % 2 == 0 && number > 500) // % = Reminder | / = Quotient | && = both condition must be true. | || or condition means either one of them is true.
//{
//    Console.WriteLine("This number is Even number and greater than 500");
//}
//else if (number % 2 == 0)
//{
//    Console.WriteLine("This number is Even number but smaller than 500");
//}
//else
//{
//    Console.WriteLine("This number is odd number");
//}


//if (number % 2 == 0 || number > 500)
//{
//    Console.WriteLine("This is your number that you are looking for");
//}
//else
//{
//    Console.WriteLine("This is not your number that you are looking for");

//}

// Homework | 3 students name one by one. ask these questions to every students.

//Ask the name
//1) Your Maths Number
//2) Your English Number
//3) You Scieince Number
//4) You SST Number
//5) You ART Number

// Result 

// Who got the first position, second position and 3rd position. 
// show percentage of the student. 
// if below 40 percentage then fail, between 40 to 60 Below Average, between 60 -80 : Above Average, 80+ Good Result.


//int a = 200;
//int b = 400;
//int c = 350;

//string firstRank;
//string secondRank;
//string thirdRank;

//if (a > b && a > c)
//{
//    firstRank = "A";

//    if (b > c)
//    {
//        secondRank = "B";
//        thirdRank = "C";
//    }
//    else
//    {
//        secondRank = "C";
//        thirdRank = "B";
//    }
//}

//else if (b > a && b > c)
//{
//    firstRank = "B";

//    if (a > c)
//    {
//        secondRank = "A";
//        thirdRank = "C";
//    }
//    else
//    {
//        secondRank = "C";
//        thirdRank = "A";
//    }
//}
//else
//{

//}

/////////////////////////////////////////// 13th August 2023 //////////////////////////////////////////////////////////////////////


//Console.WriteLine("This is test message" );

//int i = 10;

//Console.WriteLine(i);

///////////////////////////////////////////// Data Types ////////////////////////////////////////////////////

//int var1 = 100000;

//string var2 = "test message";

//char var3 = 'c';

//bool var4 = false;

//DateTime var5 = DateTime.Now;

//byte var6 = 255;


//Console.WriteLine(var1);
//Console.WriteLine(var2);
//Console.WriteLine(var3);
//Console.WriteLine(var4);
//Console.WriteLine(var5);



//////////////////////////////////////// Array /////////////////////////////////////////////////////////////////////////

// Array Declaration..
//using ITExpertsEraAugust2023;
//using System.Xml.Linq;
/////
//int[] arrayInt = new int[5];

//// Array Initialization.

//arrayInt[0] = 10;
//arrayInt[2] = 30;
//arrayInt[3] = 40;


// Print the values of the array. 

//Console.WriteLine(arrayInt[0]);
//Console.WriteLine(arrayInt[1]);
//Console.WriteLine(arrayInt[2]);
//Console.WriteLine(arrayInt[3]);
//Console.WriteLine(arrayInt[4]);

////////////////// For LOOP /////////////////////////////////////////

// Syntax

//for (int i = 0; i < arrayInt.Length; i++)
//{
//    Console.WriteLine(arrayInt[i]);
//}

// print first 100 natural numbers. 

//for (int i = 1;i <= 100; i++)
//{
//    Console.WriteLine(i);
//}

// print table of 9

//for (int i = 9; i <= 90; i = i + 9)
//{
//    Console.WriteLine(i);
//}

// Nested Loop.

//int loopCount = 0;

//for ( int i = 100; i > 50; i-- )
//{
//    for ( int j = 0; j < 5; j++ )
//    {
//        loopCount++;
//    }
//}

//Console.WriteLine(loopCount);

/////////////////////////////////////////////// 17th August 2023 //////////////////////////////////////////////////////

// foreach loop. 

// Syntax

//foreach (int value in arrayInt)
//{
//    if (value > 20)
//    {
//        Console.WriteLine(value);
//    }
//}

// While Loop 

// Syntax 

//int i = 0;

//while (i < arrayInt.Length) // till condiion between bracket is true.
//{
//    Console.WriteLine(arrayInt[i]);
//    i++;
//}

// Do While

//int i = 0;

//do
//{
//    Console.WriteLine(arrayInt[i]);
//    i++;
//}
//while (i < arrayInt.Length);

// break and continue;

//for (int i = 0; i < arrayInt.Length; i++)
//{
//    if (arrayInt[i] == 30)
//    {
//        Console.WriteLine(arrayInt[i]);
//        break;
//    }
//}


//for (int i = 0; i < arrayInt.Length; i++)
//{
//    if (arrayInt[i] == 30)
//    {
//        continue;
//    }

//    Console.WriteLine(arrayInt[i]);
//}

////////////////////////////////// 20 August 2023 //////////////////////////////////

// Create object (Instance) of the class 

//Car objCar = new Car(); // Object Creation.. 

//objCar.CarName = "Honda City";
//objCar.BrandName = "Honda";
//objCar.NoOfSeats = 4;
//objCar.Color = "Black";


//objCar.Accelerator(10);
//objCar.Brake(100);
//objCar.Clutch(20);

//Console.WriteLine("Name of the Car is " + objCar.CarName);
//Console.WriteLine("Brand Name of the Car is " + objCar.BrandName);
//Console.WriteLine("No of Seats of the Car is " + objCar.NoOfSeats);
//Console.WriteLine("Color of the Car is " + objCar.Color);


//Car objCar2 = new Car();

//objCar2.CarName = "Baleno";
//objCar2.BrandName = "Maruti Suzuki";
//objCar2.NoOfSeats = 4;
//objCar2.Color = "Red";


//objCar2.Accelerator(20);
//objCar2.Brake(2000);
//objCar2.Clutch(40);

//Console.WriteLine("Name of the Car is " + objCar2.CarName);
//Console.WriteLine("Brand Name of the Car is " + objCar2.BrandName);
//Console.WriteLine("No of Seats of the Car is " + objCar2.NoOfSeats);
//Console.WriteLine("Color of the Car is " + objCar2.Color);


////////////////////////////////////////// 22 August 2023 ////////////////////////////////////////////


//MethodDetails objMethodDetails = new MethodDetails();

//objMethodDetails.Add(10, 20);

//int sum = objMethodDetails.AddWithReturnType(10, 20);

//Console.WriteLine(sum);

//PolymorphismExample objPoly = new PolymorphismExample();

//objPoly.Add(20, 30);

//int[] values = new int[5];

//values[0] = 1;
//values[1] = 10;
//values[2] = 20;
//values[3] = 15;
//values[4] = 17;

//objPoly.Add(values);

////////////////////////////////// 28th August 2023 ///////////////////////////////////////////


//ConsturctorExample objCon = new ConsturctorExample();

//ConsturctorExample.var3 = 3343;


//Console.WriteLine(objCon.var1);

//objCon.var1 = 10;
//objCon.var1 = 20;
//objCon.var1 = 10;




//Console.WriteLine(ConsturctorExample.var3);
//Console.WriteLine(objCon.var1); // 10

//ConsturctorExample objCon2 = new ConsturctorExample();


//ConsturctorExample.var3 = 4545;

//Console.WriteLine(objCon2.var1); // 0

//MethodDetails objMeth = new MethodDetails();


//string[] value = new string[] { "Adarsh", "Amit", "Paras", "Nitin" };

//string[] values1 = new string[3];

//values1[0] = "Adarsh";
//values1[1] = "Sohan";
//values1[2] = "Mohan";

//int result  = objMeth.testArrayMethod(values1);

////////////////////////////// 30th August 2023 ///////////////////////////

//OutVsRef objOR  = new OutVsRef();

//int val1 = 100;

//int val2 = 200;

//objOR.SumMethod(ref val1, ref val2);

//Console.WriteLine(val1);
//Console.WriteLine(val2);

//int sum; 
//int subtract; 
//int multiply; 
//int divide;
//objOR.MathsOperation(200, 100, out sum, out subtract, out multiply, out divide);

//Console.WriteLine(sum);
//Console.WriteLine(subtract);
//Console.WriteLine(multiply);
//Console.WriteLine(divide);

//int vaout = 200;


//objOR.OutTest(out vaout);

//Console.WriteLine("value of vaout is " + vaout);

//PropertiesExample objProp = new PropertiesExample();

//objProp.MyProperty = 200;


//Console.WriteLine(objProp.MyProperty);
//Console.WriteLine(objProp.MyProperty2);

/////////////////////////////////////////////////////////////// 04 September 2023 /////////////////////

//Parent objParent = new Parent();

//objParent.ParentMethod();


//Child objChild = new Child();

//objChild.ChildMethod();

//objChild.ParentMethod();

//GrandChild objGranChild = new GrandChild();

//objGranChild.ChildMethod();

//objGranChild.ParentMethod();

//objGranChild.GrandChildMethod();

//A objA = new A();

//objA.Method1();

//B objB = new B();
//objB.Method1();


///////////////////////////////////// 06th September 2023 //////////////////////////////////

//B objB = new B();

//objB.Method1();
//objB.Method2();


//A objA = new B();

//objA.Method1();
//objA.Method2();

/////////////////////////////////////////// 18th September 2023 ////////////////////////

//AccessModifier objAM = new AccessModifier();

//objAM.var_public = 40;

//objAM.var_internal = 50;

//objAM.var_protectedinternal = 500;

//AbstractClass objAC = new AbstractClass();

//objAC.TestMethod();
//objAC.TestMethod2();

///////////////////////////////////// 20 September 2023 ////////////////////////////////////////////

//TestClass objTC = new TestClass();

//InterfaceExample objA = new TestClass();
//IMathsOperation objB = new TestClass();

//objTC.


////////////////////////////////////////// 25th September 2023 ////////////////////////////////


//using ITExpertsEraAugust2023;
/////
/////

//CollectionExamples objCol = new CollectionExamples();

//objCol.ArrayListOperations();

//objCol.HashTableOperation()


/////////////////////////////////////// 27th September 2023 ////////////////////////

//using ITExpertsEraAugust2023;
/////
//GenericCollectionExample objGen = new GenericCollectionExample();

//objGen.DictionaryOperation();

//////////////////////////////////////////////////// 02nd October 2023 //////////////////////////////////////////

using ITExpertsEraAugust2023;
///
ExceptionHandlingExample obj = new ExceptionHandlingExample();

obj.TestMethod();





Console.ReadLine();


