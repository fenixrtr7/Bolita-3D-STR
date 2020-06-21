using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjRotate : MonoBehaviour
{
    [SerializeField] float rotateSpeed = 10f;
    [SerializeField] int points = 5;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(rotateSpeed * Time.deltaTime, 0, rotateSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Add points
            UIManager.Instance.AddPoints(points);

            gameObject.SetActive(false);
        }
    }
}
