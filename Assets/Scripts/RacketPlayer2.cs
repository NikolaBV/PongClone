using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer2 : MonoBehaviour
{
    public float movementSpeed;
    private void FixedUpdate()
    {
        float verticalValue = Input.GetAxisRaw("Vertical2");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalValue) * movementSpeed;
    }
}
