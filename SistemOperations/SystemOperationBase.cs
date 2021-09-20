using Domain;
using Storage.Implementation.Database;
using System;



namespace SystemOperations
{
    public abstract class SystemOperationBase
    {

        protected GenericRepository repository;
        public SystemOperationBase()
        {
            repository = new GenericRepository();
        }



        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                repository.Rollback();
                throw;
            }
            finally
            {
                repository.CloseConnection();
            }
        }



        protected abstract void ExecuteOperation(IEntity entity);

    }
}
