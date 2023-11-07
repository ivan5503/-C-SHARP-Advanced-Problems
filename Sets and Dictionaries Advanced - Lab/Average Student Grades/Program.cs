﻿int n = int.Parse(Console.ReadLine());

Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    string name = input[0];
    decimal grade = decimal.Parse(input[1]);

    if (!students.ContainsKey(name))
    {
        students.Add(name, new List<decimal>());
    }
    students[name].Add(grade);
}
foreach (var student in students)
{
    Console.Write($"{student.Key} -> ");
    decimal averageGrade = 0;
    foreach (var studentGrade in student.Value)
    {
        Console.Write($"{studentGrade:f2} ");
        averageGrade += studentGrade;
    }
    Console.Write($"(avg: {averageGrade / student.Value.Count:f2})");
    Console.WriteLine();
}
