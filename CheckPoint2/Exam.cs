using System;
using System.Text;

namespace CheckPoint2
{
    public class Exam
    {
        public string DisciplineName { get; set; }
        public int Grade { get; set; }
        public DateTime ExamDate { get; set; }

        public Exam(string disciplineName, int grade, DateTime examDate)
        {
            DisciplineName = disciplineName;
            Grade = grade;
            ExamDate = examDate;
        }

        public Exam()
        {
            DisciplineName = string.Empty;
            Grade = 0;
            ExamDate = DateTime.Now;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Discipline name - {DisciplineName}");
            sb.AppendLine($"Grade - {Grade}");
            sb.AppendLine($"Exam date - {ExamDate.ToString()}");

            return sb.ToString();
        }
    }
}
