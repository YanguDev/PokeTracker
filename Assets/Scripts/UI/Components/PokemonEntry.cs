using UnityEngine;
using PokeTracker.Core.Data;
using TMPro;

namespace PokeTracker.UI.Components 
{
    public class PokemonEntry : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text idText;
        [SerializeField]
        private TMP_Text nameText;

        public void SetData(PokemonData pokemonData)
        {
            idText.text = pokemonData.ID.ToString();
            nameText.text = pokemonData.Name;
        }
    }
}
