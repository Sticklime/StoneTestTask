using CodeBase.Logic.UI;
using UnityEngine;

namespace CodeBase.Logic.Quest
{
    public class QuestClickReceiver : ClickReceiver
    {
        [SerializeField] private MiniGameCanvas _miniGame;
        [SerializeField] private QuestAnimationController _animationController;

        private bool _isCanOpen;

        protected override void OnClick()
        {
            _isCanOpen = false;
            _miniGame.OpenMiniGame(this);
            _animationController.PlayClose();
        }

        public void Open()
        {
            _isCanOpen = true;
            _animationController.PlayOpen();
        }
    }
}