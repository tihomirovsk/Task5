int[] numbers = new[] { 1, 2, 2, 4, 4, 4, 4, 3, 3, 3 };


int count = 1;

int Position = 0;

int Element = 0;

int longestNum = numbers[0];

int longestCount = 1;

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] != numbers[i-1])
    {
        count = 0;
    }

    count++;
    if (count > longestCount)
    {
        longestCount = count;
        longestNum = numbers[i];
    }
}

Console.WriteLine(
    string.Join(" ", Enumerable.Repeat(longestNum, longestCount)));

int[] result = new int[longestCount];
Array.Fill(result, longestNum);