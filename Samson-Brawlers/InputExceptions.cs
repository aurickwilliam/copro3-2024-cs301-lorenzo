using System;

namespace Samson_Brawlers
{
    public class InputNotAChoiceException : Exception 
    {
        public InputNotAChoiceException(string message = "\n\t\t\t PLEASE SELECT FROM THE GIVEN CHOICES!\n") : base(message) 
        {
            
        }
    }

    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException(string message = "\n\t\t\t INVALID CHARACTER!\n") : base(message)
        {

        }
    }
    
    public class InvalidInputException : Exception
    {
        public InvalidInputException(string message = "\n\t\t\t INVALID INPUT, FOLLOW THE GUIDE!\n") : base(message)
        {

        }
    }

    public class InvalidStatPointException : Exception
    {
        public InvalidStatPointException(string message = "\n\t\t\t INVALID VALUE, EACH STAT HAS MAXIMUM OF 10 PTS!\n") : base(message)
        {

        }
    }
}
