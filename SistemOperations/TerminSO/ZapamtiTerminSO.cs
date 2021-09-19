using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SistemOperations.TerminSO
{
    public class ZapamtiTerminSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Termin t = (Termin)entity;          
            repository.Save(entity);
            t.TerminId = repository.GetNewId(entity);
            for (int i = 0; i < t.StavkeTermina.Count; i++)
            {
                t.StavkeTermina[i].TerimId = t;
                repository.Save(t.StavkeTermina[i]);
            }

        }
    }
}
