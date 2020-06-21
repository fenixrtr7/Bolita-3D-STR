using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Transform followTarget;
    [SerializeField] Vector3 camVector;
    [SerializeField] float movementSmoothness = 1.0f;
    [SerializeField] float rotationSmoothness = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        followTarget = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = followTarget.position + camVector;
    }

//     private void LateUpdate() { 
//        // Lerp() => Interpolaciòn lineal
//        transform.position = Vector3.Lerp(transform.position, followTarget.transform.position, Time.deltaTime * movementSmoothness);
//        // Slerp() => Rotaciòn esferica
//        transform.rotation = Quaternion.Slerp(transform.rotation, followTarget.transform.rotation, Time.deltaTime * rotationSmoothness);
//    }
}
