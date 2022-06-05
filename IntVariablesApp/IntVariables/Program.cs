int age = 0;//default is 0
int age2 = default(int);
//int is whole number. whole number do not contain decimals
//valid whole number 2,-3,4,-19
//invalid whole number -1.3, -7,2.4
//two billion +/- is range
//int under the hood is signed int32 
//signed intergers mean they are positive and -ve numbers
//if we take usinged integers then they can store 4 billion numbers

Console.WriteLine(age + "---" +age2);

int signedAge = +43;

int maxLimitnumber = Int32.MaxValue;

uint usignedMaxLimitNumber = uint.MaxValue;

Console.WriteLine("unsigned: "+ usignedMaxLimitNumber +"-----"+ maxLimitnumber);
Console.WriteLine("signed age is " + signedAge);

//one bit can represent 2 numbers. that is 0 and 1. 2^1
//2 bits can represent 4 numbers, 00 01 10 11. 2^2
//3 bits can represent 8 numbers, 000 001 010 011 100 101 110 111. 2^3
// n bits can represent 2^n numbers. from 000 to 2^n-1
// number is doubled everytime we add 1 more bits there fore the following is correct


//16 bits are not as twice as 8 bits. it is wrong assumption. To make twice the number of 8bit only 1 bit is needed. 9 bits are twice as large as 8bits.
//10 bits are 4 times as large as 8 bits. and this goes on an on.
//11 bits arr 8 times large as 8 bits and this goes on and on.

unchecked { 
Console.WriteLine(int.MaxValue + 10);
}
