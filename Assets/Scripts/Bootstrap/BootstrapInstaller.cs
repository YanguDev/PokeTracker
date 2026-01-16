using UnityEngine;
using PokeTracker.API;
using PokeTracker.API.HTTPClients;
using PokeTracker.Core.Data;
using PokeTracker.Core.Repositories;
using PokeTracker.UI.MVVM.UseCases.GameSelection;
using PokeTracker.UI.MVVM.GameSelection;
using Reflex.Core;

namespace PokeTracker.Bootstrap
{
    public class BootstrapInstaller : MonoBehaviour, IInstaller
    {
        public void InstallBindings(ContainerBuilder containerBuilder)
        {
            // API and Data
            containerBuilder
                .AddSingleton(typeof(UnityHTTPClient), typeof(IHTTPClient))

                .AddSingleton(typeof(PokeAPIDataSource), typeof(IPokemonDataSource))
                .AddSingleton(typeof(PokemonRepository))

                .AddSingleton(typeof(PokeAPIGamesSource), typeof(IGameVersionsDataSource))
                .AddSingleton(typeof(GameVersionRepository))
            ;

            // MVVM
            containerBuilder
                .AddSingleton(typeof(GameSelectionUseCase))
                .AddSingleton(typeof(GameSelectionViewModel))
            ;
        }
    }
}
