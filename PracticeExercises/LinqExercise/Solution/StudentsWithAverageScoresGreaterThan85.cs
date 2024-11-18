namespace PracticeExercises.LinqExercise.Solution
{
    using PracticeExercises.Common;
    using PracticeExercises.LinqExercise.Entities;

    public class StudentsWithAverageScoresGreaterThan85()
        : GenericSolution<List<Student>, List<Student>>
    {
        public override List<Student> SolveExercise(List<Student> input)
        {
            return input
                .Where(student => student.Scores.Average() > 85)
                .ToList();
        }
    }
}
