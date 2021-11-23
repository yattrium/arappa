using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataHaul : MonoBehaviour
{
    public GameObject things;
    private static DataHaul instance;
    public static DataHaul Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<DataHaul>();
            }
            return instance;
        }
    }

}
