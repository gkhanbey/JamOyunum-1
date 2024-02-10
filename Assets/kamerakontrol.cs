using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamerakontrol : MonoBehaviour
{
    public float moveSpeed = 5f; // Hareket hızı
    public float minXPosition = -950f; // Minimum X pozisyonu

    void Update()
    {
        // D tuşuna basıldığında ve sağ sınırı aşmadığında sağa hareket et
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        // A tuşuna basıldığında ve sol sınırı aşmadığında sola hareket et
        else if (Input.GetKey(KeyCode.A) && transform.position.x > minXPosition)
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }
}
