using System;
using System.Speech
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your text Which you want to convert into speech..!!!!");

            SpeechSynthesizer spk = new SpeechSynthesizer();

            spk.SetOutputToDefaultAudioDevice();



            spk.Speak(Console.ReadLine());


        }
    }
}
