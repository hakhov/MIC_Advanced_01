class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
            {
                throw new PersonException("Person shoulb be old than", value);
            }
            else
            {
                age = value;
            }
        }
    }
}
