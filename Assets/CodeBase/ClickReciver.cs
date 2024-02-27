using UnityEngine;
using UnityEngine.EventSystems;

namespace CodeBase
{
    [RequireComponent(typeof(Collider))]
    public class ClickReceiver : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private float _clickDuration;
        private bool _isPointerDown;

        private void Update()
        {
            WaitingClick();
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            _isPointerDown = true;
            _clickDuration = 0f;
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (eventData.button != PointerEventData.InputButton.Left)
                return;

            _isPointerDown = false;

            if (_clickDuration < 0.3f)
                OnClick();
        }

        private void WaitingClick()
        {
            if (!_isPointerDown)
                return;

            _clickDuration += Time.deltaTime;

            if (_clickDuration >= 0.3f)
                _isPointerDown = false;
        }

        protected virtual void OnClick() { }
    }
}