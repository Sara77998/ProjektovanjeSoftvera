using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations.InstruktorSO
{
    
    public class LoginSO:SystemOperationBase
    {
        public Instruktor Rezulat { get; private set; }
        public List<Instruktor> Instruktori { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Instruktori = repository.VratiSve(new Instruktor()).Cast<Instruktor>().ToList();
            
            Instruktor instruktor = (Instruktor)entity;
            if (Instruktori.Any(i => i.KorisnickoIme == instruktor.KorisnickoIme && i.Lozinka == instruktor.Lozinka))
            {
                Rezulat = Instruktori.First(i => i.KorisnickoIme == instruktor.KorisnickoIme && i.Lozinka == instruktor.Lozinka);
                
            }
            else
            {
                throw new Exception("Pogresno uneti podaci instruktora!");
            }
        }
    }
}
