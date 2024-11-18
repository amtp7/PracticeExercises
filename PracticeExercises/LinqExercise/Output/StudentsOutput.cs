namespace PracticeExercises.LinqExercise.Output
{
    using PracticeExercises.Common;
    using PracticeExercises.LinqExercise.Entities;

    public class StudentsOutput : GenericOutput<List<Student>>
    {
        public override void PrintSolution(List<Student> solution)
        {
            solution.ForEach(student => Console.WriteLine(student.Name));
        }
    }
}
