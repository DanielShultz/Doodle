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
        switch (Random.Range(0,10))
        {
            case 0:
                //Двигающаяся платформа
                SpawnerPosition.x = Random.Range(-2f, 2f);
                SpawnerPosition.y += Random.Range(0.5f, 2.5f);
                Instantiate(PlatformMovePrefab, SpawnerPosition, Quaternion.identity);
                PlatformMovePrefab.GetComponent<PlatformMove>().LeftRight = Random.Range(0, 2) == 0;
                return;
            case 1:
                //Платформа и фейк платформа
                SpawnerPosition.x = Random.Range(-2f, 2f);
                SpawnerPosition.y += Random.Range(0.5f, 1.5f);
                Instantiate(PlatformDestroyPrefab, SpawnerPosition, Quaternion.identity);
                SpawnerPosition.x = Random.Range(-2f, 2f);
                SpawnerPosition.y += Random.Range(0.5f, 1.5f);
                Instantiate(PlatformPrefab, SpawnerPosition, Quaternion.identity);
                return;
            default:
                //Обычная платформа
                SpawnerPosition.x = Random.Range(-2f, 2f);
                SpawnerPosition.y += Random.Range(1f, 3f);
                Instantiate(PlatformPrefab, SpawnerPosition, Quaternion.identity);
                return;
        }
    }
}
