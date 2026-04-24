using UnityEngine;

namespace Bowling
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private Transform spawnPosition;
        [SerializeField] private GameObject ballPrefab;

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
            Instantiate(ballPrefab, spawnPosition.position, Quaternion.identity);
        }
    }
}
