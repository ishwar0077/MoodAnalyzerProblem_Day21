﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyzerProblem
{
    public class MoodAnalyser
    {
        public string Analyser(string message)
        {
            if (message.Contains("Sad"))
                return "SAD";
            else
                return "HAPPY";
        }
    }
}
