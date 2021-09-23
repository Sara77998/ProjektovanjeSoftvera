using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using SystemOperations;

namespace SystemOperations.TerminSO
{
    public class PromenaTerminaSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {
            Termin t = (Termin)entity;
            
            repository.Update(entity);
            for (int i = 0; i < t.StavkeTermina.Count; i++)
            {
                t.StavkeTermina[i].TerminId = t;
                t.StavkeTermina[i].WhereCondition = " ucenik =";
                t.StavkeTermina[i].WhereValue = $"'{t.StavkeTermina[i].Ucenik.UcenikId}'";
                t.StavkeTermina[i].InsertValues = $"{t.TerminId},{t.StavkeTermina[i].RB},'{t.StavkeTermina[i].Ucenik.UcenikId}'";
                repository.Delete(t.StavkeTermina[i]);
                repository.Save(t.StavkeTermina[i]);
            }

        }
    }
}
