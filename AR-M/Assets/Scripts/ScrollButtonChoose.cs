using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScrollButtonChoose : MonoBehaviour
{
    public GameObject Spisok;
    public GameObject LishniySpisok;

    public void Choose()
    {
            LishniySpisok.SetActive(false);
            Spisok.SetActive(true);
       
    }
}
