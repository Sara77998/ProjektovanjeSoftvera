using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.StavkaTerminaSO
{
    public class ZapamtiStavkuTerminaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            StavkaTermina sr = (StavkaTermina)entity;
            repository.Save(sr);
        }
    }
}
