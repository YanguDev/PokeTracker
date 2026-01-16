using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace PokeTracker.UI
{
    public class VirtualizedScrollView : MonoBehaviour
    {
        [SerializeField]
        private ScrollRect scroll;
        [SerializeField]
        private float rowHeight;

        private float viewportHeight;

        private void OnEnable()
        {
            scroll.onValueChanged.AddListener(OnScroll);
        }

        private void OnDisable()
        {
            scroll.onValueChanged.RemoveListener(OnScroll);
        }

        private void Start()
        {
            viewportHeight = scroll.viewport.rect.height;
        }

        public void Initialize()
        {
            
        }

        private void OnScroll(Vector2 scroll)
        {
            
        }
    }

    public class VirtualizedScrollViewData<T>
    {
        private IReadOnlyList<T> dataList;
        private event Action<T> onBind;
        private event Action<T> onUnbind;

        public VirtualizedScrollViewData(IReadOnlyList<T> dataList)
        {
            this.dataList = dataList;
        }

        public void Bind(T data) => onBind?.Invoke(data);
        public void Unbind(T data) => onUnbind?.Invoke(data);
    }
}
