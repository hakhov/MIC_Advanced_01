Student student = new Student();

student[0] = new Person { Id = 1000 };
student[1] = new Person { Id = 2000 };
student[2] = new Person { Id = 3000 };

Console.WriteLine(student[0]);
Console.WriteLine(student[0].Id);

Person onj = student[3];
Console.WriteLine(onj?.Id);