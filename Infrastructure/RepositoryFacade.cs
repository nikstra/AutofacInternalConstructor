using Core;

namespace Infrastructure
{
    public class RepositoryFacade : IRepositoryFacade
    {
        private readonly IInternalRepository _internalRepository;
        public RepositoryFacade(InternalRepository repository)
        {
            _internalRepository = repository;
        }

        public string GetData()
        {
            return _internalRepository.GetData();
        }
    }
}
