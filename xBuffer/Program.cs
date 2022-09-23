



using System;

class Example
{
   public static void Main()
   {
      ConsoleKeyInfo cki;
      // Prevent example from ending if CTL+C is pressed.
      Console.TreatControlCAsInput = true;

      Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
      Console.WriteLine("Press the Escape (Esc) key to quit: \n");
      int count = 0;
      do
      {
         cki = Console.ReadKey();
         
        //  Console.Write(" --- You pressed ");
         if((cki.Modifiers & ConsoleModifiers.Alt) != 0); //Console.Write("ALT+");
         if((cki.Modifiers & ConsoleModifiers.Shift) != 0); //Console.Write("SHIFT+");
         if((cki.Modifiers & ConsoleModifiers.Control) != 0); //Console.Write("CTL+");
        Console.Write(cki.Key.ToString());
        count++;
       } while (cki.Key != ConsoleKey.Escape || count < 5);
    }
}
// This example displays output similar to the following:
//       Press any combination of CTL, ALT, and SHIFT, and a console key.
//       Press the Escape (Esc) key to quit:
//
//       a --- You pressed A
//       k --- You pressed ALT+K
//       ► --- You pressed CTL+P
//         --- You pressed RightArrow
//       R --- You pressed SHIFT+R
//                --- You pressed CTL+I
//       j --- You pressed ALT+J
//       O --- You pressed SHIFT+O
//       § --- You pressed CTL+U


// string key = Console.ReadKey();
// key == ConsoleKey.D0;
// key == ConsoleKey.NumPad0;

// Console.Write("Press <Enter> to exit... ");
//       while (Console.ReadKey().Key != ConsoleKey.Enter) {}

// ConsoleKeyInfo ReadKey ();