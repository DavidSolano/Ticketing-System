using System;
using System.IO;
using System.Text;

namespace Ticketing_System
{
    class Program
    {
        static void Main(string[] args)
        {
            String file = "ticket.txt";
            int ticketID = 1;
            int amountofpeoplewatching;
            string watchers = " ";
            string answer;
            string summary, status, priority, submitter, assigned;
            string ask;
            string askAgain;
            string betaAsk;

            

            do
            {
                    Console.Write("do you wish to read from file? (y/n)");
                    ask = Console.ReadLine();

                    if (ask == "y"){
                        StreamReader sr = new StreamReader(file);
                        while(!sr.EndOfStream){
                            sr.ReadLine();
                            string line = sr.ReadLine();
                            string[] arr = line.Split(',');
                            for (int u = 0; u < arr.Length; u++)
                            {
                                Console.WriteLine(arr[u]);
                            }
                        }
                        sr.Close();
                    }

                Console.WriteLine("write to file? (y/n)");
                askAgain = Console.ReadLine();

                if (askAgain == "y"){
                    StreamWriter sw = new StreamWriter(file);
                    Console.Write("what is the summary> ");
                    summary = Console.ReadLine();

                    Console.Write("what is the status> ");
                    status = Console.ReadLine();

                    Console.Write("what is the priority> ");
                    priority = Console.ReadLine();

                    Console.Write("who submitted the ticket> ");
                    submitter = Console.ReadLine();

                    Console.Write("who assigned it> ");
                    assigned = Console.ReadLine();

                    Console.Write("how many people are watching> ");
                    amountofpeoplewatching = Int32.Parse(Console.ReadLine());

                    for (int i = 0; i < amountofpeoplewatching; i++)
                    {
                        Console.Write("enter the name> ");
                        answer = Console.ReadLine();

                        watchers += answer + "|";
                    }

                    sw.WriteLine("TicketID, summary, status, priority, submitter, assigned, watching");

                    sw.WriteLine(" {0}, {1}, {2}, {3}, {4}, {5},{6}", ticketID, summary, status, priority, submitter, assigned, watchers);

                    sw.Close();
                }else{
                    Console.WriteLine("alrighty then.");
                }

                Console.Write("go again(y/n)> ");
                betaAsk = Console.ReadLine();
            } while (betaAsk == "y");


            
        }
    }
}
