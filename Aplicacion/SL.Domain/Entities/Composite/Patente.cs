using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Domain.Entities
{
    public class Patente : Componente
    {
        public override IList<Componente> Hijos
        {
            get
            {
                return new List<Componente>();
            }

        }

        //Quiero agregar un hijo
        public override void AgregarHijo(Componente c)
        {

        }
        public override void AgregarHijos(IEnumerable<Componente> c)
        {

        }

        public override void EliminarHijo(Componente c)
        {
            
        }

        public override void VaciarHijos()
        {

        }
    }
}
