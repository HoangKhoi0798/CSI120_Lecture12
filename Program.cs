using System.Reflection.Metadata.Ecma335;

namespace CSI120_Lecture12
{
    internal class Program
    {
        // Class



        static int sizeOfArray = 5;
        static string[] nameOfExercises = new string[sizeOfArray];
        static int[] numberOfReps = new int[sizeOfArray];
        static double[] weights = new double[sizeOfArray];
        static Excercise[] excercises = new Excercise[5];
        static void Main(string[] args)
        {

            Preload();
            PreloadExcercises();


            DisplayExcersisesObjects();

            // Null References

            int[] numberArray = new int[3];
            // |0|0|0|

            Excercise[] excerciseArray = new Excercise[3];
            // |null|null|null|

            // Creating an instance of our class, Excercises
            // DataType variableName - (new Keyword) TypeName();

            // What fields did we add to our class?
            // Name
            // Reps
            // Weight
            // Barbell Curls - 15 - 20e
            //Excercise willExcercise1 = new Excercise("Barbell Curls", 15, 20); // Default Constructor
            //Excercise willExcercise2 = new Excercise();
            ////willExcercise1.Name = "Barbell Curls";
            ////willExcercise1.Reps = 15;
            ////willExcercise1.Weight = 20;

            //DisplayExcerisesInstance(willExcercise1);
            //DisplayExcerisesInstance(willExcercise2);




        }// Main

        // Method to display all excersises

        // Load our Excercises array with our excercises

        public static void PreloadExcercises()
        {
            Excercise excercise0 = new Excercise("Bench Press", 10, 135);
            excercises[0] = excercise0;

            Excercise excercise1 = new Excercise("Squats", 12, 185);
            excercises[1] = excercise1;

            Excercise excercise2 = new Excercise("Dead Lift", 8, 225);
            excercises[2] = excercise2;

            excercises[3] = new Excercise("Overhead Press", 10, 95);
            excercises[4] = new Excercise("Bent Over Row", 12, 115);

        }

        public static void DisplayExcersisesObjects()
        {
            for (int i = 0; i < excercises.Length; i++)
            {
                Console.WriteLine("");
                Excercise currentExcercise = excercises[i];
                DisplayExcerisesInstance(currentExcercise);
            }
        }

        public static void DisplayExcersises()
        {
            for (int i = 0; i < sizeOfArray; i++)
            {
                FormatExcercises(i);
            }
        }// Display

        public static void DisplayExcerisesInstance(Excercise excercise)
        {
            Console.WriteLine(excercise.Name);
            Console.WriteLine(excercise.Reps);
            Console.WriteLine(excercise.Weight);
        }

        public static void FormatExcercises(int index)
        {
            Console.WriteLine(nameOfExercises[index]);
            Console.WriteLine(numberOfReps[index]);
            Console.WriteLine(weights[index]);
            Console.WriteLine();
        }

        // Preload

        public static void Preload()
        {

            // Index 0-4
            EnterValueIntoArray(0, "Bench Press", 10, 135);

            EnterValueIntoArray(1, "Squats", 12, 185);

            EnterValueIntoArray(2, "Dead Lift", 8, 225);

            EnterValueIntoArray(3, "Overhead Press", 10, 95);

            EnterValueIntoArray(4, "Bent Over Row", 12, 115);


        }// Preload

        // Enter a new value to our array
        // We need to pass in index, name, rep and weight
        public static void EnterValueIntoArray(int index, string name, int rep, double weight)
        {
            nameOfExercises[index] = name;
            numberOfReps[index] = rep;
            weights[index] = weight;

        }// Array Value

    }// Class

    // In between closing for class and namespace
    // Create new class

    // Define a class
    // public - keyword class - Class Name (Must be "capital")
    // Name should be singular
    // Directly related to what the class is about
    public class Excercise
    {
        // Fields
        public string Name;
        public int Reps;
        public double Weight;


        // Constructor
        // Create new constructor
        // public ClassName (parameter) {Code}
        public Excercise(string name, int rep, double weight)
        {
            // Field = parameter
            Name = name;
            Reps = rep;
            Weight = weight;

        }

        // Create new default constructor
        // A constructor takes no parameters
        public Excercise()
        {
            Name = "No Excercises";
            Reps = -1;
            Weight = -1;
        }

        // Methods


    }


}// Name

