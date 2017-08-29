using System.Collections.Generic;
using System.Linq;
using ProjetoWCF.Models;

namespace ProjetoWCF
{
    
    public class ProdutoService : IProdutoService
    {       
        public List<pessoas> GetPessoa(int idHash, string hash)
        {
            Dados db = new Dados();
            var listaPessoas = db.pessoas.Where(filter => filter.idHash == idHash && filter.valorHash == hash).ToList();
            if (listaPessoas.Count != 0)
                return listaPessoas;
            else
                return null;
        }
    }
}
