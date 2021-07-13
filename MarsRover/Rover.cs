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
            Position = position;
            Mode = "NORMAL";
            GeneratorWatts = 110;
        }
        public Rover(int position, string mode_change)
        {
            Position = position;
            Mode = "NORMAL";
            GeneratorWatts = 110;
            if (mode_change == "MODE_CHANGE")
            {
                Mode = "LOW_POWER";
                GeneratorWatts = 0;
                Position = 0;
            }
            else if (mode_change != "MODE_CHANGE" || mode_change == "NORMAL")
            {
                Mode = "Enter commands: MODE_CHANGE or NORMAL";
                GeneratorWatts = 0;
                Position = position;
            }
        }

        public void ReceiveMessage(Message message)
        {
            foreach (var command in message.Commands)
            {
                if (command.CommandType == "MODE CHANGE")
                {
                    Mode = command.NewMode;
                }
                else if (command.CommandType == "MOVE" && Mode != "LOW_POWER")
                {
                    Position = command.NewPostion;
                }
            }
        }


        public override string ToString()
        {
            return "Position: " + Position + " - Mode: " + Mode + " - GeneratorWatts: " + GeneratorWatts;
        }

    }
}
    

