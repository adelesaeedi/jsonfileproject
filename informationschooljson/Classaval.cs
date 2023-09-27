
namespace informationschooljson
{
    public class classaval

    {
        public class Root
        {
            public string subject { get; set; }
            public Teacher teacher { get; set; }
            public List<Student> student { get; set; }
        }

        public class Teacher
        { 
            public string Name { get; set; }
            public string Family { get; set; }
            public int Age { get; set; }
        }

        public class Student
        {
            public string Name { get; set; }
            public string Family { get; set; }
            public int Age { get; set; }
        }
    }
}

