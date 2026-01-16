using System;
using UnityEngine;
using UnityEngine.UI;
using PokeTracker.UI.MVVM.UseCases.GameSelection;
using TMPro;

namespace PokeTracker.UI.MVVM.GameSelection
{
    [AddComponentMenu("UI/MVVM/Game Selection/Game Version Item View")]
    public class GameVersionItemView : MonoBehaviour
    {
        [SerializeField]
        private TMP_Text title;
        [SerializeField]
        private Button button;

        public void Bind(GameVersionItemModel model, Action onClick)
        {
            title.SetText(model.DisplayName);
            button.onClick.AddListener(() => onClick?.Invoke());
        }
    }
}
