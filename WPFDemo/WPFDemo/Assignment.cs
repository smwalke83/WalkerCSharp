using System;
using System.Collections.Generic;
using System.Text;

namespace WPFDemo
{
    public class Assignment
    {
        public string Title { get; set; }
        private int score;

        public int Score 
        {
            get { return score; }
            set 
            {
                if (value >= 0 && value <= 100)
                {
                    score = value;
                }
                else 
                {
                    throw new ArgumentOutOfRangeException("Scores must be between 0 and 100");
                }
            }
        }

        public override string ToString()
        {
            return Title + " " + score;
        }
    }
}
