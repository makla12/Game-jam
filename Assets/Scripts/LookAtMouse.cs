using Unity.Mathematics;
using UnityEngine;

public class LookAtMouse : MonoBehaviour
{
    private void Update(){
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotarion = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = rotarion;
    }
}
