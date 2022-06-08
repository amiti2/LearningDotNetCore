object height =1.88; //storing a double in object
object name ="amit"; //storing string in an object

System.Console.WriteLine($"{name} is {height} metres tall");

//int length1 = name.Length;
int length2 = ((string)name).Length;
System.Console.WriteLine($"{name} has {length2} characters");
dynamic nameds="amit";
System.Console.WriteLine(nameds.Length);
nameds = 0.1;
System.Console.WriteLine(nameds +0.2);
int? de = null;
