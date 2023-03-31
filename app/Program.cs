string[] words;
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
Console.ReadKey(true); 