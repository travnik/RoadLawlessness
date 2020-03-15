using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    public Transform SelfTransform;
    public float Accelerate = 0.1f;
    //public float MinSpeed = 0f;
    public float AngleRotate = 15f;

    private Vector3 _force;

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        SelfTransform.position += _force;

        var moveHorizontal = Input.GetAxisRaw("Horizontal");
        var moveVertical = Input.GetAxisRaw("Vertical");
        
        if (moveVertical > 0)
        {
            _force += (SelfTransform.up * Time.deltaTime) * Accelerate;
        }
        else
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

            SelfTransform.eulerAngles = new Vector3(0, 0, AngleRotate * -moveHorizontal);

    }
}
