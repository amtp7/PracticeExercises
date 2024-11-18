namespace PracticeExercises.Common
{
    public class GenericExercise<TInput, TSolution, TOutput, TInputEntity, TOutputEntity>(
        TInput input,
        TSolution solution,
        TOutput output)
            where TInput : GenericInput<TInputEntity>
            where TSolution : GenericSolution<TInputEntity, TOutputEntity>
            where TOutput : GenericOutput<TOutputEntity>
    {
        private readonly TInput _input = input;
        private readonly TSolution _solution = solution;
        private readonly TOutput _output = output;

        public void RunExercise()
        {
            var inputData = _input.GenerateInput();
            var outputData = _solution.SolveExercise(inputData);
            _output.PrintSolution(outputData);
        }
    }
}
