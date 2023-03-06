class Demo
{
    
    public void Even()
    {
        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} {i} is even");
                Thread.Sleep(500);
            }
        }
    }

    public void Odd()
    {

        for (int i = 1; i <= 10; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} {i} is Odd");
                Thread.Sleep(500);
            }
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        Demo d = new Demo();
        Action a = new Action(d.Even);
        Task t = new Task(a);
        Action b = new Action(d.Odd);
        Task t2 = new Task(b);

        t.Start();
        t.Wait();
        t2.Start();
        t2.Wait();

    }


}

