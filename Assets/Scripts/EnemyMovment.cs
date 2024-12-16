using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public Transform target;
    [SerializeField] float speed = 5;
    private Vector3 moveVector;

    private void FixedUpdate() {
        moveVector = new Vector2(1, 1 * ( (transform.position.y - target.position.y - 1f) / (transform.position.x - target.position.x) ));
        transform.position = new Vector3(transform.position.x - moveVector.x * speed, transform.position.y - moveVector.y * speed, 0);
    }
}
