using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Electronic_Gradebook
{
    class Gradestatistics
    {
        float _highestgrade;

        public float Highestgrade
        {
            get { return _highestgrade; }
            set { _highestgrade = value; }
        }


        float _lowestgrade;

        public float Lowestgrade
        {
            get { return _lowestgrade; }
            set { _lowestgrade = value; }
        }
        float _averagegrade;

        public float Averagegrade
        {
            get { return _averagegrade; }
            set { _averagegrade = value; }
        }
        public Gradestatistics(float Highestgrade,float Lowestgrade,float Averagegrade)
        {
            this.Highestgrade = Highestgrade;
            this.Lowestgrade = Lowestgrade;
            this.Averagegrade = Averagegrade;
        }
        public override string ToString()
        {
            return String.Format("___________________Grade Statistics_____________________ \n Highest Grade : {0} \n Lowest Grade : {1} \n Average Grade : {2:F0}", this.Highestgrade, this.Lowestgrade, this.Averagegrade);
        }

    }
}
