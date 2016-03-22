# EpicU3-MattPearson

Challenge Sites:
================

Calc

http://392-matt.vm.epicservers.com/calc/

Radio Button 

http://392-matt.vm.epicservers.com/radioButtonChallenge/

First Pizza Site

http://392-matt.vm.epicservers.com/firstPapaBobPizza/

Days Between Dates

http://392-matt.vm.epicservers.com/DaysBetweenDates/

Epic Spy Assignment

http://392-matt.vm.epicservers.com/ChallengeEpicSpiesAssignement/

Epic Spy Asset Tracker

http://392-matt.vm.epicservers.com/ChallengeEpicSpiesAssetTracker/

Xmen Battle Count

http://392-matt.vm.epicservers.com/ChallengeForXmenBattleCount/

Postal Calculator Helper Methods

http://392-matt.vm.epicservers.com/ChallengePostalCalculatorHelperMethods/

Phun With Strings

http://392-matt.vm.epicservers.com/ChallengePhunWithStrings/

Mega Casino Challenge

http://392-matt.vm.epicservers.com/MegaCasinoChallenge/

Monster and Hero Challenge

http://392-matt.vm.epicservers.com/ChallengeHeroMonsterClasses/

Simple Dart Game



Challenge Student Courses



Data Types (CS-ASP_007)
=======================

Comments: // Single Line... /* Multiline */

string => alphanumeric (defaults to "")

int => 2 billion to -2 billion (defaults to 0)

double => fractional value (defaults to 0.0)

bool => true or false (defaults to false)

More: http://is.gd/data_types


Data Type Conversion (CS-ASP_008) 
================================

Implicit Conversion - smaller type to larger type
without any data loss, "upcasting".

Explicit Conversion - requires developer intervention
possibility of data loss, "downcasting", either in
the form of a cast or helper method.

Casting Numbers:
int myInteger = (int)myDouble;

Numbers to Strings:
string myString = myInteger.ToString();

String to Number:
int myInteger = int.Parse(myString);

More: http://is.gd/datatype_conversion

Arithmetic Operators (CS-ASP_009)
=================================

= Not equality, it's assignment

Math Operators: + - * /

Addition Assignment:

total = total + 5;
total += 5;

Increment Operator: i++;
Decrement Operator: i--;

