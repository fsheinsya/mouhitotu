using UnityEngine;

public class ButtonInActSystem : MonoBehaviour
{
    [SerializeField] GameObject obj;
    public void OnClick()
    {
        obj.SetActive(false);
    }
}
