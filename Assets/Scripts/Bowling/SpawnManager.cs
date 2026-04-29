using UnityEngine;

namespace Bowling
{
    public class SpawnManager : MonoBehaviour
    {
        [SerializeField] private Ball ballPrefab;
        [SerializeField] private Transform spawnPointTransform;

        public void CreateBall()
        {
            Instantiate(ballPrefab, spawnPointTransform.position, spawnPointTransform.rotation);
        }
    }

}