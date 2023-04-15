namespace TrainingTaskDigitalDesign.Exceptions;

public class NonExistentFileException : Exception
{
    public NonExistentFileException()
        : base("File with this path doesn't exists!")
    {
    }

    public NonExistentFileException(string message)
        : base(message)
    {
    }
}