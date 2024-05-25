using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptoLogic : MonoBehaviour
{
    [SerializeField]
    public GameObject CamMen;
    public GameObject CamLevel;

    [SerializeField]
    public GameObject _Canvas;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = 120;
    }
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
    public void Vihod()
    {
        Application.Quit(); 
    }
    public void Rest()
    {
        SceneManager.LoadScene(0);
    }
}
