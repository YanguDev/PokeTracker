using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using PokeTracker.Core.Repositories;
using PokeTracker.UI.Components;
using Reflex.Attributes;
using UnityEngine;

namespace PokeTracker.UI
{
    public class PokemonList : MonoBehaviour
    {
        [SerializeField]
        private PokemonEntry entryPrefab;
        [SerializeField]
        private VirtualizedScrollView scrollView;

        [Inject]
        private PokemonRepository pokemonRepository;

        private List<PokemonEntry> entries = new List<PokemonEntry>();

        private void Awake()
        {
            Debug.Log(pokemonRepository);
            GenerateEntries();
        }

        private void Start()
        {
            FetchPokemonCount()
                .Forget();
        }

        private async UniTask FetchPokemonCount()
        {
            int count = await pokemonRepository.GetCount();
            Debug.Log($"Got {count} pokemons");
        }

        private void GenerateEntries()
        {
            for (int i = 0; i < 19; i++)
            {
                var entry = Instantiate(entryPrefab, transform);
            }
        }
    }
}
