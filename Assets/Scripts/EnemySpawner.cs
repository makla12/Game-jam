using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private PlayerControler playerControler;
    [SerializeField] private Transform target;
    [SerializeField] private GameObject enemyObject;

    private int enemyTimer = 120;
    
    private void FixedUpdate() {
        if(enemyTimer <= 0){
            enemyTimer = 120;
            GameObject enemy = Instantiate(enemyObject);
            enemy.transform.position = new Vector3(15, Random.Range(-2,7), 0);
            enemy.GetComponent<KillTriger>().playerControler = playerControler;
            enemy.GetComponent<EnemyMovment>().target = target;
        }
        enemyTimer--;
    }
}
