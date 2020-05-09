using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{

    class Program

    {
        static class Constants
        {
            public const int one = 1;
            public const int two = 2;
            public const int THree = 3;
            public const int four = 4;
        }
        public void emmailtouser()
            {
            string folder = System.Environment.CurrentDirectory;
            List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
            File.Delete(folder + "/edited.txt");
            StringBuilder sb = new StringBuilder("");
            foreach (var line in comboLines)
            {
                int pits = line.IndexOf("@");
                int test =line.IndexOf(":");
                try
                { 
                sb.Append(line.Substring(0, pits));
                sb.Append(line.Substring(test));
                    sb.Append(Environment.NewLine);
                }
                catch(Exception)
                { Console.WriteLine("execption pepe"); }



                    }
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
        }
        public void first()
        {  string folder = System.Environment.CurrentDirectory;
            List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
            File.Delete(folder + "/edited.txt");
            StringBuilder sb = new StringBuilder("");
            foreach (var line in comboLines)

            {
                sb.Append(char.ToUpper(line[0]));
                sb.Append(line.Substring(1));
                sb.Append(Environment.NewLine);
            }
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
            Console.ReadKey();
           
        }
        public void third()
        {
            string folder = System.Environment.CurrentDirectory;
            List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
            File.Delete(folder + "/edited.txt");
            StringBuilder sb = new StringBuilder("");
            Console.WriteLine("add the number u wante to add to the end of password ");
            string toaddpsw = Console.ReadLine();
            foreach (var line in comboLines)

            {
                sb.Append(line);
                sb.Append(toaddpsw);
                sb.Append(Environment.NewLine);
            }
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
            
        }

        public void pof()
        {
            string folder = System.Environment.CurrentDirectory;
        List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
        File.Delete(folder + "/edited.txt");
            StringBuilder pop = new StringBuilder("");
            StringBuilder bs = new StringBuilder ("");
        StringBuilder sb = new StringBuilder("");
                foreach (var line in comboLines)

                {
                int test = line.IndexOf(':');
                sb.Append(line.Substring(0,test+1));
                try
                { 
                sb.Append(char.ToUpper(line[test + 1]));
                sb.Append(line.Substring(test + 2));
                }
                catch (Exception )
                {
                    Console.WriteLine("exeception pepe");
                }
                //sb.Append(bs);
                sb.Append(Environment.NewLine);
                
                //pop.Append(sb);
                //pop.Append(bs);
                //sb.Append(Environment.NewLine);
               // pop.Append(Environment.NewLine);
            }
            //Console.WriteLine(sb);
            //bs = sb.ToString();
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
                
        }
        public void of()
        {
            string folder = System.Environment.CurrentDirectory;
            List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
            File.Delete(folder + "/edited.txt");
            StringBuilder sb = new StringBuilder("");
            Console.WriteLine("add the number u wante to add to the Fist line of  of password ");
            string toaddpsw = Console.ReadLine();
            //StringBuilder pop = new StringBuilder("");
            //StringBuilder bs = new StringBuilder("");
            //StringBuilder swsb = new StringBuilder("");
            foreach (var line in comboLines)

            {
                int test = line.IndexOf(':');
                sb.Append(line.Substring(0, test + 1));
                try
                {
                    sb.Append(toaddpsw);
                    sb.Append(line.Substring(test + 2));
                }
                catch (Exception )
                {
                    Console.WriteLine("exeception pepe");
                }
                //sb.Append(bs);
                sb.Append(Environment.NewLine);

                //pop.Append(sb);
                //pop.Append(bs);
                //sb.Append(Environment.NewLine);
                // pop.Append(Environment.NewLine);
            }
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
            

        }
        public void usertopass()
        {
            
            
                string folder = System.Environment.CurrentDirectory;
                List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
                File.Delete(folder + "/edited.txt");
                StringBuilder sb = new StringBuilder("");
                foreach (var line in comboLines)

                { int test = line.IndexOf(":");
                sb.Append(line.Substring(0,test));
                sb.Append(":");
                sb.Append(line.Substring(0, test-1));

                sb.Append(Environment.NewLine);

                
                }
            //Console.WriteLine(sb);
                File.AppendAllText(folder + "/edited.txt", sb.ToString());
                Console.WriteLine("job done pepo");
                
            
        }
        public void passtouseer()
        {
            
                string folder = System.Environment.CurrentDirectory;
                List<string> comboLines = File.ReadAllLines(folder + "/combo.txt").ToList();
                File.Delete(folder + "/edited.txt");
                StringBuilder sb = new StringBuilder("");
                //StringBuilder pop = new StringBuilder("");
                //StringBuilder bs = new StringBuilder("");
                //StringBuilder swsb = new StringBuilder("");
                foreach (var line in comboLines)

                {
                    int test = line.IndexOf(':');
                try
                {

                    sb.Append(line.Substring(test + 1));
                    sb.Append(":");
                    sb.Append(line.Substring(test + 1));
                }

                catch (Exception )
                {
                    Console.WriteLine("exeception pepe");
                }
                    //sb.Append(bs);
                    sb.Append(Environment.NewLine);

                    //pop.Append(sb);
                    //pop.Append(bs);
                    //sb.Append(Environment.NewLine);
                    // pop.Append(Environment.NewLine);
                }
            //Console.WriteLine(sb);
            File.AppendAllText(folder + "/edited.txt", sb.ToString());
            Console.WriteLine("job done pepo");
            
        }
        static void Main(string[] args)
         
            {
                
                var comands = new[]
                {
                    @"1- change first letter to uppercase(username)",
                                   @"2 - change first letter to uppercase(password)",
                                   @"3 - add letter or number at the end of the password",
                                   @"4 - add letter or number at the first case of the password",
                                   @"5 - user = password",
                                   @"6 - password = user ",
                                   @"7 -email to user",
            };
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WindowWidth = 200;
                Console.WriteLine("\n\n");
             
                Console.ForegroundColor = ConsoleColor.Red;
                foreach (string line in comands)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("chose your option negro");
                //string one ='1'
                string commando = Console.ReadLine ();
                int pops=Int16.Parse(commando);
           if (pops==1)
            {
            var t = new Program();
            t.first(); }
            if (pops == 2) 
            {
            var t = new Program();
            t.pof(); }
            if (pops == 3) 
            {
            var t = new Program();
            t.third(); }
            if (pops == 4) 
            {
            var t = new Program();
            t.of(); }
            if (pops == 5) 
            {
            var t = new Program();
            t.usertopass(); }
            if (pops == 6) 
            {
            var t = new Program();
            t.passtouseer(); }
            if (pops==7)
            {
                var t = new Program();
                t.emmailtouser() ;
            }
            
            }
        }
    }

