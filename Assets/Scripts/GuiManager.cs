using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GuiManager : MonoBehaviour 
{
    public TextMeshProUGUI textMesh;
    public Text normalText;

    private void Start()
    {
        var componentsOnTheScene = Component.FindObjectsOfType<Rope>();

        // info.text = "Ropes: "  + componentsOnTheScene.Length.ToString();
        char symbol_1 = '\x77';
        char symbol_2 = '\x2377';
        textMesh.text = symbol_1.ToString() + " " + symbol_2.ToString();
        normalText.text = symbol_1.ToString() + " " + symbol_2.ToString();

        textMesh.text = textMesh.text.Replace(symbol_2.ToString(), "1");
        normalText.text = normalText.text.Replace(symbol_2.ToString(), "1");
    }
}