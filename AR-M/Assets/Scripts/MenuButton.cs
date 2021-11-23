using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuButton : MonoBehaviour
{
    public GameObject PanelwithButtons;
    public GameObject ScrollPanel;
    public GameObject Buttoon;

    private bool a = false;
    public void Butt()
    {
        if (a==false)
        {
            PanelwithButtons.SetActive(true);
            Buttoon.GetComponentInChildren<Text>().text = "Закрыть все";
            a = true;
            ScrollPanel.SetActive(true);
        }

        if (a==true)
        {
            PanelwithButtons.SetActive(false);
            Buttoon.GetComponentInChildren<Text>().text = "Предметы";
            ScrollPanel.SetActive(false);
            a = false;
        }
    }
}
