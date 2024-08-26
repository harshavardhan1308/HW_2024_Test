using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameData : MonoBehaviour
{
    public PlayerData playerData;
    public PulpitData pulpitData;

    [System.Serializable]
    public class PlayerData
    {
        public float speed;
    }

    [System.Serializable]
    public class PulpitData
    {
        public float minPulpitDestroyTime;
        public float maxPulpitDestroyTime;
        public float pulpitSpawnTime;
    }

    void Awake()
    {
        string filePath = Application.dataPath + "/DoofusDiary.json";
        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            GameData data = JsonUtility.FromJson<GameData>(json);
            playerData = data.playerData;
            pulpitData = data.pulpitData;
        }
    }
}

