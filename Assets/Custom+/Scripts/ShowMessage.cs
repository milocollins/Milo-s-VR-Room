using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShowMessage : MonoBehaviour
{
    private TextMeshProUGUI messageOutput;
    public string message;

    void Start()
    {
        messageOutput = GetComponent<TextMeshProUGUI>();
    }

    public void SetMessage()
    {
        messageOutput.text = message;
    }
}
