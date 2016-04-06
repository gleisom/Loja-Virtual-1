using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestModelo;

namespace TesteModelo
{
    [TestClass]
   public class TesteSalvarProduto
    {
        public string Nome { get; private set; }

        [TestMethod]
        public void Salvar()
        {
            using (var session = NHibernateHelper.OpenSession())
            {
                var produto = new Produto { Nome = "Chuteira Nike T90" };
                session.Save(produto);
                session.Flush();
            }

        }
    }
}
