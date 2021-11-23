using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private Button btn;
    public GameObject things;
    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(SelectObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SelectObject()
    {
        DataHaul.Instance.things = things;
    }

}
