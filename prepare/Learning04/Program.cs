namespace YourNamespace{

    class Program

    {
        static void Main(string[] args)
        {
            Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
            string summary = assignment.GetSummary();

            Console.WriteLine(summary); // Output: Samuel Bennett - Multiplication
        

                MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", 3, "Section 7.3 Problems 8-19");

                string mathSummary = mathAssignment.GetMathAssignmentSummary();
                string homeworkList = mathAssignment.GetHomeworkList();

                Console.WriteLine(mathSummary); // Output: Roberto Rodriguez - Fractions - Difficulty Level: 3
                Console.WriteLine(homeworkList); // Output: Section 7.3 Problems 8-19
        
    }
}}