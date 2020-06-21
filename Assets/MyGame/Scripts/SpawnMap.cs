using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMap : MonoBehaviour
{
    [SerializeField] Transform target;
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player"))
        {
            //Debug.Log("Tamaño de lista: " + LevelManager.Instance.prefabMaps.Length);
            Instantiate(LevelManager.Instance.prefabMaps[
                Random.Range(0, LevelManager.Instance.prefabMaps.Length)], target.position, target.rotation);
        }
    }
}
