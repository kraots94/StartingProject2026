using UnityEngine;

namespace Bowling
{
    public class GameUI : MonoBehaviour
    {
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }

        public void SpawnBall()
        {
            GameManager.Instance.SpawnBall();
        }
    }
}
