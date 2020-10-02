using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{

    public const string HisanoPoints = "HisanoPoints";
    public static int hisanoPoints = 0;
    public const string YoshikoPoints = "YoshikoPoints";
    public static int yoshikoPoints = 0;
    public const string TaketaPoints = "TaketaPoints";
    public static int taketaPoints = 0;




    // Start is called before the first frame update
    void Start()
    {
        hisanoPoints = PlayerPrefs.GetInt("HisanoPoints");
        yoshikoPoints = PlayerPrefs.GetInt("YoshikoPoints");
        taketaPoints = PlayerPrefs.GetInt("TaketaPoints");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void UpdatePoints()
    {
        PlayerPrefs.SetInt("HisanoPoints", hisanoPoints);
        hisanoPoints = PlayerPrefs.GetInt("HisanoPoints");

        PlayerPrefs.SetInt("YoshikoPoints", yoshikoPoints);
        yoshikoPoints = PlayerPrefs.GetInt("YoshikoPoints");

        PlayerPrefs.SetInt("TaketaPoints", taketaPoints);
        taketaPoints = PlayerPrefs.GetInt("TaketaPoints");


        PlayerPrefs.Save();
    }

    public static void DeleteData()
    {
        hisanoPoints = 0;
        PlayerPrefs.SetInt("HisanoPoints", hisanoPoints);

        yoshikoPoints = 0;
        PlayerPrefs.SetInt("YoshikoPoints", yoshikoPoints);

        taketaPoints = 0;
        PlayerPrefs.SetInt("TaketaPoints", taketaPoints);
        UpdatePoints();
    }


}
