using UnityEngine;

public class DestoryOnPosition : MonoBehaviour
{
    void Update() { if (transform.position.y <= -6f) Destroy(gameObject); }
}
