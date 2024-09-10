using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class rambuLaluLintas : MonoBehaviour
{
    [SerializeField] private string artiRambu;
    private Sprite gambarRambu;

    [SerializeField] private GameObject objGambar;
    [SerializeField] private GameObject objArti;

    // Start is called before the first frame update
    void Start()
    {
        gambarRambu = this.GetComponent<Image>().sprite;
        objGambar = GameObject.Find("Canvas/menu/imgArtiRambu/imgGambarRambu");
        objArti = GameObject.Find("Canvas/menu/imgArtiRambu/txArtiRambu");
    }

    public void pasDiteken()
    {
        Image tujuanGambar = objGambar.GetComponent<Image>();
        TextMeshProUGUI tujuanArti = objArti.GetComponent<TextMeshProUGUI>();

        if (tujuanGambar.sprite == gambarRambu)
        {
            tujuanGambar.sprite = null;
            tujuanGambar.color = new Vector4(255, 255, 255, 0);
            objArti.GetComponent<textRambu>().balikAwal();
        }
        else
        {
            tujuanGambar.sprite = gambarRambu;
            tujuanGambar.color = new Vector4(255, 255, 255, 255);
            tujuanArti.text = artiRambu;
        }
    }
}
