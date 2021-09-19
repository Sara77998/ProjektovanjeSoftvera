using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using SystemOperations;

namespace SistemOperations.TerminSO
{
    public class PromenaTerminaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Termin t = (Termin)entity;
            
            repository.Update(entity);
            for (int i = 0; i < t.StavkeTermina.Count; i++)
            {
                t.StavkeTermina[i].TerimId = t;
                repository.Save(t.StavkeTermina[i]);
            }

        }
    }
}
