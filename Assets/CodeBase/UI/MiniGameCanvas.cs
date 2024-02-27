using CodeBase.Logic.Quest;
using CodeBase.Logic.StoneGame;
using UnityEngine;

namespace CodeBase.Logic.UI
{
    public class MiniGameCanvas : MonoBehaviour
    {
        [SerializeField] private StoneGameWin _stoneGamePrefab;
        [SerializeField] private Canvas _canvas;

        public void OpenMiniGame(QuestClickReceiver questClickReceiver)
        {
           StoneGameWin stoneInstant = 
               Instantiate(_stoneGamePrefab, transform.position, Quaternion.identity, transform);
           
           stoneInstant.Construct(questClickReceiver);
        }
    }
}