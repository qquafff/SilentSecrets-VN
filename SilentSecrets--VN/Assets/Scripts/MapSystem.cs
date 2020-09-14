using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSystem : MonoBehaviour
{
    public GameObject Map;
    public string levelName; 

    void mapOpen ()
    {
        Map.SetActive(true);
    }

    void mapClose()
    {
        Map.SetActive(false);
    }

    void SceneLoader()
    {
        SceneManager.LoadScene(levelName);
    }





}
