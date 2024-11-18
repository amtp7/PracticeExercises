namespace PracticeExercises.Common
{
    public abstract class GenericExerciseBuilder<TInput, TSolution, TOutput, TInputEntity, TOutputEntity>(
        TInput input,
        TSolution solution,
        TOutput output)
            : GenericExercise<TInput, TSolution, TOutput, TInputEntity, TOutputEntity>(input, solution, output)
                where TInput : GenericInput<TInputEntity>
                where TSolution : GenericSolution<TInputEntity, TOutputEntity>
                where TOutput : GenericOutput<TOutputEntity>
    {

    }
}
