using Core;

namespace DataService
{
    public class Data : IDataService
    {
        private readonly IRepositoryFacade _repositoryFacade;
        public Data(IRepositoryFacade repositoryFacade)
        {
            _repositoryFacade = repositoryFacade;
        }

        public string Get()
        {
            return _repositoryFacade.GetData();
        }
    }
}
