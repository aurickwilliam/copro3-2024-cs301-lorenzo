using System;

namespace Samson_Brawlers
{
    public class InputNotAChoiceException : Exception 
    {
        public InputNotAChoiceException(string message = "PLEASE SELECT FROM THE GIVEN CHOICES!") : base(message) 
        {
            
        }
    }
}
