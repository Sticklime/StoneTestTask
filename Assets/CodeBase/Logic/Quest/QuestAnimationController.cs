using UnityEngine;

namespace CodeBase.Logic.Quest
{
    public class QuestAnimationController : MonoBehaviour
    {
        [SerializeField] private Animator _animator;

        private static readonly int Close = Animator.StringToHash("Close");
        private static readonly int Open = Animator.StringToHash("Open");

        public void PlayClose() =>
            _animator.SetTrigger(Close);

        public void PlayOpen() =>
            _animator.SetTrigger(Open);
    }
}