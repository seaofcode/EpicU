# EpicU3-MattPearson

Challenge Sites:
http://392-matt.vm.epicservers.com/calc/

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

Shortcut for evaluating an expression and returning
a result
result = (a == b) ? "Equal"  :  "Not Equal";


Comparison and Logical Operator (CS-ASP_103)
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







