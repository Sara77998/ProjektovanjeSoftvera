using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SystemOperations.CasSO
{
    public class ObrisiCasSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {         
            repository.Delete(entity);
        }
    }
}
