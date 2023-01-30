// Create a system in which Students can register for Courses
// A student may only take one Course, where a Course can have many students

// Student Class
// Course Class

// one-to-many relationship
using School;

int courseNum = School.CreateCourse("Debugging", 12);
int studentNum = School.CreateStudent("Wavy", "Davy");

try
{
    School.EnrolStudent(studentNum, courseNum);
} catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
