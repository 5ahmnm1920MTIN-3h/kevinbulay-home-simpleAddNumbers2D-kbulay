using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button btn_reset;
    public Button btn_add_Numbers;

    public void SetResult()
    {
        result.text = AddNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        btn_add_Numbers.interactable = false;
        btn_reset.interactable = true;
    }

    public void Reset()
    {
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        btn_add_Numbers.interactable = true;
        btn_reset.interactable = false;
        result.text = "Result";
    }
    private int AddNumbers()
    {
        int tempResult = int.Parse(varA.text) + int.Parse(varB.text);
        return tempResult;
    }
}