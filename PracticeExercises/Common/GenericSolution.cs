namespace PracticeExercises.Common
{
    public abstract class GenericSolution<TInputEntity, TOutputEntity>
    {
        public abstract TOutputEntity SolveExercise(TInputEntity input);
    }
}
