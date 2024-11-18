namespace PracticeExercises.LinqExercise.Entities
{
    public class Student(string name, int age, List<int> scores)
    {
        public string Name { get; set; } = name;
        public int Age { get; set; } = age;
        public List<int> Scores { get; set; } = scores;
    }
}