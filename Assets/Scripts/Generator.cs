using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Generator : MonoBehaviour
{
    public static UnityEvent GenerateEvent = new UnityEvent();

    public GameObject PlatformPrefab, PlatformMovePrefab, PlatformDestroyPrefab;
    Vector3 SpawnerPosition = new Vector3(0f, -4f);

    void Start()
    {
        GenerateEvent.AddListener(GeneratePlatform);
        //Десять первых платформ
        for (int i = 0; i < 10; i++)
        {
            GenerateEvent.Invoke();
        }
    }

    void GeneratePlatform()
    {
        void InstantiatePlatform(GameObject platformGO, float minY, float maxY)
        {
            SpawnerPosition.x = Random.Range(-2f, 2f);
            SpawnerPosition.y += Random.Range(minY, maxY);
            Instantiate(platformGO, SpawnerPosition, Quaternion.identity);
        }

        switch (Random.Range(0,10))
        {
            case 0:
                //Двигающаяся платформа
                PlatformMovePrefab.GetComponent<PlatformMove>().LeftRight = Random.Range(0, 2) == 0;
                InstantiatePlatform(PlatformMovePrefab, 0.5f, 2.5f);
                return;
            case 1:
                //Платформа и фейк платформа
                InstantiatePlatform(PlatformDestroyPrefab, 0.5f, 1.5f);
                InstantiatePlatform(PlatformPrefab, 0.5f, 1.5f);
                return;
            default:
                //Обычная платформа
                InstantiatePlatform(PlatformPrefab, 1f, 3f);
                return;
        }
    }
}
