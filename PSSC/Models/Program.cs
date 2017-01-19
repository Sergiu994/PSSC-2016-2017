using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models.Student;
using Models.Subject;
using Models.Generics;
using Models.Professor;
namespace Models
{
    class Program
    {
        private static SubjectInformation subjectInformation;
        private static Dictionary<Student.Student, SubjectSituation> signedUpStudentsGrades;
        private static List<Grade> list;

        static void Main(string[] args)
        {/*
            var subjectsRepository = new SubjectsRepository();
            signedUpStudentsGrades = new Dictionary<Student.Student, SubjectSituation>();
            
           
            list = new List<Grade>();
            list.Add(new Grade(4));
            list.Add(new Grade(5));
            subjectInformation = new SubjectInformation(new PlainText("PSSC"), new Credits(4), EvaluationType.Distributed, Proportion.OneHalf,new Models.Professor.Professor(Guid.NewGuid(), new PlainText("Iercan D")));
            var subject = new Subject.Subject(subjectInformation);
            var _subject = SubjectsFactory.Instance.CreateSubjects(subjectInformation);   
            subjectsRepository.Add(_subject);
       
            Console.WriteLine("\nSubject: " + _subject.SubjectInfo.Name.Text + ", \n" + _subject.SubjectInfo.Credits.Count.ToString() + ", \n" +
                _subject.SubjectInfo.Evaluation.ToString() + ", \n" + _subject.SubjectInfo.ActivityProportion.ToString() +
                 "; \n\nProfessor: " + _subject.SubjectInfo.Professor.Name.Text + ", \n" + _subject.SubjectInfo.Professor.proffesorID.ToString() + "\n");

             subjectsRepository.Delete(_subject);

             Console.WriteLine("\n\nPress any key to terminate.");
             Console.ReadLine();
             */
        }
    }
}
