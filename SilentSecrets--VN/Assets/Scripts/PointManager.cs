using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointManager : MonoBehaviour
{


    public void IncreasePointsYoshiko()
    {
        PlayerPrefsManager.yoshikoPoints += 1;
        PlayerPrefsManager.UpdatePoints();
    }
    public void IncreasePointsHisano()
    {
        PlayerPrefsManager.hisanoPoints += 1;
        PlayerPrefsManager.UpdatePoints();
    }
    public void IncreasePointsTaketa()
    {
        PlayerPrefsManager.taketaPoints += 1;
        PlayerPrefsManager.UpdatePoints();
    }

}
