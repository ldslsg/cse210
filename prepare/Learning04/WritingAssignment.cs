using System;

namespace YourNamespace
{
    class WritingAssignment : Assignment
    {
        private string writingTopic;

        public WritingAssignment(string studentName, string topic, string writingTopic)
            : base(studentName, topic)
        {
            this.writingTopic = writingTopic;
        }

        public string GetWritingInformation()
        {
            string studentName = GetStudentName(); // Access the studentName using the GetStudentName method
            return $"{studentName} - {writingTopic}\nThe Causes of World War II by {studentName}";
        }

        private string GetStudentName()
        {
            throw new NotImplementedException();
        }
    }
}
