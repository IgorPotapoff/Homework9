// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{

    Console.Write(message);

    int result = Convert.ToInt32(Console.ReadLine());

    return result;
}


bool AreNaturalElements(int m, int n)
{
    if (m > 0 && n > 0) return true;

    else

        return false;
}


int FindSumOfNaturals(int m, int n)
{

    if (m == n)
    {

        return n;

    }
    else return m + FindSumOfNaturals(m + 1, n);
}


Console.Clear();
int m = Prompt("Input number M => ");
int n = Prompt("Input number N => ");

if (AreNaturalElements(m, n))

{
    Console.WriteLine();
    Console.WriteLine($"Sum of natural elements between {m} and {n} is {FindSumOfNaturals(m, n)}");
}

else{
    Console.WriteLine();
    Console.WriteLine($"Mistake! One of the following problems detected: \n 1)  {m} or (and) {n}  is (are) not natural elements.\n 2) Element {m} is bigger than element {n}. ");
}
Console.WriteLine();