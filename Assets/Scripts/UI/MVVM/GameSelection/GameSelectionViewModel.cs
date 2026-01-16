using System.Collections.Generic;
using System.Linq;
using PokeTracker.Core.Data;
using PokeTracker.UI.MVVM.UseCases.GameSelection;
using Cysharp.Threading.Tasks;

namespace PokeTracker.UI.MVVM.GameSelection
{
    public class GameSelectionViewModel
    {
        private readonly GameSelectionUseCase getGames;

        public IReadOnlyList<GameVersionItemModel> GameVersions { get; private set; }
        public GameVersionItemModel SelectedGame { get; private set; }

        public GameSelectionViewModel(GameSelectionUseCase getGames)
        {
            this.getGames = getGames;
        }

        public async UniTask Initialize()
        {
            GameVersions = await getGames.Execute();
            SelectedGame = GameVersions.FirstOrDefault();
        }

        public void SelectGame(GameVersionItemModel gameVersion)
        {
            SelectedGame = gameVersion;
        }

        // public async UniTask<PokedexData> GetPokedexForCurrentGame()
        // {
        //     if (SelectedGame == null) return null;

        //     // Get version group for selected version
        //     // Get pokedex from version group
        //     // ?
        // }
    }
}
