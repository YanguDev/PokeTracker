using System.Collections.Generic;
using System.Linq;
using PokeTracker.Core.Repositories;
using Cysharp.Threading.Tasks;

namespace PokeTracker.UI.MVVM.UseCases.GameSelection
{
    public class GameSelectionUseCase
    {
        private readonly GameVersionRepository gameVersionRepository;

        public GameSelectionUseCase(GameVersionRepository gameVersionRepository)
        {
            this.gameVersionRepository = gameVersionRepository;
        }

        public async UniTask<IReadOnlyList<GameVersionItemModel>> Execute()
        {
            var games = await gameVersionRepository.GetAll();
            
            return games.Select(game =>
               new GameVersionItemModel()
               {
                   DisplayName = game.DisplayName
               }
            ).ToList();
        }
    }
}
