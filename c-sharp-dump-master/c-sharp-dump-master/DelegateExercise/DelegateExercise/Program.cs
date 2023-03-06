


/* Write a C# program to create a multicast delegate with name AttendanceLogHandler. 
 * This delegate should hold the reference of 2 methods - CreateLog & MarkAttendance.
 * Both the methods are taking EmployeeId as string parameter.
 * CreateLog method is creating a log file with the same name as EmployeeId if file not exists. 
 * If the log file already exists it should display a message on console as Log File already exists 
 * whereas MarkAttendance is writing the attendance in the file with current system datetime.
 * For example, the log file should have the entry like this - E2314 has marked the attendance on 16-09-2020 09:30:04.
 * In main method write the code to take EmployeeId as input from user and pass it to AttedanceLogHandler delegate.
 * You have to call the methods using delegate.  */


using System.Reflection.Metadata.Ecma335;

delegate void AttendanceLogHandler(string employeeId);

class attendance
{
    public void CreateLog(string employeeId)
    {
        string filename = employeeId + ".log";
        if ( File.Exists(filename))
        {
            Console.WriteLine("Log file already exist");
        }
        else
        {
            File.Create(filename).Dispose();  // saving files into current working directory
            // where this program is saved. D:\Coding practice\DelegateExercise\DelegateExercise\bin\Debug\net6.0
            Console.WriteLine("Log file created");
        }
    }

    public void MarkAttendance(string employeeId)
    {
        string fileName = employeeId + ".log";
        string attendance = $"{employeeId} has marked the attendance on {DateTime.Now}";
        File.AppendAllText(fileName, attendance);

    }

}

class Program
{
    public static void Main(string[] args)

    {

        Console.WriteLine("Enter employeeId");
        string employeeId = Console.ReadLine();
        attendance a = new attendance();
        AttendanceLogHandler b = new AttendanceLogHandler(a.CreateLog);
        b += new AttendanceLogHandler(a.MarkAttendance);

        b(employeeId);
    }

} 