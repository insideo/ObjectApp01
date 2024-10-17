using System.Security.Cryptography.X509Certificates;
using System.Speech;
using System.Speech.Synthesis; //To output voice
//using System.Speech.Recognition; //To recognize voice commands

namespace ObjectApp01
{
    internal class Program
    {   
       

        static void Main(string[] args)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            int maxNamesCount = 10;
            Zdravic[] zdravicArray = new Zdravic[maxNamesCount];
            Surename n = new Surename();
            Surename[] surenames = n.GetSurnameArray(null);
            int aa = surenames.Length;
            if (aa > 0)
            {
                Console.WriteLine(aa);
            }
            for (int i = 0; i < maxNamesCount; i++)
            {
                zdravicArray[i] = new Zdravic();
            }
            Random rn = new Random();
            
            foreach (Zdravic z in zdravicArray)
            {
                string name1 = surenames[rn.Next(aa)].Name;
                z.Pozdrav(name1);
                synthesizer.Speak("Hello " + name1);
            }
            Console.ReadKey();
        }
    }
    public class Zdravic
    {
        public void Pozdrav(string jmeno)
        {
            Console.WriteLine("Hello {0} Object World!", jmeno);
        }
    }
}
