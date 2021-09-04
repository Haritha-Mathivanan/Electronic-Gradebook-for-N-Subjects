using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gradebook
{
    public class Student
    {
        string _studentname;

        public string Studentname
        {
            get { return _studentname; }
            set { _studentname = value; }
        }
        string _Studentrollno;

        public string Studentrollno
        {
            get { return _Studentrollno; }
            set { _Studentrollno = value; }
        }
        Dictionary<String, int> _marklist;

        public Dictionary<String, int> Marklist
        {
            get { return _marklist; }
            set { _marklist = value; }
        }

        
        
        public Student()
        {
            Studentname = "xxx";
            Studentrollno = "xxx";
            
        }
        
    }
}
