// string region = null;
// Console.WriteLine(region.ToUpper());

// string? region = null;
// string? upperRegion = region?.ToUpper();
// Console.WriteLine(upperRegion);
// string displayRegion = region ?? "Region not specified";
// Console.WriteLine("Region (cpalesced):{displayRegion}");
// region ??= "Addis Abeba";
// Console.WriteLine("Reion(assigned):{region}");
// string studentName = "Abebe";
// string studentId = "STU-001";
// int enrollmentCount = 3;
// decimal grantAmount = 1999.99m;
// DateTime enrolledAt = DateTime.UtcNow;
// string? campusRegion = null;

// Console.WriteLine($"Student: {studentName} {studentId}");
// Console.WriteLine($"Enrollment Count: {enrollmentCount}");
// Console.WriteLine($"Grant Amount: {grantAmount:C}");
// Console.WriteLine($"Enrolled At: {enrolledAt: yyyy-MM-dd HH:mm:ss} UTC");
// Console.WriteLine($"Campus Region: {campusRegion ?? "Not specified"}");

// double grantPerStudent = 1999.99;
// double totalAllocation = grantPerStudent * 100_000;
// Console.WriteLine($"Total allocated (double): {totalAllocation:R}");


// decimal grantPerStudent = 1999.99m;
// decimal totalAllocation = grantPerStudent * 100_000;
// Console.WriteLine($"Total allocated (double): {totalAllocation}");


// var enrollment = new EnrollmentRecord("STU-001", "CS-401", DateTime.UtcNow);
// Console.WriteLine(enrollment);
// var corrected = enrollment with { CourseCode = "CS-402" };
// Console.WriteLine(corrected);
// var duplicate = new EnrollmentRecord("STU-001", "CS-401", enrollment.EnrolledAt);
// Console.WriteLine($"Same data? {enrollment == duplicate}"); 

// var course = new Course {Code="CS-401", Title="Introduction to Computer Science", Capacity=30};
// Console.WriteLine($"Course: {course.Code} - {course.Title} (Capacity: {course.Capacity})");
// // Invalid capacity — should throw
// try
// {
//     course.Capacity =-5;
// }
// catch (ArgumentOutOfRangeException ex)
// {
// Console.WriteLine($"Caught: {ex.Message}");
// }
// // Invalid title — should throw
// try
// {
//     course.Title = "";
// }
// catch (ArgumentException ex)
// {
// Console.WriteLine($"Caught: {ex.Message}");
// }

// var student = new Student { Id = "STU-001", Name = "Abebe", Age = 20, GPA = 3.5m };
// Console.WriteLine($"Student: {student.Id} - {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
// // Invalid age — should throw
// try
// {
//     student.Age = 15;
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine($"Caught: {ex.Message}");
// }
// // Invalid GPA — should throw
// try
// {
//     student.GPA = 4.5m;
// }
// catch (ArgumentOutOfRangeException ex)
// {
//     Console.WriteLine($"Caught: {ex.Message}");
// }

// void PrintGradeReport(IEnumerable<IGradable> assessments)
// {
//     Console.WriteLine("--- Grade Report---");
//     foreach (var item in assessments)
//     {
//         Console.WriteLine($"{item.Title}: {item.CalculateGrade():F2}%");
//     }
//     }
//     // Test it — one array holds two completely different types
//     IGradable[] cohortAssessments = [
//         new Quiz { Title = "C# Basics", CorrectAnswers = 18, TotalQuestions = 20 },
//         new LabAssignment { Title = "Registration API", FunctionalityScore = 90m, CodeQualityScore =
//         85m}
// ];
// PrintGradeReport(cohortAssessments);

// var service = new EnrollmentService();
// // Test 1: Valid registration
// var validStudent = new Student { Id = "S1", Name = "Abeba", Age = 20, GPA = 3.8m };
// var validCourse = new Course { Code = "CS-401", Title = "Advanced C#", Capacity = 30 };
// var result = service.ProcessRegistration(validStudent, validCourse);
// Console.WriteLine($"Enrolled: {result.StudentId} in {result.CourseCode}");

// // Test 2: Null student should throw
// try
// {
//     service.ProcessRegistration(null, validCourse);
// }
// catch (ArgumentNullException ex)
// {
// Console.WriteLine($"Guard caught: {ex.ParamName} /t {ex.Message}");
// }

// var fullCourse = new Course { Code = "CS-402", Title = "Full Course", Capacity = 1 };
// fullCourse.EnrolledCount = 1;
// try
// {
//     service.ProcessRegistration(validStudent, fullCourse);
// }
// catch (InvalidOperationException ex)
// {
// Console.WriteLine($"Business rule: {ex.Message}");
// }

// List<Student> students = [
// new Student { Id = "S1", Name= "Abeba", Age = 22, GPA= 3.8m },
// new Student { Id = "S2", Name= "Kidane", Age = 21, GPA = 2.4m},
// new Student { Id = "S3", Name= "Dawit", Age = 20, GPA= 3.1m },
// new Student { Id = "S4", Name= "Sara", Age = 23, GPA = 3.9m },
// new Student { Id = "S5", Name= "Frehiwot", Age = 19, GPA = 2.0m},
// new Student { Id = "S6", Name= "Yonas", Age = 24, GPA= 3.5m },
// new Student { Id = "S7", Name= "Meron", Age = 22, GPA =1.8m},
// new Student { Id = "S8", Name= "Tesfaye", Age = 21, GPA = 2.9m}
// ];

