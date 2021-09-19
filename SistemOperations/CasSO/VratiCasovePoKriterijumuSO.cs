using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SistemOperations.CasSO
{
    public class VratiCasovePoKriterijumuSO : SystemOperationBase
    {
        public List<Cas> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            //Musterija m = (Musterija)entity;
            Result = repository.GetAllWhere(entity).Cast<Cas>().ToList();
        }
    }
}
