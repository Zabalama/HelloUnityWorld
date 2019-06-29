using UnityEngine;
using System.Collections;
using TMPro;

public class ChangeName: MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
        TextMeshProUGUI textmeshProUGUI = GetComponent<TextMeshProUGUI>();
        textmeshProUGUI.SetText("Hello World from Amanda"); 
        }
    }
}
