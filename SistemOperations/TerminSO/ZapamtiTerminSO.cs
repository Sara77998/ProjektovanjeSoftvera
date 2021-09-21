using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SystemOperations.TerminSO
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
                t.StavkeTermina[i].TerminId = t;
                t.StavkeTermina[i].RB = i + 1;
                t.StavkeTermina[i].Ucenik = t.StavkeTermina[i].Ucenik;
                t.StavkeTermina[i].InsertValues = $"{t.TerminId},{i+1},'{t.StavkeTermina[i].Ucenik.UcenikId}'";
                repository.Save(t.StavkeTermina[i]);
            }

        }
    }
}
