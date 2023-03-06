
using System.Threading;
class Demo
{
    public void show()
    {
        for (int i = 1; i <= 10; i++)//increasing from 1
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is printing {i}");
            Thread.Sleep(1000); // i gets printed with a lag time of 1 sec
        }
    }
   public void display()
    {
        for (int i = 10; i > 0; i--)// decreasing from 10
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is printing {i}");
            Thread.Sleep(1000);
        }
    }
}
internal class Program
    {
    static void Main(string[] args) {
        Demo d = new Demo();
        //Thread t1 = new Thread(new ThreadStart(d.show)));
        ThreadStart ts = new ThreadStart(d.show);
        Thread t1 = new Thread(ts);

        // create new instance of thread 
        //The ThreadStart  = delegate is used to specify the method that the thread should execute when it starts. 
        //In this case, the method reference is d.show. This method will be executed when the thread starts.

        Thread t2 = new Thread(new ThreadStart(d.display));
        t1.Name = "Thread 1";
        t2.Name = "Thread 2";
        t1.Start();
        t2.Start();


    }
}