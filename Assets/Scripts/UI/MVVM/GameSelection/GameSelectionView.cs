using UnityEngine;
using PokeTracker.Common.Extensions;
using Cysharp.Threading.Tasks;
using Reflex.Attributes;

namespace PokeTracker.UI.MVVM.GameSelection
{
    [AddComponentMenu("UI/MVVM/Game Selection/Game Selection View")]
    public class GameSelectionView : MonoBehaviour
    {
        [SerializeField]
        private Transform contentRoot;
        [SerializeField]
        private GameVersionItemView gameVersionItemViewPrefab;

        private GameSelectionViewModel viewModel;

        [Inject]
        private void Construct(GameSelectionViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

        private void Awake()
        {
            Initialize().Forget();
        }

        private async UniTask Initialize()
        {
            await viewModel.Initialize();
            BuildList();
        }

        private void BuildList()
        {
            contentRoot.DestroyChildren();

            foreach (var gameVersion in viewModel.GameVersions)
            {
                GameVersionItemView item = Instantiate(gameVersionItemViewPrefab, contentRoot);
                item.Bind(gameVersion, () => viewModel.SelectGame(gameVersion));
            }
        }
    }
}
