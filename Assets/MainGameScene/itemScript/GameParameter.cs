using UnityEngine;

public class GameParameter : MonoBehaviour
{
    public static GameParameter Instance { get; private set; }

    [Header("毛の生成パラメータ")]
    public float spawnInterval = 1.0f;
    public int maxKeCount = 10;

    void Awake()
    {
        if(Instance == null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void ApplyItem(ItemData item)
    {
        if (item == null) return;

        spawnInterval = Mathf.Max(1.0f, spawnInterval - item.speedBonus);

        maxKeCount += item.maxKeBonus;

        Debug.Log($"アイテム効果適用：生成間隔={spawnInterval}, 最大数={maxKeCount}");
    }
}
