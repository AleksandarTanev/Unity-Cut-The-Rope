using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuiManager : MonoBehaviour 
{
    public TextMeshProUGUI info;

    private void Start()
    {
        var componentsOnTheScene = Component.FindObjectsOfType<Rope>();

        info.text = "Ropes: "  + componentsOnTheScene.Length.ToString();
    }
}