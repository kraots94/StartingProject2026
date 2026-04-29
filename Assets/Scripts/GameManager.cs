using UnityEngine;

public class GameManager : MonoBehaviour
{
    public enum GameState
    {
        Loading,
        MainMenu,
        Gameplay,
        GameOver
    }
    public GameState CurrentState { get; private set; }
    public int score;

    public void SetGameState(GameState newState)
    {
        UIManager uiManager = FindFirstObjectByType<UIManager>();
        CurrentState = newState;

        switch (CurrentState)
        {
            case GameState.Loading:
                break;
            case GameState.MainMenu:
                uiManager.ShowMainMenuUI();
                break;
            case GameState.Gameplay:
                uiManager.ShowGameUI();
                break;
            case GameState.GameOver:
                uiManager.ShowGameOverUI();
                break;
        }
    }
}