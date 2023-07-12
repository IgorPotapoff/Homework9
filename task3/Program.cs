// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int Prompt(string message)
{

    Console.Write(message);

    int result = Convert.ToInt32(Console.ReadLine());

    return result;
}

bool AreNaturalElements(int n, int m)
{
    if (n >= 0 && m >= 0) return true;

    else

        return false;
}

int FindAckermann(int n, int m)
{

    if (n == 0)
    {

        return m + 1;

    }
    else if (m == 0)
    {

        return FindAckermann(n - 1, 1);
    }

    else
    {

        return FindAckermann(n - 1, FindAckermann(n, m - 1));

    }
}


Console.Clear();
int n = Prompt("Input number N => ");
int m = Prompt("Input number M => ");

Console.WriteLine();
if (AreNaturalElements(n, m))
{

    Console.WriteLine($"The value of Ackermann function (arguments {n} and {m}) is {FindAckermann(n, m)}.");
    Console.WriteLine();
}

else
{

    Console.WriteLine($"Mistake! Both arguments ({n} and {m}) of Ackermann function  must be not negative. ");

}
Console.WriteLine();