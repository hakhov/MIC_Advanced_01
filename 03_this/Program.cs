using _01_Class_Object;

int x = 10;
Console.WriteLine(x);
Student student = new();
Student student1 = new("Tom1", 45);
Student student2 = new("Tom2");
Student student3 = new("Tom3", 78, 45789);
student.GetStudentInfo();
student1.GetStudentInfo();
student2.GetStudentInfo();
student3.GetStudentInfo();

Student st;
int y;

