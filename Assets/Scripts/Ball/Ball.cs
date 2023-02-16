using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [field: SerializeField] public float Speed { get; set; }

    void Start()
    {
        transform.rotation = Quaternion.AngleAxis (Random.Range(1f, 359f), Vector3.forward);
    }

    void Update()
    {
        transform.Translate (Speed * Time.deltaTime, 0, 0);
    }
}
