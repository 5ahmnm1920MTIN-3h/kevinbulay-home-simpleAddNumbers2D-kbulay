using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField inputField1;
    public InputField inputField2;
    public Button resetButton;
    public Button addButton;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        inputField1.interactable = false;
        inputField2.interactable = false;
        addButton.interactable = false;
        resetButton.interactable = true;
    }

    public void Reset()
    {
        inputField1.text = "0";
        inputField2.text = "0";
        varA.interactable = true;
        inputField2.interactable = true;
        addButton.interactable = true;
        resetButton.interactable = false;
        result.text = "Result";
    }
    private float AddNumbers()
    {
        float tempResult = float.Parse(inputField1.text) + float.Parse(inputField2.text);
        return tempResult;
    }
}