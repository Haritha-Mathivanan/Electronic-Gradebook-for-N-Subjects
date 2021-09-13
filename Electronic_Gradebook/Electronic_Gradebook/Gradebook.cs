using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electronic_Gradebook
{
    class Gradebook
    {
        String _name;

        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        String _rollno;

        public String Rollno
        {
            get { return _rollno; }
            set { _rollno = value; }
        }
        int _class;

        public int Class
        {
            get { return _class; }
            set { _class = value; }
        }
        String _section;

        public String Section
        {
            get { return _section; }
            set { _section = value; }
        }
        List<Grade> _gradelist;
        public Gradebook(String Name,String Rollno,int Class,String Section)
        {
            this.Name = Name;
            this.Rollno = Rollno;
            this.Class = Class;
            this.Section = Section;
            _gradelist = new List<Grade>();
        }
        public Gradebook()
        {        }
        float _total;
        public float Total
        {
             get
            {
                _total = 0;
           
                foreach (Grade g in _gradelist)
                {
                    _total += g.Mark;
                }
                return _total;
            }
        }
        public bool Addgrade(String subject,float mark)
        {
            _gradelist.Add(new Grade(subject,mark));
            return true;
        }
        public bool Removegrade(String subject)
        {
            Grade toremove;
            foreach (Grade g in _gradelist)
            {
                if (g.Subject == subject)
                {
                    toremove = g;
                    _gradelist.Remove(toremove);
                    return true;
                }
                
            }
            return false;
           
        }
        public bool Updategrade(String subject,float mark)
        {
            foreach(Grade g in _gradelist)
            {
                if (g.Subject == subject)
                {
                    g.Mark = mark;
                    return true;
                }
            }
            return false;
        }
        public Gradestatistics Calculatestatistics()
        {
            float highgrade =float.MinValue;
            float lowgrade=float.MaxValue;
            float avggrade = (Total / _gradelist.Count);
            foreach (Grade g in _gradelist)
            {
                if (highgrade < g.Mark)
                {
                    highgrade = g.Mark;
                }
                if(lowgrade>g.Mark)
                {
                    lowgrade = g.Mark;
                }

            }
           
            return new Gradestatistics(highgrade,lowgrade,avggrade);

        }
        public String Studentresult
        {
            get
            {
                String result = "Pass";
                foreach(Grade g in _gradelist)
                {
                    if (g.Subjectresult == "fail")
                    {
                        result = "fail";
                        break;
                    }
                }
                return result;
            }
        }
        public override string ToString()
        {
            String x = "_______________________________________________________________________\n"
                +"Student Name :   "+Name+"\t\t\t"+" Class :  " +Class+"\n"+"Roll Number : "+Rollno+"\t\t\t"+"Section :  "+Section
                +"\n"+"_______________________________________________________________________\n"+
                "Subject Name\t|\tMarks\t|\tLetterGrade\t|\tResult"+"\n____________________________________________________________________\n";
            
            foreach (Grade g in _gradelist)
            {
                x += g.Subject + "\t\t|\t" + g.Mark + "\t|\t" + g.Lettergrade + "\t|\t" + g.Subjectresult+"\n";
            }
            x += "_______________________________________________________________________________\n";
            x += "                                                         Total : " + Total+"\n";
            x += "                                                         Student Result:" + Studentresult;
            return x;
        }




    }
}
