using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.StavkaTerminaSO
{
    public class UcitajStavkeTerminaSO : SystemOperationBase
    {
        public List<StavkaTermina> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(entity).Cast<StavkaTermina>().ToList();
        }
    }
}
