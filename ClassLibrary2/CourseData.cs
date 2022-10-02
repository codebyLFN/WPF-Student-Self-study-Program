using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class CourseData
    {
        //Declarations with setters and getters
        public DateTime SemesterStart { get; set; }
        public string ModuleCode { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredits { get; set; }
        public int ModuleWeeklyClassHours { get; set; }
        public int TotalSemesterWeeks { get; set; }
        public DateTime SpecificDate { get; set; }
        public int Hours { get; set; }

        //Constructor
        public CourseData(DateTime semesterStart, string moduleCode, string moduleName, int moduleCredits, int moduleWeeklyClassHours, int totalSemesterWeeks, DateTime specificDate, int hours)
        {
            SemesterStart = semesterStart;
            ModuleCode = moduleCode;
            ModuleName = moduleName;
            ModuleCredits = moduleCredits;
            ModuleWeeklyClassHours = moduleWeeklyClassHours;
            TotalSemesterWeeks = totalSemesterWeeks;
            SpecificDate = specificDate;
            Hours = hours;
        }

        public CourseData()
        {
        }

        //method for calculating study hours
        public double StudyHours()
        {
            double formulated = (ModuleCredits * 10) / (TotalSemesterWeeks - ModuleWeeklyClassHours);
            return formulated;
        }

        //method for calculating self study hours
        public double Remaining_hours()
        {
            //self study hours calculations
            double remainingHours = StudyHours() - Hours;
            return remainingHours;
        }
    }
}
