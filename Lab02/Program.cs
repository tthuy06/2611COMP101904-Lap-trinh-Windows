using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

internal sealed class Student
{
    public string Name { get; init; }
    public double Score { get; init; }

    public Student(string name, double score)
    {
        Name = name;
        Score = score;
    }
}

internal static class Program
{
    private const double DefaultPassingThreshold = 5.0; 
    
    private static void Main()
    {

        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.InputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nhập số lượng sinh viên: ");
        int count;
        while (!int.TryParse(Console.ReadLine(), out count) || count <= 0)
        {
            Console.Write("Giá trị không hợp lệ. Nhập số nguyên dương cho số lượng sinh viên: ");
        }

        var students = new List<Student>(count);
        for (int i = 1; i <= count; i++)
        {
            Console.WriteLine($"--- Sinh viên #{i} ---");

            string name;
            do
            {
                Console.Write("Full name: ");
                name = Console.ReadLine()?.Trim() ?? string.Empty;
                if (string.IsNullOrWhiteSpace(name))
                    Console.WriteLine("Name cannot be empty.");
            } while (string.IsNullOrWhiteSpace(name));

            double score;
            Console.Write("Score (0 - 10): ");
            while (!double.TryParse(Console.ReadLine(), NumberStyles.Number, CultureInfo.InvariantCulture, out score)
                   || score < 0.0 || score > 10.0)
            {
                Console.Write("Invalid score. Enter a number between 0 and 10 (use dot for decimal): ");
            }

            students.Add(new Student(name, score));
        }

        if (students.Count == 0)
        {
            Console.WriteLine("No students entered.");
            return;
        }

        double average = students.Average(s => s.Score);
        double maxScore = students.Max(s => s.Score);
        const double eps = 1e-9;
        var topStudents = students.Where(s => Math.Abs(s.Score - maxScore) < eps).ToList();
        int passCount = students.Count(s => s.Score >= DefaultPassingThreshold);

        Console.WriteLine();
        Console.WriteLine("Class results:");
        Console.WriteLine("Index\tName\t\tScore\tResult");
        for (int i = 0; i < students.Count; i++)
        {
            var s = students[i];
            string result = s.Score >= DefaultPassingThreshold ? "Pass" : "Fail";
            Console.WriteLine($"{i + 1}\t{s.Name}\t{s.Score:F2}\t{result}");
        }

        Console.WriteLine();
        Console.WriteLine($"Class average: {average:F2}");
        Console.WriteLine($"Highest score: {maxScore:F2}");
        Console.WriteLine("Top student(s):");
        foreach (var t in topStudents)
            Console.WriteLine($" - {t.Name} ({t.Score:F2})");

        Console.WriteLine($"Number of students passing (>= {DefaultPassingThreshold}): {passCount}");
    }
}
