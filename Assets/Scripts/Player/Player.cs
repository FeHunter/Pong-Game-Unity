using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    float _posY;
    [field: SerializeField] public float MinY { get; set; }
    [field: SerializeField] public float MaxY { get; set; }
    [field: SerializeField] public float Speed { get; set; }

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = new Vector2(transform.position.x, Mathf.Clamp(_posY, MinY, MaxY));

        if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
        {
            _posY += Speed * Time.deltaTime;
        }
        else if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
        {
            _posY -= Speed * Time.deltaTime;
        }
    }
}
