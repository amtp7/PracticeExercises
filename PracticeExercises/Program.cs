using PracticeExercises.LinqExercise;
using PracticeExercises.LinqExercise.Input;
using PracticeExercises.LinqExercise.Output;
using PracticeExercises.LinqExercise.Solution;

// Exercise 1
var input = new StudentsInput();
var solution = new StudentsWithAverageScoresGreaterThan85();
var output = new StudentsOutput();

var exercise1 = new Exercise1(input, solution, output);
exercise1.RunExercise();

