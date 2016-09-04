namespace CSharpKurs
{
    public class OptionalParameters
    {
        private readonly int _myNumber;

        /*
         *  Make the parameter number optional, 
         *  the default value should be 0
         */
        public OptionalParameters(int number = 0)
        {
            _myNumber = number;
        }

        /*
         * Make the lastName parameter optional, 
         * with "Olsen" as the default value
         */
        public string OptionalStringParameter(string firstName, string lastName = "Olsen")
        {
            return $"Hello {firstName} {lastName}";
        }

        /*
         * Try to make the first parameter optional.
         * The default value for the firstName parameter should be "Ole"          
         */
        public string CanFirstParameterBeOptional(string firstName = "Ole", string lastName = "Olsen")
        {
            return $"Hello {firstName} {lastName}";
        }

        /* This will not compile since the optional parameters must be defined at the end of the parameter list, 
         * after any required parameters. Let the lastName parameter be optional as well, with "Olsen" as default value
         */
    }
}
