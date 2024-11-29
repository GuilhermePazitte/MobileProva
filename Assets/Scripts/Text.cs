using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text : MonoBehaviour
{
    public TMP_Text username;

    // Start is called before the first frame update
    void Start()
    {
        username.text = PlayerPrefs.GetString("Username");
    }

    // Update is called once per frame
}
