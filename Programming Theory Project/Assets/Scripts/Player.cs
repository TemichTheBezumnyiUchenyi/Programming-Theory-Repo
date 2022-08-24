using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] float rotationSpeed;
    private float horizontalInput;
    private float verticalInput;
    private bool boost = true;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * verticalInput * moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && boost)
        {
            moveSpeed *= 2.75f;
            boost = false;
            StartCoroutine(BoostTime());
        }
    }

    IEnumerator BoostTime()
    {
        yield return new WaitForSeconds(3);

        moveSpeed /= 2.75f;

        StartCoroutine(BoostRecharge());
    }

    IEnumerator BoostRecharge()
    {
        yield return new WaitForSeconds(5);

        boost = true;
    }
}
