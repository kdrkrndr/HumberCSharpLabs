using StudentReport;


List<Student> students = new();

students.Add(new Student("Alice", 96));
students.Add(new Student("John", 92));
students.Add(new Student("Michael", 68));
students.Add(new Student("Sarah", 87));
students.Add(new Student("David", 74));
students.Add(new Student("Emma", 99));
students.Add(new Student("James", 81));
students.Add(new Student("Sophia", 65));
students.Add(new Student("Daniel", 90));
students.Add(new Student("Olivia", 78));
students.Add(new Student("William", 55));
students.Add(new Student("Emily", 84));


List<string> topStudents = students
    .Where(s => s.Score >= 75)
    .OrderByDescending(s => s.Score)
    .Take(3)
    .Select(s => $"{s.Name} - {s.Score}")
    .ToList();


string path = "report.txt";

File.WriteAllLines(path, topStudents);

Console.WriteLine("Report saved successfully.");

string[] report = File.ReadAllLines(path);

foreach (string line in report)
{
    Console.WriteLine(line);
}