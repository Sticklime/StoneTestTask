using UnityEngine;

namespace CodeBase.Logic.StoneGame
{
    public class StoneClickReceiver : ClickReceiver
    {
        [SerializeField] private StoneAnimation _stoneAnimation;
        [SerializeField] private StoneGameWin _dimondAnimation;

        public bool IsRemoved { get; private set; }

        protected override void OnClick()
        {
            IsRemoved = true;
            _stoneAnimation.PlayDestroyStone();
            _dimondAnimation.EvaluateWinCondition();
        }
    }
}