// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Om Sai Ram!");
//System.Console.WriteLine("Temperature on {0:D} is {1}° C", DateTime.Now,23.4);
//System.Console.WriteLine(int.MaxValue);
//System.Console.WriteLine(int.MinValue);

System.Console.WriteLine(byte.MaxValue + 2);
System.Console.WriteLine(byte.MinValue);

byte c =2;
//try{

unchecked{
//c = Convert.ToByte(byte.MaxValue+c);
}
System.Console.WriteLine(c.GetType());
//}
// catch(Exception e)
// {
//     System.Console.WriteLine(c.GetType());
// }

System.Console.WriteLine($"value of c is {Convert.ToByte(c)}");
       {
        for(byte i=0;i<=byte.MaxValue; )
            {
               System.Console.WriteLine(i.GetType());
                System.Console.WriteLine(i);   
                i+= Convert.ToByte(2);            
            }
       }

//alt+0176  types degree symbol
