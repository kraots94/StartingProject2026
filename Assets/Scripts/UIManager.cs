using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuUI;
    [SerializeField] private GameObject gameUI;
    [SerializeField] private GameObject gameOverUI;

    void Start()
    {
        ShowMainMenuUI();
    }

    public void HideAll()
    {
        mainMenuUI.SetActive(false);
        gameUI.SetActive(false);
        gameOverUI.SetActive(false);
    }

    public void ShowMainMenuUI()
    {
        HideAll();
        mainMenuUI.SetActive(true);
    }

    public void ShowGameUI()
    {
        HideAll();
        gameUI.SetActive(true);
    }

    public void ShowGameOverUI()
    {
        HideAll();
        gameOverUI.SetActive(true);
    }
}
