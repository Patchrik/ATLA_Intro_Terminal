using System;
using System.Threading;

namespace ATLAprinter
{
  class Program
  {
    //   Here is our text for the Typer
    static void Typer(string text)
    {
      int characterCount = text.Length;
      for (int i = 0; i < characterCount; i++)
      {
        Console.Write(text.Substring(0, 1));
        text = text.Remove(0, 1);
        Thread.Sleep(85);
      }
    }
    static void writelines5()
    {
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
      Console.WriteLine("");
    }
    static void SleepAndClear()
    {
      Thread.Sleep(1450);
      Console.Clear();
    }
    static void WaterPrinter()
    {
      Water water = new Water();
      water.printASCIIart();
      water.ASCIItext();
    }
    static void EarthPrinter()
    {
      Earth earth = new Earth();
      earth.printASCIIart();
      earth.ASCIItext();
    }
    static void FirePrinter()
    {
      Fire fire = new Fire();
      fire.printASCIIart();
      fire.ASCIItext();
    }
    static void AirPrinter()
    {
      Air air = new Air();
      air.printASCIIart();
      air.ASCIItext();
    }
    static void Main(string[] args)
    {
      string intro = "My grandmother used to tell me stories about the old days, a time of peace when the Avatar kept balance between the Water Tribes, Earth Kingdom, Fire Nation, and Air Nomads. But that all changed when the Fire Nation attacked. Only the Avatar mastered all four elements. Only he could stop the ruthless firebenders. But when the world needed him most, he vanished. A hundred years have passed and the Fire Nation is nearing victory in the War. Two years ago, my father and the men of my tribe journeyed to the Earth Kingdom to help fight against the Fire Nation, leaving me and my brother to look after our tribe. Some people believe that the Avatar was never reborn into the Air Nomads, and that the cycle is broken. But I haven't lost hope. I still believe that somehow, the Avatar will return to save the world.";


      WaterPrinter();
      SleepAndClear();
      EarthPrinter();
      SleepAndClear();
      FirePrinter();
      SleepAndClear();
      AirPrinter();
      SleepAndClear();
      Typer(intro);
    }
  }
}
