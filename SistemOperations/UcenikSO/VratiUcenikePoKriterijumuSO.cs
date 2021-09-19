using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Domain;
using SystemOperations;

namespace SystemOperations.UcenikSO
{
    public class VratiUcenikePoKriterijumuSO : SystemOperationBase
    {
        public List<Ucenik> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
           
            Result = repository.GetAllWhere(entity).Cast<Ucenik>().ToList();
        }

    }
}
