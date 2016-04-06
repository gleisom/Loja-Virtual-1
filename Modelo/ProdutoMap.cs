using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ProdutoMap: ClassMapping<Produto>
    {
        public ProdutoMap()
        {
            Id( x =>x.Id, m => m.Generator(Generators.GuidComb));
            Property(x => x.Nome);
        }
    }
}
