# Контрольная работа по основам Csharp #

_Дано: Написать программу, которая из имеющегося массива строк формирует массив из строк, длинна которых меньше либо равна 3 символа._

**Решение:**

- Объявление массива
- Ввод элементов для проверки
- Объявление переменной для подсчёта длинны элемента
- Поиск подходящих элементов оператором _foreach_
- Вывод подходящих элементов опреатом _Join_



'string[] words;
Console.WriteLine("Введите слова через запятую: ");
string row = Console.ReadLine();
words = row.Split(',');
var podschet = new string[words.Length];
var dl = 0;
foreach (var value in words)
{
    if (value.Length <= 3)
    {
        podschet[dl] = value;
        dl++;
    }
}
Console.WriteLine(string.Join(Environment.NewLine, podschet, 0, dl));
Console.ReadKey(true); '

**см. консольное приложение в приложении**