using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeToSql.Models;

/*
 * Write your model here.
 */

public class Class { 
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Student> Students { get; set; }
    public List<Subject> Subjects { get; set; }
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Subject
{
    public int Id { get; set; }
    public string Name { get; set; }
}


