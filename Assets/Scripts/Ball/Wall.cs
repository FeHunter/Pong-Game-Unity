using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [field: SerializeField] public float MinAngle { get; set; }
    [field: SerializeField] public float MaxAngle { get; set; }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Ball")
        {
            float r = Random.Range(MinAngle, MaxAngle);
            other.transform.rotation = Quaternion.AngleAxis (r, Vector3.forward);
            Debug.Log(r);
        }
    }
}
