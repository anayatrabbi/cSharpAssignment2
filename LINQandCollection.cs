using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace cSharpAssignment2
{
    public class LINQandCollection
    {
        public enum GradeLevel { FirstYear = 1, SecondYear, ThirdYear, FourthYear };

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public GradeLevel Year;
        //collection
        public List<int> ExamScores;

        protected static  List<LINQandCollection> students = new List<LINQandCollection>
        {
            new LINQandCollection {FirstName = "anayat", LastName = "Khan", Id = 120,
                Year = GradeLevel.SecondYear,
                ExamScores = new List<int> { 99, 82, 81, 79}},
            new LINQandCollection  {FirstName = "Mohana", LastName = "Fkhan", Id = 116,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int> { 99, 86, 90, 94}},
            new LINQandCollection  {FirstName = "Zarin", LastName = "tasnim", Id = 117,
                Year = GradeLevel.FirstYear,
                ExamScores = new List<int> { 93, 92, 80, 87}},
            new LINQandCollection  {FirstName = "faruk", LastName = "hassan", Id = 114,
                Year = GradeLevel.FourthYear,
                ExamScores = new List<int> { 97, 89, 85, 82}},
            new LINQandCollection  {FirstName = "masud", LastName = "abdullah", Id = 115,
                Year = GradeLevel.ThirdYear,
                ExamScores = new List<int> { 35, 72, 91, 70}}
       
        };
        //LINQ method
        public  void QueryHighScores(int exam, int score)
        {
            var highScores = from n in students
                             where n.ExamScores[exam] > score
                             select new { Name = n.FirstName, Score = n.ExamScores[exam] };

            foreach (var item in highScores)
            {
                Console.WriteLine($"{item.Name,-15}{item.Score}");
            }
        }
    }
}
