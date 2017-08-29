using System.Collections.Generic;
using System.ServiceModel;
using ProjetoWCF.Models;

namespace ProjetoWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProdutoService" in both code and config file together.
    [ServiceContract(Namespace = "http://localhost:55363/ProdutoService")]
    public interface IProdutoService
    {
        [OperationContract(Name = "GetPessoa")]
        List<pessoas> GetPessoa(int idHash, string hash);
    }
    
}
