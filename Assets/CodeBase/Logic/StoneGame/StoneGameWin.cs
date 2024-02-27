using System.Collections;
using System.Collections.Generic;
using System.Linq;
using CodeBase.Logic.Quest;
using UnityEngine;

namespace CodeBase.Logic.StoneGame
{
    public class StoneGameWin : MonoBehaviour
    {
        [SerializeField] private List<StoneClickReceiver> _stones;
        [SerializeField] private DimondAnimation _dimond;

        private QuestClickReceiver _questController;
        private Coroutine _winCoroutine;

        public void Construct(QuestClickReceiver questController)
        {
            _questController = questController;
        }

        private void OnDisable()
        {
            if (_winCoroutine != null)
                StopCoroutine(_winCoroutine);
        }

        public void EvaluateWinCondition()
        {
            if (_stones.All(x => x.IsRemoved))
                _winCoroutine = StartCoroutine(ShowWin());
        }

        private IEnumerator ShowWin()
        {
            _dimond.PlayWinAnimation();

            yield return new WaitUntil(() => _dimond.IsEndAnimation);

            _questController.Open();
            gameObject.SetActive(false);
        }
    }
}