using poly_task.models;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Patient patient1 = new Patient("tony stark", 30, "Flu");
        Console.WriteLine($"Patient Name: {patient1.getName()}, Age: {patient1.getAge()}, Disease: {patient1.getDisease()}");


        Staff doctor = new Doctor("Dr. Strange");
        Staff doctor2 = new Doctor("Dr. Doom");

        Staff nurse = new Nurse("Nurse wanda");

        Staff receptionist = new Receptionist("Pepper Potts");


        Console.WriteLine($"Doctor Salary: {doctor.calculateSalary()}");
        Console.WriteLine($"Nurse Salary: {nurse.calculateSalary()}");
        Console.WriteLine($"Receptionist Salary: {receptionist.calculateSalary()}");
        Console.WriteLine($"Doctor2 Salary: {doctor2.calculateSalary()}");


        Appointment onlineAppointment = new OnlineAppointment(patient1, doctor);
        onlineAppointment.ScheduleAppointment();


        Appointment offlineAppointment = new OfflineAppointment(patient1, nurse);
        offlineAppointment.ScheduleAppointment();

        

    }
}