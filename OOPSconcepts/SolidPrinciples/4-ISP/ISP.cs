namespace OOPSconcepts.SolidPrinciples._4_ISP
{
    // Interface Segregation Resposibilty
    public class ISP
    {
        public static void Main()
        {
        }
    }

    public interface IBasicTask
    {
        void AssignTask();
        void StartTask();
        void CompleteTask();
    }

    public class BasicTask : IBasicTask
    {
        public void AssignTask()
        {
            Console.WriteLine("Task assigned");
        }

        public void StartTask()
        {
            Console.WriteLine("Task started");
        }

        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }

    public interface IComplexTask : IBasicTask
    {
        void PauseTask();
        void ResumeTask();
    }

    public class ComplexTask : IComplexTask
    {
        public void AssignTask()
        {
            Console.WriteLine("Task assigned");
        }

        public void StartTask()
        {
            Console.WriteLine("Task started");
        }

        public void PauseTask()
        {
            Console.WriteLine("Task paused");
        }

        public void ResumeTask()
        {
            Console.WriteLine("Task resumed");
        }

        public void CompleteTask()
        {
            Console.WriteLine("Task completed");
        }
    }
}
