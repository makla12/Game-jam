using UnityEngine;
using UnityEngine.UIElements;

public class PlatformMove : MonoBehaviour
{
    private void FixedUpdate() {
        transform.position += new Vector3(-0.12f, 0, 0);
    }
}
