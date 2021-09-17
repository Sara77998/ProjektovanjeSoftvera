using Domain;
using System.Collections.Generic;

namespace Storage
{
    public interface IGenericRepositiry
    {
        void OpenConnection();
        void CloseConnection();


        void BeginTransaction();
        void Commit();
        void Rollback();


        bool Exist(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        List<IEntity> GetAllWhere(IEntity e);
        int GetNewId(IEntity e);
        void Save(IEntity entity);
        void Delete(IEntity e);
        void Update(IEntity e);

    }
}
