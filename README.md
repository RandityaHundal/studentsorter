# Student Sorting Program

This is a simple console application written in C# that sorts students' names alphabetically.

## How to Run

1. Clone the repository to your local machine.
2. Open the solution in JetBrains Rider.
3. Run the program.

## Program Flow

1. The program will first ask for the number of students in your class.
2. Then, it will prompt you to input the names of the students.
3. After all names have been entered, it will sort the names alphabetically and display them.

## Code Snippet

```csharp
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
