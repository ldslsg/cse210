namespace YourNamespace
{
    class MathAssignment : Assignment
    {
        private int mathDifficulty;
        private string homeworkList;

        public MathAssignment(string studentName, string topic, int mathDifficulty, string homeworkList) : base(studentName, topic)
        {
            this.homeworkList = homeworkList;
            this.mathDifficulty = mathDifficulty;
        }

        public string GetMathAssignmentSummary()
        {
            return $"{GetSummary()} - Difficulty Level: {mathDifficulty}";
        }


        public string GetHomeworkList()
        {
            return homeworkList;
        }
    }
}