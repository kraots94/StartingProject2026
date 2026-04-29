using System.Collections.Generic;
using UnityEngine;

namespace Bowling
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Instance { get; private set; }

        [SerializeField] private int score; 
        SpawnManager spawnManager;


        public enum GameState
        {
            Loading,
            MainMenu,
            Gameplay,
            GameOver
        }

        public GameState CurrentState { get; private set; }
        private List<Birillo> birilli;

        void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            spawnManager = FindFirstObjectByType<SpawnManager>();
            birilli = new List<Birillo>();

            GameObject[] birillosObjects = GameObject.FindGameObjectsWithTag("Birillo");
            
            foreach (GameObject birilloObject in birillosObjects)
            {
                Birillo birillo = birilloObject.GetComponent<Birillo>();
                if (birillo != null)
                {
                    birilli.Add(birillo);
                }
            }

            SetGameState(GameState.MainMenu);
        }

        public void SpawnBall()
        {
            spawnManager.CreateBall();
        }

        public void SetGameState(GameState newState)
        {
            CurrentState = newState;
            switch (CurrentState)
            {
                case GameState.Loading:
                    break;
                case GameState.MainMenu:
                    UIManager.Instance.ShowMainMenu();
                    break;
                case GameState.Gameplay:
                    foreach (Birillo birillo in birilli)
                    {
                        birillo.ResetBirillo();
                    }

                    score = 0;
                    UIManager.Instance.ShowGameUI();
                    break;
                case GameState.GameOver:
                    UIManager.Instance.UpdateGameOverUI(score);
                    UIManager.Instance.ShowGameOverUI();
                    break;
            }
        }

        public void BirilloHitted()
        {
            score += 1;
        }
    }
}