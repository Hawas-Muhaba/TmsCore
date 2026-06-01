public class EnrollmentService
{
    public EnrollmentRecord ProcessRegistration(Student? student, Course? course)
    {
        if (student is null)
        {
            throw new ArgumentNullException(nameof(student), "Student cannot be null.");
        }
        if (course is null)
        {
            throw new ArgumentNullException(nameof(course), "Course cannot be null.");
        }
        if (course.EnrolledCount >= course.Capacity)
        {
            throw new InvalidOperationException($"Course {course.Code} is at full capacity.");
        }
        

        string standing = student.GPA switch
        {
            >= 3.5m => "Honors",
            >= 2.5m => "Good Standing",
            < 2.5m => "Academic Warning"
        };
        Console.WriteLine($"Student {student.Name} is in {standing} with a GPA of {student.GPA}.");
    
        return new EnrollmentRecord(student.Id, course.Code, DateTime.UtcNow);
    }

    
}