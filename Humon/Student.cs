namespace Humon
{
    public class Student
    {
        private protected int age;
        public string name;
        internal string lname;

        public void GetInfo()
        {
            int x;
            Console.WriteLine($"Name:{name}, Age:{age}, LName:{lname}");
        }
    }
}