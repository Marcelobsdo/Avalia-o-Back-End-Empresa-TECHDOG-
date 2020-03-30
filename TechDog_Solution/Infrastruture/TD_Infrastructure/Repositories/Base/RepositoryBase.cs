using TD_Infrastructure.Data;

namespace TD_Infrastructure.Repositories.Base
{
    public abstract class RepositoryBase
    {
        protected readonly DataContext _dataContext;

        public RepositoryBase(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
    }
}