using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUI : MonoBehaviour
{
    public Text resultText;
    public void SetText(string text){
        resultText.text = text;
    }
}