Beware of order of precedence (use parenthesis)
Beware of downcasting (you'll lose precision)
Beware of overflow (use bigger types)

To make overflow throw an exception:

checked
{
  //some arithmetic operation
  // that could potentially overflow
}

C# Syntax (CS-ASP_010)
======================

Operands - variable names / server control names, literals - "Nouns" (you name these)

Operators - "Verbs ... they act on the operands"

http://is.gd/operators

Expressions - One or more operands and zero or more operators that evaluate to a single value.

http://is.gd/expressions

Statements - A complete instruction - assignment of an 
expression to a variable, an increment / decrement, ect.

http://is.gd/statement

Statements must end in a semi-colon ;
WhiteSpace is ignored (use for humans)



Conditional if ... else if ... else Statement (CS-ASP_011)
==========================================================

= Assignment

== Equality

if (a == b)
{
  //execute when the expression is true
}

else 
{
  //executes when the expression is false;
}

... or ... evaluate other mutally exclusivesly options:

if (a==b) {// some code}

else if (a == c) {// some code}

else if (a == d) {//some code}

else {// catch all}

Checkbox Server Control = Checked prop is bool

RadioButton Server Control = GroupName prop groups 

them together, check prop is bool


Conditional Ternary Operator (CS-ASP_012)
=========================================

Shortcut for evaluating an expression and returning a result

result = (a == b) ? "Equal"  :  "Not Equal";


Comparison and Logical Operator (CS-ASP_013)
============================================

Comparison Operators used for conditional statements

==

!=

< >

<= =>

!someBooleanValue - means NOT is true

Logical Operators

used to combine multiple expressions / evaluation

&& - AND

|| - OR

Combine with paraenthesis  ( ) for order of precedence


Date Time (CS-ASP_014)
=======================

Creating new DateTime objects

DateTime myDateTime = DateTime.Now;

DateTime myDateTime = DateTime("12/7/1969");

Formatting...many options:

myDateTime.To____()

Retrieving Parts:

myDateTime.Year // int

myDateTime.Hour // int

myDateTime.DayOfWeek // "Monday"

myDateTime./DayOfYear // int 175

DateTime Math:

myDateTime.AddHour(3)

myDateTime.AddMinute(-5)

Chaining = using multiple helper methods together with the dot - operator
myDateTime.AddHour(3).AddMinute(-5).ToString()


Working with spans of time (CS-ASP_015)
======================================

Create and initialize new TimeSpans


// Days.Hours:Minutes:Seconds.Milliseconds
TimeSpan myTimeSpan = TimeSpan.Parse("")

DateTime myBirthday = DateTime.Parse("12/7/1969");
TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

// more infor
http://is.gd/timespan

get individual parts
myAge.Hours
myAge.Seconds

...or get TOTAL elasped time
as a double representing both
the number of days / hours / ect
AND fractional values representing
"left overs"

myTimeSpan.TotalDays // double
myTimeSpan.TotalHours // double


Formatting Strings (CS-ASP_019)
==============================

Concatenate Strings
+ 
 
+=

Format Strings

String.Format("Hello {0}. You are from {1}", "Bob", "Chicago")

Format Numbers

String.Format("Reference Code: {0:000_000-0}", 1234567)
123_456-7

Formatting Dates

http://is.gd/formattingdates

String.Format("Reference Date: {0:ddd - d, MM, YYYY}", someDate)
Tue - 5, 07, 2014

Formatting Currency

http://is.gd/formattingcurrency

String.Format("Total: {0:C}", totalAmount)
$50,000.00



Single Dimensional Arrays (CS-ASP_021)
======================================

Indexes vs Elements

Accessor vs Stored Values

Indexes are zero based

Declaring Arrays:

string[] myArray = new String[3];

Declaring and Initializing Arrays:

string[] myArray = new string[3] {"Moe", "Curly", "Larry"};

Setting / Getting Values:

string myString = myArray[1]; // Retrieve the second element

myArray[0] = myString; // Sets first element


Multidimensional Arrays (CS-ASP_022)
==========================================
Same as single dimensional ...just requires

more indexes (in dimensions) to get to the element

double[,] myArray = new double[2,3] // contains 6 elements

double[,,] rubicsCube = new int[3,3,3] // contains 27 elements

rubicsCube[0,1,2] = 42;

myInteger = rubicsCube[0,1,2];


Changing the Length of an Array (CS-ASP_023)
==============================================

Arrays are immutable = cannot be changed in memory
HOWEVER, the ASP.NET Framework provides helper 
methods to resize an array, creates a new array
and then copies the old vaules into it.

Array.Resize(ref myArray, myArray.Length + 1);

// Get the Highest index:

int highestIndex = myArray.GetUpperBound(0);

// 0 = dimension we want to retrieve the upper boundary for

// Arrays have other helper methods

myArray.Sum();

myArray.Min();

myArray.Max();

myArray.Average();

Array.Sort();

Array.Reverse();


Looping with the FOR Iteration Statement (CS-ASP_026)
========================================================

snippet : for (tab)(tab)

Then you can tab through the replaceable bits, hit
enter to start writing code in the code block body

for (int i = 0; i < 10; i++)
{
// your code here
}

i - Any variable name

1st part - counter declaration, can be initialized to any number

2nd part - condition, can be any expression that equates to a bool

3rd part - increment i++ / decrement i--, can step more than 1 using +=,

string[] names = new string[] {"Wolverine", "Cyclops", "Professor X", "Phoenix"}

for (int i = 0; i < names.Length; i++)

{

  // Can search for a specific value
  
  if (names[i] == "Professor X")
  
  {
  
    //Do something
    
    // Can break out of additional iterations if you need to
    
    break;
    
  }
  
}



Looping with the while and do while iteration statements (CS-ASP_027)
=====================================================================

Random random = new Random();

// random.Next(lowerBounds, upperBounds);

random.Next(1, 100) // returns a value between 1 and 100


// Is someExpression is already false, this will never execute

while(someExpression){

// Code that would affect whether

// someExpression is true or false

}

// If someExpression is already false, this will run AT LEAST ONCE

do {

//Code that would affect whether

// someExpression is true or false

} while (someExpression)


Creatug Overloaded Methods - (CS-ASP_031)
==========================================
Different Method Signature, but same basic function.
Method Signature....the number and type of parameters
Can have different return types.

Creating Optional Parameters - (CS-ASP_032)
==========================================
Optional parameters provide default values when you define
the method. So, if you dont supply a value, the defualt
will be used.

private void myMethod(string myRequiredParam,
                        int myOptionalParam = 1
                        int myOtherOptinalPara - 5);

// Can be called ....

myMethod("Hello Required Param!");

// or ...

myMethod("Hello Required Param!", 100);

//...or

myMethod("Hello Required Para!", 100, 500);

// You cannot skip an optional parameter

myMethod("Hello Required Para!", , 500); // Error

Passing Named Arguments into Input Parameters (CS-ASP_033)
===========================================================
Allow us to send in parameter arguments OUT OF ORDER!
We just prefix the input parameter argument with the name
of the parameter we're passing in, a colon, then the value:

myMethod(myOtherOptionalParam : 500, 
          myRequiredParam: "Hello Required Param",
          myOptionalParam: 100);

// You still have to pass in REQUIRED Params

Creating Methods with Output Parameters - CS-ASP_034
=====================================================
Allow you to return a value the normal way and return 
a value via a method parameter:

private bool myMethod(string myRequiredParam, out int myOptionalParam) {}

int myValue = 0;
if(myMethod("Some Required Text", out myValue)) return "Hello World";


Manipulating Strings - CS-ASP_035
==================================
// Escape double quotes
string myString = "This is a double quote /".";

// Accessing a specific char:
myString[2];

// StartsWith(). EndsWith(), Contains()
// Check to see if a given string has a set of
// characters beginng, end or somewhere inside
// return true of false

// IndexOf()
// Find the index for one string inside of 
// another string
int myIndex = myString.IndexOf("howdy");

// Insert(), Remove()
// Inserts adds char starting a given index
// Remove() removes a characters starting at a given index

// Substring()
// Retrivev charcters beginning at a given index
// all the way through the length you input

// Trim(), TrimStart(), TrimEnd()
// Remove space characters both, or just the start 
// or the end of the string


//PadLeft(), PadRight()
//allow you to specify a length for a string
// and a character to pad the string with if its
// length is less than the specified lenth

myString = someValue.PadLeft(10, '#');
//Notive that we're inputting a char, not a string
// therfore we have to use a single quote ' not
// a double quote

// ToUpper, ToLower()
// Important! Compare two strings regardless of
// the case, because in C#, two strings with
// different cases are NOT equal

// Replace()
// Replace every occurance of one string with
// some other string.
myString.Replace("$$$", myValue)

// Split()
// Take a string and split in into many strings
// and store them ina string array
string[] names = myString.Split(';')

//Concatenating strings, immutability
// StringBuilder - memory efficient way of concatenating strings


Introduction to Classes and Objects (CS-ASP_036)
=================================================

Class is a code block that defines a data type
An Object is an instance of a Class
Metaphors:
Blueprint vs Houses
Recipe vs Cupcakes
Patterns vs BLuejeans
Cookie cutter vs Cookies

Classes have members, like Properties and Methods

Properties define the attributes taht are set on 
an instance of the class / represent the "state"
of the ovject. You can set (assign) and get
(retrieve) properites values on an object.

Methods define actions an instance of a class
can perform, usually on the object instance itself.

You can create an instance of a class using the
new keyword. Think "factory".

You can access the memebers of an object by using
the member access operator, the dot (.)

Conceptually, classes are delagated a responsibility


Classes are ultimately custome data types, more complex
thatn the simple data types we've worked with.
Therefore you can use them anywhere you use other
data types (like as input parameters or return 
values from a method.)

class Car {

}

Auto Implemented Properties - simple properties
prop tab tab enter enter

this keyword - Access a memvber of the current instance
of the class

public void MyMethod()
{
  this.Year = 1976;
}



Creating Class Files, Creating Conhesive Classes and Code Navigation
====================================================================

Prefer more classes w/ narrowly define responsibilities
Prefer to put each class in its own file
Prefer high cohesion - similarity / singnless of purpose of the class members
To achieve high cohesion, a rule of thumb: try to make your classes fin on
one screen of your IDE

Understanding Object References and Object Lifetime ()
======================================================

An Object reference variable holds a reference holds a reference to an instantianed object
in computers memory

myClass myObject;

More than one object refernce var can hold an address to the object in memory

myClass myOtherObjectRefernce = myObject;

Each time a new reference is added, the reference count increases by one, Each time
an object reference car goes out of scope or is set to null, the reference count 
decreases by one.

If the reference count is zero the .NET framework Runtime's Garbage Collector
removes the object from memory at an indeterminate point in time in the future.
You can take control of the finalizatino process and even handle events just before
the object is removed. See "deterministic finalization"

Understanding the .NET Framework and Compliation 
=================================================


The .NET Framework consits of:

- Runtime (Common Language Runtime , CLR) "protective bubble", manages memory,
- protects the users machine, ect.
- 

.NET Framework Class Library (FCL, Base Class Library, BCL) - thousands
of classes built by MIcrosoft for every imaginable purpose.

- COmpileer 


Understanding Namespaces and the using Directive (CS-ASP_040)
=============================================================
Namespaces disambiguate class names inside of class libraries of applicatinons.

You must reference class name by their full name:

System.Text StringBuilder sb = new System.Text.StringBuilder();

....of,  you can employ a using directive at the top of the code file to
instruct the compiler to look in those namespaces to find the class
that is reference.

using System.Text;

StringBuilder sb = new StringBuilder();

You must always do this if the code you're nwriting is outside of the namepace
of the class you to use, even if it's in the same project. 

Default namepsce defined in Project Properties (right-clicking on Project
name in Solution Explorer, select Properties)


Creating Class Libraries and Adding Reference to Assemblies (CS-ASP_041)
========================================================================

Class Library project - creates a .dll that can be refernced in other projects

Add a Reference - the FCL is split into tiny pieces, and you must reference
that assemblies that contain the parts of the library you want to use.

Right-click project's References node in SOlution Explorer, select Add Reference


Accesssibility Modifers, Fields and Properties (CS-ASP_042)
===========================================================
http://v.gd/access

Public - Class or member can be accessed by any code
Private - Class or member can only be accessed by parent class
Protected - Class or member can only be accessed by parent class or derived class
Internal - Class or member can only be accessed by code inside the same assembly

CLasses are internal by default
Methods and properties are private by default

Encapsulation - hiding implementation behind public interfaces, reduces couplig
increases plug-ability / resusability, maintainbility, ect.

private fields have two purposes:
(1) reference to object or variable that used for internal implementation of class
(2) hold the state of an object, backing field for public property

propfull [tab] [tab]

private int myField
property int MyProperty
{
  get { return myField }
  set {
    if (value > 1000)
      myField = value;
      else
      // tell the caller that they can't do this
  }
}

Full property defination and private fields to control access to private fields / state of the object.

prorpg [tab] [tab]
public int MyProperty {get; private set;}
Restricts setting of property to just the class ' internal implementation


Creating constructor methods (CS-ASP_043)
========================================
Constructors are called at the moment of instantiation.
Used to put the new instance of the class into a valid state.

public class Foo()
{
  public Foo
  {
  ...
  }
}

Whether you define it or not, there is a default constructor,
You can ovveride the default (no input parameters) or overload
the constructor to allow the user to set the new 
instance to a valid state.


Nameing conventions for Identifiers (CS-ASP_044)
================================================
PascalCase - public
camelCase - private, protected

PUblic classes, methods and properties - PascalCase
Private helper methods, input parameters - camelCase
Locally scoped variables - camelCase
Private field - camelCase prefixed w/ underescore: _firstName

Choose long, memorable, understandalbe names
that convey meaning / intent.


Static versus Instance members (CS-ASP_045)
==========================================
Static members - no instance of the class required to call method

INstance member 0 must create an instance w/ new keywrod to call
methods and properties

Cab mix both in the same class, but cant reference instance
members from inside of static members

Classes can be decorated w/ static keyword - all memebers
must be static, cant create an instance of the class.

System.Math

http://v.gd/static


Working with the List Collection CS-ASP_046
===========================================

Use Generic Collections to work with items in a strongly typed fashion

Better than arrays:
Know the type of the item for a certainty, no casting / converting
Better performance inserting / removing / updating
Collections provide more flexible options to access items in the collection.
Allows for LINQ extension methods.

Many different collections - specialties

"Generic Collections"
List<T>
Dictionary<TKey, TValue>
t => data type you need 
"You make a generic specific by providing a data type"

List<string> - only store strings (strongly typed)
List<Car> - only store Cars in that collection

// Assume I have three objects: car1, car2, car3
List<Car> cars = new List<Car>();
cars.Add(car1);
cars.Add(car2);
cars.Add(car3);

int numberOfCars = cars.Count;
Car myCar = cars.ElementAt(1); // Returns 2nd car in collection

// Terminology: You access a MEMBER of a collection

// LINQ queries

Object Initializers (CS-ASP_047)
================================

Concise way to initialize a new object (or collection) with values

// Did'nt talk about this form:

Car car1 = new Car() {Make = "BMW", Model = "524i", Year = 2005, Color = "Silver"};

// No local variable name for the new Car instance needed!

cars.Add(new Car() {Make = "BMW", Model = "472i", Year = 2001, Color = "Red"});

Collection Initializers (CS-ASP_048)
====================================

Shortcut to creat new instance of generic collection and initialize it
by immediately adding new instances of a given type.

List<Car> cars = new List<Car>()
{
  new Car{Make="BMW", Model="673i", Color="Yellow", Year=2009}
  new Car{Make="BMW", Model="643i", Color="Black", Year=2013}
  new Car{Make="BMW", Model="545i", Color="Red", Year=2005}
};


Working with Dictionary<TKey, TValue> Collection (CS-ASP_049)
============================================================

Dictionry allows you to use a kay to access a member of the collection.

Think: Webster's dictionary ... the word (key), the definition (instance of a given type)

Key is anything meaningful in Your System. 

Key must be unique

TKey => type of the key

TValue => type of the value

Dictionary<string, Car> cars = new Dictionary<string, Car>();
cars.Add("V3494343", new Car{Make="BMW", Model="456i", Year=2001, Color="Black"});
cars.Add("V3494343", new Car{Make="BMW", Model="421i", Year=2011, Color="Grey"});
cars.Add("V3494343", new Car{Make="BMW", Model="475i", Year=2005, Color="Silver"});

cars.ElementAt(1).Key // Return "2nd car"
cars.ElementAt(1).Value // Return 2nd car

// Better way to acces Dictionary...
Car v2
if(cars.TryGetValue("V3494343", out v2))
{
  result += v2.Year;
}

// Remove
if(cars.Remove("V345"))
{
  result += "Successfully removed car.";
}


Looping with the foreach Iteration Statement (CS-ASP_050)
=============================================================

More elegant way of iterating through a collection

Code snippet: foreach [tab] [tab]

foreach (Car car in cars) {
  result += car.Make;
}

Implicitly Typed Local Variables with the var Keyword (CS-ASP_051)
===================================================================

(Applies to locally scoped variable declarations)

Compiler is smart enough to figure out the data type when you initialize it
Becomes increasingly important because sometimes difficult to know what the
data type is supposed to be. (LINQ)


int hitPoints = 0;
... is the equivalent of ...
var hitPoints = 0;

string heroName = "Pentagorn";
... is the equivalent of ...
var heroName = "Pentagorn";

var cars = new List<Car>()
{
  ...
}


Rules: 
1: Must initialize the variable
2: Variable is permanently set to the implicit data
3: Can't be used for a public property or variable



















