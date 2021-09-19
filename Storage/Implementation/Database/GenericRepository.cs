using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;

namespace Storage.Implementation.Database
{
    public class GenericRepository : IGenericRepositiry
    {
        private Broker broker = new Broker();


        public void OpenConnection()
        {
            broker.OtvoriKonekciju();
        }
        public void CloseConnection()
        {
            broker.ZatvoriKonekciju();
        }

        public object VratiSve(Instruktor instruktor)
        {
            throw new NotImplementedException();
        }

        public void BeginTransaction()
        {
            broker.ZapocniTransakciju();
        }
        public void Commit()
        {
            broker.Commit();
        }
        public void Rollback()
        {
            broker.Rollback();
        }


        public bool Exist(IEntity entity)
        {
            return broker.Postoji(entity);
        }
        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.VratiSve(entity);
        }
        public List<IEntity> GetAllWhere(IEntity e)
        {
            return broker.VratiSveGde(e);
        }
        public int GetNewId(IEntity e)
        {
            return broker.VratiNoviId(e);
        }
        public void Save(IEntity entity)
        {
            broker.Sacuvaj(entity);
        }
        public void Update(IEntity entity)
        {
            broker.Izmeni(entity);
        }
        public void Delete(IEntity e)
        {
            broker.Obrisi(e);
        }
    }
}

