using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover : MonoBehaviour
{
    public float speed = 5.0f;
    public float rotationSpeed = 100.0f;

    [SerializeField]
    public GameObject CamMen;
    public GameObject CamLevel;
    public GameObject CamEnd;

    [SerializeField]
    public GameObject _Canvas;
    public GameObject _End;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = Vector3.zero;

        if (verticalInput > 0)
        {
            moveDirection = -transform.forward;
        }
        else if (verticalInput < 0)
        {
            moveDirection = transform.forward;
        }

        transform.Rotate(new Vector3(0, horizontalInput * rotationSpeed * Time.deltaTime, 0));
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")){ 
            CamMen.SetActive(false);
            CamLevel.SetActive(false);
            CamEnd.SetActive(true);
            _Canvas.SetActive(false);
            _End.SetActive(true);
        }
    }
}