using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SystemOperations.UcenikSO
{
    public class UcitajUcenikeSO : SystemOperationBase
    {
        public List<Ucenik> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(entity).Cast<Ucenik>().ToList();
        }
    }
}
