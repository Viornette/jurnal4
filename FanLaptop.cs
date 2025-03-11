using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_103022300145
{
    internal class FanLaptop
    {
        enum State { Quiet, Balanced, Performance, Turbo, Selesai };
        public static void fanLaptop()
        {
            State state = State.Quiet;
            Console.WriteLine("Inisial state : Quiet Mode");
            while (state != State.Selesai)
            {
                Console.Write("Masukkan Aksi : ");
                string command = Console.ReadLine();

                switch (state)
                {
                    case State.Quiet:
                        if (command == "Mode Up")
                        {
                            Console.WriteLine("Fan Quiet berubah menjadi Balanced");
                            state = State.Balanced;
                        }
                        else if (command == "Turbo Shortcut")
                        {
                            Console.WriteLine("Fan Quiet berubah menjadi Turbo");
                            state = State.Turbo;
                        }
                        else
                        {
                            Console.WriteLine("Simulasi Selesai");
                            state = State.Selesai;
                        }
                        break;
                    case State.Balanced:
                        if (command == "Mode Up")
                        {
                            Console.WriteLine("Fan Balanced berubah menjadi Performance");
                            state = State.Performance;
                        }
                        else if (command == "Mode Down")
                        {
                            Console.WriteLine("Fan Balanced berubah menjadi Quiet");
                            state = State.Quiet;
                        }
                        else
                        {
                            Console.WriteLine("Simulasi Selesai");
                            state = State.Selesai;
                        }
                        break;
                    case State.Performance:
                        if (command == "Mode Up")
                        {
                            Console.WriteLine("Fan Performance berubah menjadi Turbo");
                            state = State.Turbo;
                        }
                        else if (command == "Mode Down")
                        {
                            Console.WriteLine("Fan Performance berubah menjadi Balanced");
                            state = State.Balanced;
                        }
                        else
                        {
                            Console.WriteLine("Simulasi Selesai");
                            state = State.Selesai;
                        }
                        break;
                    case State.Turbo:
                        if (command == "Mode Down")
                        {
                            Console.WriteLine("Fan Turbo berubah menjadi Performance");
                            state = State.Performance;
                        }
                        else if (command == "Turbo Shortcut")
                        {
                            Console.WriteLine("Fan Turbo berubah menjadi Quiet");
                            state = State.Quiet;
                        }
                        else
                        {
                            Console.WriteLine("Simulasi Selesai");
                            state = State.Selesai;
                        }
                        break;
                }
            }
        }
    }
}
