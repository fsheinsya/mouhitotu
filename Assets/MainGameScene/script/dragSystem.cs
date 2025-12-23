using UnityEngine;

public class dragSystem : MonoBehaviour
{
    private Vector3 offset;
    private float startY;
    bool isHarvested = false;

    public ScoreSystem scoreSystem;
 
    void Start()
    {
        scoreSystem = FindAnyObjectByType<ScoreSystem>();

        if (scoreSystem == null)
        {
            Debug.LogError("ScoreSystem が Scene に存在しません", this);
        }
    }

    void OnMouseDown()
    {
        offset = gameObject.transform.position - GetMouseWorldPos();
        startY = transform.position.y;
    }

    void OnMouseDrag()
    {
        Vector3 targetPos = GetMouseWorldPos() + offset;

        //上限を決める(初期位置から1.0f高い所)
        float maxY = startY+0.5f;

        if (isHarvested) return;

        //もし現在位置が上限を超えたら、オブジェクトを削除する
        if (targetPos.y >= maxY)
        {
            //
            isHarvested =true;
            Destroy(gameObject);
            scoreSystem.AddScore(10);
            Debug.Log("スコアがあがった！", this)
            return;
        }

        float clampedY = Mathf.Clamp(targetPos.y, startY, maxY); ;

        transform.position = new Vector3(
            transform.position.x,
            clampedY, //Yのみ動かせるような仕様にしている
            transform.position.z
            );

       
    }

    private Vector3 GetMouseWorldPos()
    {
        //マウスの現在位置を取得
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = -Camera.main.transform.position.z;
        //マウスの出力を反映している
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
}
