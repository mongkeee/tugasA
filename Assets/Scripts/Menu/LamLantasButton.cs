using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LamLantasButton : MonoBehaviour
{
    [SerializeField] private LamLantasDeskripsi txDeskripsi;
    [SerializeField] private Animator anim;
    [SerializeField] private int txValue = 0;

    void Start()
    {
        anim = this.GetComponent<Animator>();
        txDeskripsi = GameObject.Find("Canvas/menuLamLaluLintas/imgDeskripsi/txDeskripsi").GetComponent<LamLantasDeskripsi>();
    }

    public void ButtonClicked()
    {
        if (anim.GetInteger("statePilih") != 1)
        {
            anim.SetInteger("statePilih", 1);
            txDeskripsi.x = txValue;
        } 
        else
        {
            anim.SetInteger("statePilih", 0);
            txDeskripsi.x = 0;
        }
    }

    public void Unpressed()
    {
        if (txDeskripsi.x == 0)
        {
            anim.SetInteger("statePilih", 0);
        }
        else
        {
            anim.SetInteger("statePilih", 2);
        }
    }
}
