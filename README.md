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















