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
}
