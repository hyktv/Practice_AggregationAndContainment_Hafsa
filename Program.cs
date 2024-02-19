namespace Practice_AggregationAndContainment_Hafsa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instrutcor
            Instructor instructor = new Instructor("Will", "Cram");

            SchoolProgram prog124 = new SchoolProgram("Prog", "124", "J102", instructor);

            prog124.AddStudent("Ana", "Mendes", 10, 52);


            prog124.AddStudent("Hafsa", "Mohamed", 90, 90);
            prog124.AddStudent("Khalid", "Mohamed", 1, 2);
            prog124.AddStudent("Asha", "Omar", 100, 100);


            //display info
            Console.WriteLine(prog124.ToString());
            Console.WriteLine($"Instructor:{instructor}");

        }//main


    }//class


}//namespace