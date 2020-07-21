using Core;

namespace Infrastructure
{
    public class RepositoryFacade : IRepositoryFacade
    {
        private readonly InternalRepository _internalRepository;
        public RepositoryFacade(InternalRepository repository)
        {
            _internalRepository = repository;
        }

        public string GetData()
        {
            return ((IInternalRepository)_internalRepository).GetData();
        }
    }
}
