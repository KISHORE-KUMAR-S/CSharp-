// See https://aka.ms/new-console-template for more information
Console.Write("Enter your DOB: ");
DateTime MyAge = Convert.ToDateTime(Console.ReadLine());
int years = Convert.ToInt32(DateTime.Now.Subtract(MyAge).TotalDays)/360;
Console.WriteLine("Your age is: " + years);                                             
