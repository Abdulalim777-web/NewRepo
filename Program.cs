


Console.WriteLine("enter your colour");


string colorName = Console.ReadLine()!;
switch (colorName)
{
    case "red":
        Consolecolor.Red;
        Console.ResetColor();
        break;
    case "blue":
        
         Consolecolor.Blue;
         Console.ResetColor();
        break;
    case "green":
        
         Consolecolor.Green;
        Console.ResetColor();
        break;
    case "yellow":
         ConsoleColor.yellow;
        Console.ResetColor();
        break;
    default: 
    Console.WriteLine("Enter a valid colour");
        break;
   

}
     static void ColorOutput(String ColorName , ConsoleColor consoleColor = ConsoleColor.White)
{
    string message = $"Yuo have selected a {colorName.ToUpper()}";
if (colorName != "white")
{
  Console.BackgroundColor = ConsoleColor.White;
  Console.ForegroundColor = consoleColor;
  Console.WriteLine(message);
  Console.ResetColor();

}
else 

{
    Console.WriteLine(message);
}
}
