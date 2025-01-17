using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    
    void Update ()
    {
        Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));

        transform.Translate(new Vector3(input.x, input.y, 0) * speed * Time.deltaTime);

        Debug.Log("Moving");
    }
}
