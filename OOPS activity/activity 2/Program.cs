using activity_2.models;

internal class Program
{
    public static void Main(string[] args)
    {
        patient patient1= new patient(1, "John ", "fever");

        patient1.ShowDetails();

        patient patient2 = new patient(2, "ben", "headache");

        patient2.ShowDetails();
    }
}