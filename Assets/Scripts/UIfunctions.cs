using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIfunctions : MonoBehaviour
{
    public void KillMySelf()
    {
        this.gameObject.SetActive(false);
    }
}
