using UnityEngine;
using UnityEngine.UI;

public class PanelController : MonoBehaviour
{
    public Image parentPanel;

    public void ChangeColor()
    {
        Color randomColor = new Color(Random.value, Random.value, Random.value);
        parentPanel.color = randomColor;
    }
}