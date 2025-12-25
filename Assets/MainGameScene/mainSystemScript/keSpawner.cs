using UnityEngine;

public class keSpawner : MonoBehaviour
{
    [SerializeField] GameObject ke_Prefab;
    [SerializeField] RectTransform[] spawnPoints;
    [SerializeField] float spawninterval = 7.0f;
    [SerializeField] float maxKeCount = 10;

    float timer;
    int currentKeCount = 0;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawninterval && currentKeCount < maxKeCount)
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

        currentKeCount++;
    }

    public void DecreaseKeCount()
    {
        currentKeCount--;
    }
}