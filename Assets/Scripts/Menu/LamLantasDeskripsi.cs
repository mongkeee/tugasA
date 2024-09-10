using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LamLantasDeskripsi : MonoBehaviour
{
    [SerializeField] private LamLantasButton lamMerah;
    [SerializeField] private LamLantasButton lamKuning;
    [SerializeField] private LamLantasButton lamHijau;
    [SerializeField] private TextMeshProUGUI tmp;
    public int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        lamMerah = GameObject.Find("Canvas/menu/imgLamLaluLintas/btLamMerah").GetComponent<LamLantasButton>();
        lamKuning = GameObject.Find("Canvas/menu/imgLamLaluLintas/btLamKuning").GetComponent<LamLantasButton>();
        lamHijau = GameObject.Find("Canvas/menu/imgLamLaluLintas/btLamHijau").GetComponent<LamLantasButton>();
        tmp = this.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (x)
        {
            case 0:
                tmp.text = "";
                lamMerah.Unpressed();
                lamKuning.Unpressed();
                lamHijau.Unpressed();
                break;
            case 1:
                tmp.text = "KENDARAAN HARUS BERHENTI";
                lamKuning.Unpressed();
                lamHijau.Unpressed();
                break;
            case 2:
                tmp.text = "KENDARAAN BERSIAP / HATI-HATI";
                lamMerah.Unpressed();
                lamHijau.Unpressed();
                break;
            case 3:
                tmp.text = "KENDARAAN DIPERBOLEHKAN BERJALAN";
                lamMerah.Unpressed();
                lamKuning.Unpressed();
                break;
        }
    }
}
