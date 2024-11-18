namespace PracticeExercises.LinqExercise.Input
{
    using PracticeExercises.Common;
    using PracticeExercises.LinqExercise.Entities;

    public class StudentsInput : GenericInput<List<Student>>
    {
        public override List<Student> GenerateInput() =>
        [
            new Student("Alice", 20, [90, 85, 88]),
            new Student("Bob", 21, [78, 82, 84]),
            new Student("Charlie", 20, [92, 91, 89])
        ];
    }
}