using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.InstruktorSO
{
    public class UcitajInstruktoreSO : SystemOperationBase
    {            
        public List<Instruktor> Result { get; private set; }            
        protected override void ExecuteOperation(IEntity entity)           
        {
                
            Result = repository.GetAll(entity).Cast<Instruktor>().ToList();
            
        }
        
    }
}
