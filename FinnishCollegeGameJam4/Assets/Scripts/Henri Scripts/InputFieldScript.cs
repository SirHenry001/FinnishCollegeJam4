using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InputFieldScript : MonoBehaviour
{

    public TextMeshProUGUI obj_text;
    public TMP_InputField display;

    private void Start()
    {
        obj_text.text = PlayerPrefs.GetString("code");
    }

    public void Create()
    {
        
        obj_text.text = display.text;
        PlayerPrefs.SetString("code", obj_text.text);
        PlayerPrefs.Save();
    }

}
