using System.Text;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//we use the upper code to find a library 
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");
Console.WriteLine(@"  c:\source\repos
                   (this is where your file goes)");
Console.Write(@" c: invoices");
// Kon'nichiwa World
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("\n\u3053\u3093\u306B\u3061\u306F World!");
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
// User command to run an application
Console.WriteLine(@"c:\invoices\app.exe -j");
Console.Write("Hello" + " PAPA");
//we use the plus symbol to concatenate 
string firstName = "Bob";
string greeting = "Hello";
//string message = greeting + " " + firstName + "!";

//we can wrtie the same string with string interpolation 
string message = $"{greeting} {firstName}!";
Console.WriteLine("\n" + message);
//text interpolation as well can be used to write text with the variabloes
int version = 11;
string updateText = "Update to Windows";
string mesage = $"{updateText} {version}";
Console.WriteLine(mesage);
string projectsName = "First-Project";
Console.WriteLine($@"C:\Output\{projectsName}\Data");