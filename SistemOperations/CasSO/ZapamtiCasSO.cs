using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemOperations;
using Domain;

namespace SistemOperations.CasSO
{
    public class ZapamtiCasSO : SystemOperationBase
    {
        protected override void ExecuteOperation(IEntity entity)
        {

            if (repository.Exist(entity))
            {
                throw new Exception("Cas vec postoji u bazi");
            }
            else
            {
                repository.Save(entity);
            }
            
        }
    }
}
