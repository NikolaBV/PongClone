using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{
    public float movementSpeed;
    private void FixedUpdate()
    {
        float verticalValue = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalValue) * movementSpeed;
    }
}
