using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 作业3_2

{
    public delegate void TickHandler(object sender, TickEventArgs e);

    public class TickEventArgs
    {
        public int timeLeft { get; set; }
    }

    public class Clock
    {
        public event TickHandler OnTick;    //事件
        public void Tick(int tleft)
        {
            Console.WriteLine("Timer started ...");
            TickEventArgs args = new TickEventArgs() { timeLeft = tleft };
            OnTick(this, args);


        }
    }

    public class Form
    {
        public Clock clock1 = new Clock();
        public Form()
        {
            clock1.OnTick += new TickHandler(clk_OnTick);
            clock1.OnTick += clk_OnTick2;
        }

        void clk_OnTick(object sender, TickEventArgs args)
        {
            while (args.timeLeft > 0)
            {
                Console.WriteLine("ticker clock left:{0}", args.timeLeft);
                System.Threading.Thread.Sleep(1000);
                args.timeLeft -= 1;
            }
        }

        void clk_OnTick2(object sender, TickEventArgs args)
        {
            while (args.timeLeft == 0)
            {
                Console.WriteLine("Ring Ring Ring！！！！");
                args.timeLeft = -1;
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Form form = new Form();
            form.clock1.Tick(10);
            Console.ReadKey();
        }
    }
}
