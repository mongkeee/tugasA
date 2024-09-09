using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuNavigasi : MonoBehaviour
{
    [SerializeField] private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void bukaPengaturan()
    {
        anim.Play("mainMenu_toSetting", 0);
    }

    public void kembaliPengaturan()
    {
        anim.Play("mainMenu_toSetting_Reversed", 0);
    }

    public void bukaBelajar()
    {
        anim.Play("mainMenu_toBelajar", 0);
    }

    public void kembaliBelajar()
    {
        anim.Play("mainMenu_toBelajar_Reversed", 0);
    }
}
