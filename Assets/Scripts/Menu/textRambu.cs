using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class textRambu : MonoBehaviour
{
    private TextMeshProUGUI tmpUI;
    private string isiTeks;
    // Start is called before the first frame update
    void Start()
    {
        tmpUI = this.GetComponent<TextMeshProUGUI>();
        isiTeks = tmpUI.text;
    }

    public void balikAwal()
    {
        tmpUI.text = isiTeks;
    }
}
