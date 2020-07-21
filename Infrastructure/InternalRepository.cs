namespace Infrastructure
{
    public class InternalRepository : IInternalRepository
    {
        internal InternalRepository()
        {
        }

        string IInternalRepository.GetData()
        {
            return "Explicit Hello World!";
        }
    }
}
