using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using SystemOperations;

namespace SystemOperations.StavkaTerminaSO
{
    public class ObrisiStavkuTerminaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {        
            repository.Delete(entity);
        }
    }
}
