Console.Write("How many students are in your class?: ");
int studentnumber = Convert.ToInt32(Console.ReadLine());

string[] students = new string[studentnumber];

Console.WriteLine("\nInput the name of the students");

for (int i = 0; i < studentnumber; i++)
{
    students[i] = Console.ReadLine();
}

Array.Sort(students);

Console.WriteLine("Here they are alphabetically sorted");

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

// close key
Console.ReadKey();