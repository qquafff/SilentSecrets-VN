using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSystem : MonoBehaviour
{
    public GameObject Map;
     

    void mapOpen ()
    {
        Map.SetActive(true);
    }

    void mapClose()
    {
        Map.SetActive(false);
    }

    public void SceneLoader(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }





}
