string[] input = {'yard', 'hello', 'dom', 'abc', '38'};
int max_length = 3;
string[] result = new string[input.Length];
for (int i = 0; i < input.Length; i++)
{
    if (input[i].Length <= maxLength)
    {
        result[i] = input[i];
    }
}
foreach (string resultItem in result)
{
    Console.WriteLine(resultItem);
}