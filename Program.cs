


Console.WriteLine("enter your colour");


string colorName = Console.ReadLine()!;
switch (colorName)
{
    case "red":
    case "blue":
    case "green":
    case "yellow":
     ConsoleColor.colorName;
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