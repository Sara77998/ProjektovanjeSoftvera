using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace Storage
{
    public interface IGenericRepositiry
    {
        void Save(IEntity entity);
        List<IEntity> GetAll(IEntity e);
        int GetNewId(IEntity e);

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
