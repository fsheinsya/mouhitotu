using UnityEngine;

public class ButtonActSystem : MonoBehaviour
{
    [SerializeField] GameObject obj;
    public void OnClick()
    {
        obj.SetActive(true);
    }
}
