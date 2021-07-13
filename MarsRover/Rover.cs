using System;
namespace MarsRover
{
    public class Rover
    {
        public string Mode { get; set; }
        public int Position { get; set; }
        public int GeneratorWatts { get; set; }

        public Rover(int position)
        {
            this.Position = position;
            this.Mode = "Normal";
            this.GeneratorWatts = 110;
        }
        public Rover(int position, string mode_change)
        {
            Position = position;
            Mode = "Normal";
            GeneratorWatts = 110;
            if (mode_change == "MODE_CHANGE")
            {
                Mode = "Low Power";
                GeneratorWatts = 0;
                Position = 0;
            }
            else if (mode_change != "MODE_CHANGE" || mode_change == "Normal")
            {
                Mode = "Enter commands: MODE_CHANGE or Normal";
                GeneratorWatts = 0;
                Position = position;
            }
        }

        public void ReceiveMessage(Message message)
        {
            Command[] commands = { new Command("MOVE", 5000) };
            Message newMessage = new Message("Test message with one command", commands);
            Rover newRover = new Rover(98382);
            Console.WriteLine(newRover.ToString());
            newRover.ReceiveMessage(newMessage);
            Console.WriteLine(newRover.ToString());
        }


        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;
        }

    }
}
    

