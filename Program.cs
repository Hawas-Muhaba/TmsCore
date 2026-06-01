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

List<Student> students = [
new Student { Id = "S1", Name= "Abeba", Age = 22, GPA= 3.8m },
new Student { Id = "S2", Name= "Kidane", Age = 21, GPA = 2.4m},
new Student { Id = "S3", Name= "Dawit", Age = 20, GPA= 3.1m },
new Student { Id = "S4", Name= "Sara", Age = 23, GPA = 3.9m },
new Student { Id = "S5", Name= "Frehiwot", Age = 19, GPA = 2.0m},
new Student { Id = "S6", Name= "Yonas", Age = 24, GPA= 3.5m },
new Student { Id = "S7", Name= "Meron", Age = 22, GPA =1.8m},
new Student { Id = "S8", Name= "Tesfaye", Age = 21, GPA = 2.9m}
];

var leaderboard = students
.Where(s=> s.GPA >= 3.5m)
.OrderByDescending(s=> s.GPA)
.Select(s=> $"{s.Name} (GPA: {s.GPA:F2})").ToList()
;

Console.WriteLine($"Found {leaderboard.Count} Honors Students:");
foreach (var name in leaderboard)
{
    Console.WriteLine(name);
}