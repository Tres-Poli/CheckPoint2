using System.Linq;
using System.Text;

namespace CheckPoint2
{
    public class Student
    {
        private Person _person;
        private Education _education;
        private int _groupNumber;
        private Exam[] _exams;

        public Student(Person person, Education education, int groupNumber)
        {
            _person = person;
            _education = education;
            _groupNumber = groupNumber;
        }

        public Student()
        {
            _person = new Person();
            _education = Education.Bachelor;
            _groupNumber = 0;
        }

        public Person Person
        {
            get { return _person; }
            set { _person = value; } 
        }

        public Education Education
        {
            get { return _education; }
            set { _education = value; }
        }

        public int GroupNumber
        {
            get { return _groupNumber; }
            set { _groupNumber = value; }
        }

        public Exam[] Exams
        {
            get { return _exams; }
            set { _exams = value; }
        }

        public double AvarageGrade
        {
            get
            {
                return _exams.Select(x => x.Grade).Sum() / _exams.Count();
            }
        }

        public bool this[Education education]
        {
            get
            {
                return _education == education;
            }
        }

        public void AddExam(params Exam[] exams)
        {
            _exams = _exams.Concat(exams).ToArray();
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Person - {_person.FirstName} {_person.LastName}");
            sb.AppendLine($"Education - {_education}");
            sb.AppendLine($"Group number - {_groupNumber}");

            foreach (var exam in _exams)
            {
                sb.AppendLine($"Exam {exam.DisciplineName} - {exam.Grade} ({exam.ExamDate})");
            }

            return sb.ToString();
        }

        public virtual string ToShortString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Person - {_person.FirstName} {_person.LastName}");
            sb.AppendLine($"Education - {_education}");
            sb.AppendLine($"Group number - {_groupNumber}");

            return sb.ToString();
        }
    }
}
