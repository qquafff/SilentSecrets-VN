using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using LootBoxSystem;

namespace SaveLoadSystem
{

    public class SaveManager : Singleton<SaveManager>
    {

        [SerializeField] bool saveDataOnApplicationQuit = false;
        private void Awake()
        {
            //PlayerPrefsLoad();
            //SerializationLoad();
        }
    
        public void SerializationSave()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Create(Application.persistentDataPath + "/MySaveData.dat");
            SaveData data = new SaveData();

            

            bf.Serialize(file, data);
            file.Close();
            Debug.Log("Game data saved with Serialization!");
        }

        public void SerializationLoad()
        {
            if(File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream file = File.Open(Application.persistentDataPath + "/MySaveData.dat", FileMode.Open);
                SaveData data = (SaveData)bf.Deserialize(file);
                file.Close();

               
                Debug.Log("Game data loaded with Serialization!");
            }
            else
            {
                Debug.Log("No serialized game data was found.");
            }

        }

        public void SerializationClear()
        {
            if(File.Exists(Application.persistentDataPath + "/MySaveData.dat"))
            {
                File.Delete(Application.persistentDataPath + "/MySaveData.dat");
                Debug.Log("Save Data was cleared!");
            }
            else
            {
                Debug.Log("No Save data to clear");
            }
        }

        public void PlayerPrefsSave()
        {

        }

        public void PlayerPrefsLoad()
        {

        }

        public void PlayerPrefsClear()
        {
            PlayerPrefs.DeleteAll();
        }

        private void OnApplicationQuit()
        {
            if (saveDataOnApplicationQuit == true)
            {
                PlayerPrefsSave();
                SerializationSave();
            }
        }

    }

    [System.Serializable]
    class SaveData
    {
        public int savedOpenedBoxes;
        public List<InventoryData> savedInventory = new List<InventoryData>();

    }

    [System.Serializable]
    class InventoryData
    {
        public string itemName;
        public int amount;

        public InventoryData(ItemData _data, int _amount)
        {
            
            amount = _amount;
        }

    }
}