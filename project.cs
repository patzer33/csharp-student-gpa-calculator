string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";


double course1Grade = 9.3;
double course2Grade = 8.7;
double course3Grade = 9.8;
double course4Grade = 9.5;
double course5Grade = 10.0;

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

double totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

double totalCredits = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

Console.WriteLine($"Student: {studentName, -20}\n");
Console.WriteLine($"{course1Name, -20} - grade:{course1Grade, -10} - credit:{course1Credit}");
Console.WriteLine($"{course2Name, -20} - grade:{course2Grade, -10} - credit:{course2Credit}");
Console.WriteLine($"{course3Name, -20} - grade:{course3Grade, -10} - credit:{course3Credit}");
Console.WriteLine($"{course4Name, -20} - grade:{course4Grade, -10} - credit:{course4Credit}");
Console.WriteLine($"{course5Name, -20} - grade:{course5Grade, -10} - credit:{course5Credit}");
Console.WriteLine("\nGPA: " + (totalGradePoints / totalCreditsHours).ToString("F2"));
