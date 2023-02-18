using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngleCheck : MonoBehaviour
{
    private float _angle, _outAngle;
    [field: SerializeField] public float radio {get; set;}
    public Ball Ball;

    Vector2 _outPoint;

    void Start()
    {
        
    }

    void Update()
    {
        // Angle from Wall to Ball
        Vector3 distance = transform.position - Ball.transform.position;
        _angle = Mathf.Atan2(distance.y, distance.x) * Mathf.Rad2Deg;
        Debug.DrawLine (transform.position, Ball.transform.position, Color.red);

        // Out Angle
        Vector3 outAngle = Ball.transform.position - transform.position;
        _outAngle = -Mathf.Atan2(outAngle.y, outAngle.x) * Mathf.Rad2Deg;
        _outPoint = new Vector2 (_outAngle * (distance.x / radio), 0);
        Debug.DrawLine (_outPoint, transform.position, Color.green);
    }

    private void OnDrawGizmos() {
        // Gizmos.DrawSphere(hitPoint, .5f);
    }
}
