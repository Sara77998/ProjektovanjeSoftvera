using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SistemOperations.CasSO
{
    public class UcitajCasoveSO : SystemOperationBase
    {
        public List<Cas> Result { get; private set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(entity).Cast<Cas>().ToList();
        }
    }
}
