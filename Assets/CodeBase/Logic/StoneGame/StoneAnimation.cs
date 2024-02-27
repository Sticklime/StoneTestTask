using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace CodeBase.Logic.StoneGame
{
    public class StoneAnimation : MonoBehaviour
    {
        [SerializeField] private float _durationAnimation;
        [SerializeField] private Image _imageStone;
        [SerializeField] private Transform _pointTo;

        public void PlayDestroyStone() =>
            DOTween.Sequence()
                .Append(transform.DOMove(_pointTo.position, _durationAnimation))
                .Join(_imageStone.DOFade(0, _durationAnimation))
                .OnComplete(() => gameObject.SetActive(false));
    }
}