using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SistemOperations.TerminSO
{
    public class VratiTerminePoKriterijumuSO : SystemOperationBase
    {
        public List<Termin> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {           
            Result = repository.GetAllWhere(entity).Cast<Termin>().ToList();
        }
    }
}
