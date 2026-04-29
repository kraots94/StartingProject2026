using UnityEngine;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuButtons : MonoBehaviour
{
    private void PlayClick()
    {        
        ZanonAudioManager zanonAudioManager = FindFirstObjectByType<ZanonAudioManager>();
        zanonAudioManager.PlayClick();
    }

    public void Play()
    {
        PlayClick();
        
        UIManager uiManager = GetComponentInParent<UIManager>();
        uiManager.ShowGameUI();
    }

    public void CloseApp()
    {
        PlayClick();
        Application.Quit();

        #if UNITY_EDITOR
        EditorApplication.isPlaying = false;
        #endif
    }
}
