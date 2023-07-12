// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string message)
{

    Console.Write(message);
    
    int result = Convert.ToInt32(Console.ReadLine());

    return result;
}

bool AreNaturalElements(int number, int startNum)
{
    if (number >= 0 && startNum >= 0) return true;

    else

        return false;
}


string PrintNaturalElements(int number , int startNum){ 
    if(startNum == number) return startNum.ToString(); 
    return number + " " + PrintNaturalElements(number-1,startNum); 
} 
Console.Clear(); 
int number = Prompt("Input number N => ");
int startNum = Prompt("Input a number to start from => ");
Console.WriteLine();

if (AreNaturalElements(number,startNum))
{
Console.WriteLine(PrintNaturalElements(number,startNum));


}
else 
{

Console.WriteLine($"Mistake! Both elements ({number} and {startNum})  must be natural. ");

}

Console.WriteLine();