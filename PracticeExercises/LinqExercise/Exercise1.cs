namespace PracticeExercises.LinqExercise
{
    using PracticeExercises.Common;
    using PracticeExercises.LinqExercise.Entities;
    using PracticeExercises.LinqExercise.Input;
    using PracticeExercises.LinqExercise.Output;
    using PracticeExercises.LinqExercise.Solution;

    public class Exercise1(StudentsInput input, StudentsWithAverageScoresGreaterThan85 solution, StudentsOutput output)
        : GenericExercise<StudentsInput, StudentsWithAverageScoresGreaterThan85, StudentsOutput, List<Student>, List<Student>>(input, solution, output)
    {
    }
}
