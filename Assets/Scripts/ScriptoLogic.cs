using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptoLogic : MonoBehaviour
{
    [SerializeField]
    public GameObject CamMen;
    public GameObject CamLevel;

    [SerializeField]
    public GameObject _Canvas;

    public void ToLevel()
    {
        CamMen.SetActive(false);
        _Canvas.SetActive(false);
        CamLevel.SetActive(true);
    }
     void Update()
    {
    if(Input.GetKeyDown(KeyCode.Escape))
        {
            CamMen.SetActive(true);
            CamLevel.SetActive(false);
            Invoke("Canva", 2);
        }    
    }
    public void Canva()
    {
        _Canvas.SetActive(true) ;
    }
}
