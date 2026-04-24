using UnityEngine;

namespace Bowling
{
    public class GameOverUI : MonoBehaviour
    {
        [SerializeField] private TMPro.TextMeshProUGUI finalScoreText;

        public void Show()
        {
            gameObject.SetActive(true);
        }
        
        public void Hide()
        {
            gameObject.SetActive(false);
        }
        
        public void UpdateFinalScore(int finalScore)
        {
            finalScoreText.text = finalScore.ToString();
        }

        public void OnRestartButtonClicked()
        {
            GameManager.Instance.SetGameState(GameManager.GameState.Gameplay);
            UIManager.Instance.ShowGameUI();
        }

        public void OnMainMenuButtonClicked()
        {
            GameManager.Instance.SetGameState(GameManager.GameState.MainMenu);
            UIManager.Instance.ShowMainMenu();
        }
    }
}