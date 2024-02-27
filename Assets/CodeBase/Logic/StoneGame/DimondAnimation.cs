using System;
using DG.Tweening;
using UnityEngine;

namespace CodeBase.Logic.StoneGame
{
    public class DimondAnimation : MonoBehaviour
    {
        [SerializeField] private float _durationWinAnimation;
        [SerializeField] private ParticleSystem _particleSystem;

        private Vector3 _startScale;

        public bool IsEndAnimation { get; private set; }

        private void Awake() =>
            _startScale = transform.localScale;

        public void PlayWinAnimation()
        {
            _particleSystem.gameObject.SetActive(true);

            DOTween.Sequence()
                .Append(transform.DOScale(_startScale * 1.1f, _durationWinAnimation / 2))
                .Append(transform.DOScale(_startScale, _durationWinAnimation / 2))
                .OnStepComplete(() => IsEndAnimation = true)
                .OnComplete(() => _particleSystem.gameObject.SetActive(false));
        }

        public void Update()
        {
            Debug.Log(IsEndAnimation);
        }
    }
}