using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gradebook
{
    class Statistics
    {
        List<int> sortmark;
        public Statistics(Dictionary<String, int> Marklist)
        {
            sortmark = new List<int>();
            var marks = Marklist.Values;
           
            foreach (int m in marks)
            {
                sortmark.Add(m);
            }
            sortmark.Sort();
        }
        float _mean;
        float _median;
        double _variance;
        double _standarddeviation;
        float _lowestgrade;
        float _highestgrade;
        float _averagegrade;
        public float Mean
        {
            get
            {
                int total = 0;
                foreach (int x in sortmark)
                {
                    total += x;
                }
                _mean = (float)total / sortmark.Count();
                return _mean;
            }
        }
        public float Median
        {
            get
            {
                int ind = sortmark.Count() / 2;
                if (sortmark.Count() % 2 == 1)
                {
                    _median = sortmark[ind];
                }
                else if (sortmark.Count() % 2 == 0)
                {
                     _median = (sortmark[ind]+sortmark[ind-1])/2;
                }

                return _median;
            }
        }
        public double Variance(float mean)
        {

            double dividend = 0;
            foreach (int x in sortmark)
            {
                double sub = mean - x;
                double square = Math.Pow(sub, 2);
                dividend += square;
            }
            _variance = dividend /sortmark.Count();
            return _variance;
        }
        public double Standarddeviation(double variance)
        {
            _standarddeviation = Math.Sqrt(variance);
            return _standarddeviation;
        }
        public float Lowestgrade
        {
            get
            {
                _lowestgrade=(float)sortmark[0] / 100;
                return _lowestgrade;
            }
        }
        public float Highestgrade
        {
            get
            {
                _highestgrade = (float)sortmark[sortmark.Count() - 1]/100;
                return _highestgrade;
            }
        }
        public float Averagegrade
        {
            get
            {
                _averagegrade = Mean / 100;
                return _averagegrade;
            }
        }
    }
}
 