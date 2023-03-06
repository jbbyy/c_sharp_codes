using System.IO;
using System.Xml;

class notes
{
   public int id { get; set; }
   public string title { get; set; }
   public string description { get; set; } 
    
   public DateTime date { get; set; }

}

class app
{
    static void Main(string[] args)
    {
        List<notes> n = new List<notes>();


        Boolean contin = true;
        while (contin)
        {
            Console.WriteLine("Welcome to the system \n Select Option number \n 1.Create Note \n 2.View Note \n 3.View All Notes \n 4. Update notes\n 5. Delete Note");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a == 1)
            {


                Console.WriteLine("Enter Id ");
                int v = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter title ");
                string b = Console.ReadLine();
                Console.WriteLine("Enter description");
                string c = Console.ReadLine();
                DateTime currentDate = DateTime.Now;
                n.Add(new notes { id = v, title = b, description = c, date = currentDate });

                string fileName = $@"D:\ {v}.txt";
                FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
                StreamWriter sw = new StreamWriter(fs);
                
         

                    sw.WriteLine($"Id = {v}\nTitle = {b}\n Description = {c}\n Date = {currentDate}");


            }

            else if (a == 2)
            {

                Console.WriteLine("Enter Id");
                long x = Convert.ToInt32(Console.ReadLine());
                string fileName = $@"D:\ {x}.txt";

                if (!File.Exists(fileName))
                {
                    Console.WriteLine("id does not exists");

                }
                else
                    using (StreamReader sr = File.OpenText(fileName))
                    {
                        Console.WriteLine(sr.ReadToEnd());
                    }



            }

            else if (a == 3)
            {
                DirectoryInfo d = new DirectoryInfo(@" D:\");

                Console.WriteLine(d);


            }

            else if (a == 4)
            {
                Console.WriteLine("Enter Id of file to update");
                long v = Convert.ToInt32(Console.ReadLine());
                string fileName = $@"D:\ {v}.txt";

                StreamReader reader = new StreamReader(fileName);
                string readedData = reader.ReadToEnd();
                reader.Close();

                Console.WriteLine("Enter title or description to modify");
                string o = Console.ReadLine();
                Console.WriteLine("Enter new title or new description to modify");
                string p = Console.ReadLine();
                readedData.Replace(o, p);


                StreamWriter writer = new StreamWriter(fileName, false);
                writer.Write(readedData);
                writer.Close();


            }

            else

            {
                Console.WriteLine("Enter Id of file to be deleted");
                long z = Convert.ToInt32(Console.ReadLine());
                File.Delete($@"D:\ {z}.txt");
            }



            Console.WriteLine("Continue program? Y or N");
            string e = Console.ReadLine();
            if (e == "N")
            {
                contin = false;
            }
        } }


    }

