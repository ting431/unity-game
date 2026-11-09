using UnityEngine;

public class MascotFloat : MonoBehaviour
{
    public float amp = 15f;    // 上下浮动幅度（像素）
    public float speed = 1.2f; // 速度，越小越慢
    public float sway = 3f;    // 左右摆动角度

    Vector2 basePos;
    float t;

    void Start()
    {
        basePos = ((RectTransform)transform).anchoredPosition;
    }

    void Update()
    {
        t += Time.deltaTime * speed;
        var rt = (RectTransform)transform;
        rt.anchoredPosition = basePos + Vector2.up * (Mathf.Sin(t * 2f) * amp);
        rt.localRotation = Quaternion.Euler(0, 0, Mathf.Sin(t) * sway);
    }
}
