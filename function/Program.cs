int Prompt(string massage)
{
    System.Console.WriteLine(massage);
    string inputString = Console. ReadLine();
    int number = Convert.ToInt32(inputString);
    return number;
}