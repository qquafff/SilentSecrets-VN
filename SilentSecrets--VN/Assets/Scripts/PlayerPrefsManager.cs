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
    public const string ChikaPoints = "ChikaPoints";
    public static int chikaPoints = 0;

    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject dialogue4;
    public GameObject dialogue5;




    // Start is called before the first frame update
    void Start()
    {
        hisanoPoints = PlayerPrefs.GetInt("HisanoPoints");
        yoshikoPoints = PlayerPrefs.GetInt("YoshikoPoints");
        taketaPoints = PlayerPrefs.GetInt("TaketaPoints");
        chikaPoints = PlayerPrefs.GetInt("ChikaPoints");
    }

    // Update is called once per frame
    void Update()
    {
        if(hisanoPoints == 1)
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        }
        if (hisanoPoints == 2)
        {
            dialogue2.SetActive(false);
            dialogue3.SetActive(true);
        }
        if (hisanoPoints == 3)
        {
            dialogue3.SetActive(false);
            dialogue4.SetActive(true);
        }
        if (hisanoPoints == 4)
        {
            dialogue4.SetActive(false);
            dialogue5.SetActive(true);
        }
        if (yoshikoPoints == 1)
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        }
        if (yoshikoPoints == 2)
        {
            dialogue2.SetActive(false);
            dialogue3.SetActive(true);
        }
        if (yoshikoPoints == 3)
        {
            dialogue3.SetActive(false);
            dialogue4.SetActive(true);
        }
        if (yoshikoPoints == 4)
        {
            dialogue4.SetActive(false);
            dialogue5.SetActive(true);
        }
        if (taketaPoints == 1)
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        }
        if (taketaPoints == 2)
        {
            dialogue2.SetActive(false);
            dialogue3.SetActive(true);
        }
        if (taketaPoints == 3)
        {
            dialogue3.SetActive(false);
            dialogue4.SetActive(true);
        }
        if (taketaPoints == 4)
        {
            dialogue4.SetActive(false);
            dialogue5.SetActive(true);
        }
        if (chikaPoints == 1)
        {
            dialogue1.SetActive(false);
            dialogue2.SetActive(true);
        }
        if (chikaPoints == 2)
        {
            dialogue2.SetActive(false);
            dialogue3.SetActive(true);
        }
        if (chikaPoints == 3)
        {
            dialogue3.SetActive(false);
            dialogue4.SetActive(true);
        }
        if (chikaPoints == 4)
        {
            dialogue4.SetActive(false);
            dialogue5.SetActive(true);
        }
    }

    public static void UpdatePoints()
    {
        PlayerPrefs.SetInt("HisanoPoints", hisanoPoints);
        hisanoPoints = PlayerPrefs.GetInt("HisanoPoints");

        PlayerPrefs.SetInt("YoshikoPoints", yoshikoPoints);
        yoshikoPoints = PlayerPrefs.GetInt("YoshikoPoints");

        PlayerPrefs.SetInt("TaketaPoints", taketaPoints);
        taketaPoints = PlayerPrefs.GetInt("TaketaPoints");

        PlayerPrefs.SetInt("ChikaPoints", chikaPoints);
        chikaPoints = PlayerPrefs.GetInt("ChikaPoints");

        PlayerPrefs.Save();
    }

    public void DeleteData()
    {
        hisanoPoints = 0;
        PlayerPrefs.SetInt("HisanoPoints", hisanoPoints);

        yoshikoPoints = 0;
        PlayerPrefs.SetInt("YoshikoPoints", yoshikoPoints);

        taketaPoints = 0;
        PlayerPrefs.SetInt("TaketaPoints", taketaPoints);

        chikaPoints = 0;
        PlayerPrefs.SetInt("ChikaPoints", chikaPoints);
        UpdatePoints();
    }

    public void CheckPointsForDialogue()
    {
        
    }

}
