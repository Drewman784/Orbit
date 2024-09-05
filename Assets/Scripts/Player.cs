using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{
    public float moveSpeed;
 
    void Update()
    {
        //movement mechanics
        float movementInput = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float movementInput2 = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.position += new Vector3(0, movementInput, 0);
        transform.position += new Vector3(movementInput2, 0, 0);
        transform.position += new Vector3(movementInput2, 0, 0);
    }
}
