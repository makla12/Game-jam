using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Laser : MonoBehaviour
{
    // Camera camera;
    private int LaserTimer = 0;
    private int LaserCD = 0;
    [SerializeField] private GameObject laserObject;
    [SerializeField] private GameObject pivotArtefakt;
    [SerializeField] private AudioSource laserAudio;

    void OnAttack() {
        if(LaserCD <= 1){
            laserObject.SetActive(true);
            laserAudio.Play();
            LaserTimer = 15;
            LaserCD = 60;
        }
    }

    private void Update() {
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Mathf.Abs(pivotArtefakt.transform.position.z - Camera.main.transform.position.z);

        Vector3 worldPos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector3 toMouse = (worldPos - pivotArtefakt.transform.position).normalized;
        pivotArtefakt.transform.right = toMouse;

        
    }
    private void FixedUpdate(){
        LaserTimer--;
        LaserCD --;
        if(LaserTimer <= 1)
        {
            laserObject.SetActive(false);
        }

    }
}
