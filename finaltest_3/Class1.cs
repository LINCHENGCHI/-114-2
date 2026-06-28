using System;

public interface IName
{
    public string GetName();
}
public class Student:IName
{
    public string GetName()
    {
        return "Student";
    }
}

public class Teacher : IName
{
    public string GetName()
    {
        return "Teacher";
    }
}