using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electronic_Gradebook
{
    public class Grade
    {
        String _subject;

        public String Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }
        float _mark;

        public float Mark
        {
            get { return _mark; }
            set { _mark = value; }
        }
        public Grade(String Subject,float Mark)
        {
            this.Subject = Subject;
            this.Mark = Mark;
        }
       
        public String Subjectresult
        {
            get 
            {
                String result = "fail";
                if (Mark >= 35)
                {
                    result = "Pass";
                }
                return result; 
            }
           
        }
        public String Lettergrade
        {
            
            get
            {
                String Letter = "";
                if (Mark > 90)
                {
                    Letter = "A";
                }
                else if (Mark > 80)
                {
                    Letter = "B";
                }
                else if (Mark > 70)
                {
                    Letter = "C";
                }
                else if (Mark > 60)
                {
                    Letter = "D";
                }
                else if (Mark > 50)
                {
                    Letter = "E";
                }
                else if (Mark < 50)
                {
                    Letter = "F";
                }
                return Letter;
            }
        }
       


    }
}
