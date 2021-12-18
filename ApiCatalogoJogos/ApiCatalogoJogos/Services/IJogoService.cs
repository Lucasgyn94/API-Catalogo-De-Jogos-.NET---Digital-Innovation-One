using ApiCatalogoJogos.InputModel;
using ApiCatalogoJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos.Services
{
    public interface IJogoService : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}

// Uma tarefa (ou task) representa uma unidade de trabalho que deverá ser
// realizada. Esta unidade de trabalho pode rodar em uma thread separada e
// é também possível iniciar uma task de forma sincronizada a qual resulta
// em uma espera pela thread chamada. Com tasks, você tem uma camada de
// abstração mas também um bom controle sobre as threads relacionadas.