// var leaderboard = students
// .Where(s=> s.GPA >= 3.5m)
// .OrderByDescending(s=> s.GPA)
// .Select(s=> $"{s.Name} (GPA: {s.GPA:F2})").ToList()
// ;

// Console.WriteLine($"Found {leaderboard.Count} Honors Students:");
// foreach (var name in leaderboard)
// {
//     Console.WriteLine(name);
// }

// decimal averageGpa = students.Average(s=> s.GPA);
// Console.WriteLine($"\n Class Average GPA: {averageGpa:F2}");

// var standingGroups = students.GroupBy(s=> s.GPA switch
// {
//     >= 3.5m => "Honors",
//     >= 2.5m => "Good Standing",
//     >= 2.0m => "Probation",
//     < 2.0m => "Academic Warning"
// });

// Console.WriteLine("\n---------------Academic Standing Report:----------------");
// foreach (var group in standingGroups)
// {
//     Console.WriteLine($"\n{group.Key} ({group.Count()}):");
//     foreach (var student in group)
//     {
//         Console.WriteLine($"- {student.Name} (GPA: {student.GPA:F2})");
//     }
// };


// string[] backendCourses = ["C#", "ASP.NET Core", "Entity Framework"];
// string[] frontendCourses = ["TypeScript", "Angular"];

// string[] allCourses = [..backendCourses, ..frontendCourses];

// Console.WriteLine($"\nFull curriculum: {string.Join(", ", allCourses)}");

using System.Diagnostics;
// Simulate 5 database calls, each taking 300ms
// THE WRONGWAY:Blocking withThread.Sleep
var sw =Stopwatch.StartNew();
for (int i = 0; i < 5; i++)
{
Thread.Sleep(300); // Thread is HELD for 300ms cannot serve anyone else
}
Console.WriteLine($"Blocking sequential: {sw.ElapsedMilliseconds}ms");
// ASYNC BUTSTILL SEQUENTIAL: Thread released, but calls are one-at-a-time
sw.Restart();
for (int i = 0; i < 5; i++)
{
await Task.Delay(300); // Thread released while waiting but still sequential
}
Console.WriteLine($"Async sequential: {sw.ElapsedMilliseconds}ms");

sw.Restart();
var tasks = Enumerable.Range(0, 5).Select(_ => Task.Delay(300));
await Task.WhenAll(tasks);
Console.WriteLine($"Async parallel: {sw.ElapsedMilliseconds}ms");

async Task<Student> FetchStudentAsync(string id)
{
    Console.WriteLine($" Fetching {id}...");
    await Task.Delay(300); // Simulate database latency
    return new Student
    {
        Id = id,
        Name=$"Student-{id}",
        Age = 20,
        GPA=id switch
    {
        "S1" => 3.8m,
        "S2" => 2.4m,
        "S3" => 3.5m,
        "S4" => 1.9m,
        "S5" => 3.2m,
        _ =>2.5m
    }
    };
}

async Task<Course> FetchCourseAsync(string code)
{
    Console.WriteLine($" Fetching course {code}...");
    await Task.Delay(200); // Simulate database latency
    return new Course
    {
        Code = code,
        Title = $"Course-{code}",
        Capacity = code switch
        {
        "CRS-101" => 2,
        "CRS-201" => 30,
        "CRS-301" => 15,
        _ =>25
        }
    };
    
}

string[] studentIds = ["S1", "S2", "S3", "S4", "S5"];
string[] courseCodes = ["CRS-101", "CRS-201", "CRS-301"];

var studentTasks = studentIds.Select(id=> FetchStudentAsync(id));
var courseTasks = courseCodes.Select(code=> FetchCourseAsync(code));

Student[] students = await Task.WhenAll(studentTasks);
Course[] courses = await Task.WhenAll(courseTasks);

Console.WriteLine($"\n\nLoaded {students.Length} students and {courses.Length} courses in {sw.ElapsedMilliseconds}ms");
foreach (var student in students){
    Console.WriteLine($"- {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
}

var enrollCourse = new Course { Code = "CRS-101", Title = "C# Mastery", Capacity = 2 };
var enrollService = new EnrollmentService();
var enrollments = new List<EnrollmentRecord>();
var failures = new List<string>();

sw.Restart();
foreach (var student in students)
{
    try
    {
        var enrollment = enrollService.ProcessRegistration(student, enrollCourse);
        enrollCourse.EnrolledCount++;
        enrollments.Add(enrollment);
        Console.WriteLine($"Enrolled {student.Name} in {enrollCourse.Title}");
    }
    catch (InvalidOperationException ex)
    {
        failures.Add($"Failed to enroll {student.Name}: {ex.Message}");
        Console.WriteLine($" Rejected: {student.Name} {ex.Message}");
    }
}

failures.ForEach(f => Console.WriteLine(f));
Console.WriteLine($"\nEnrollment process completed in {sw.ElapsedMilliseconds}ms with {enrollments.Count} enrollments and {failures.Count} failures.");