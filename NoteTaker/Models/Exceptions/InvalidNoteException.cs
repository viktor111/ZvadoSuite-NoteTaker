namespace NoteTaker.Models.Exceptions
{
    public class InvalidNoteException : Exception
    {
        public InvalidNoteException()
        {

        }

        public InvalidNoteException(string msg)
            : base(msg)
        {

        }
    }
}
