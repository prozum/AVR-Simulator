using System;

namespace AVR_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var Interpreter = new Atmega328Interpreter();

            Interpreter.Load(IntelHEX.Parse("Blink.hex"));
			//Interpreter.PORTB.PB5.ValueChanged += new EventHandler<AVRInterpreter.GPIOPinValueChangedEventArgs>(PB5_ValueChanged);
			Interpreter.Execute();
        }
    }
}
