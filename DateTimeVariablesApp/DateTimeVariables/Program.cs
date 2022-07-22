DateTime today = DateTime.Now;
//Console.WriteLine(today);
//Console.WriteLine(today.ToString("d"));
//Console.WriteLine(today.ToString("D"));
//Console.WriteLine(today.ToString("t"));
//Console.WriteLine(today.ToString("T"));

TimeOnly rightnow = TimeOnly.FromDateTime(DateTime.Now);
DateOnly todaysDate = DateOnly.FromDateTime(DateTime.Now); 

Console.WriteLine(today.Date);
Console.WriteLine(rightnow);
Console.WriteLine(todaysDate);