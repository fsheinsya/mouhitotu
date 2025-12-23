using UnityEngine;

public class keSpawner : MonoBehaviour
{
    [SerializeField] GameObject ke_Prefab;
    [SerializeField] RectTransform[] spawnPoints;
    [SerializeField] float spawninterval = 3.0f;

    float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= spawninterval )
        {
            Spawn();
            timer = 0f;
        }
    }

    void Spawn()
    {
        if (spawnPoints.Length == 0) return;

        RectTransform point = spawnPoints[Random.Range(0, spawnPoints.Length)];

        GameObject ke = Instantiate(ke_Prefab, point);

        RectTransform keRect = ke.transform as RectTransform;
        keRect.anchoredPosition = Vector2.zero;
        
    }
}
