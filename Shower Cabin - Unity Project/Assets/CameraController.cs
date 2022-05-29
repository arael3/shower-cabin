using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    float x;
    float y;
    float z;
    new Camera camera;
    [SerializeField] float fieldOfViewSpeed = 1f;
    [SerializeField] float startTimer = 7;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        camera = gameObject.GetComponent<Camera>();
        timer = startTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer > 0f)
        {
            x = transform.position.x - Time.deltaTime * 0.1f;
            y = transform.position.y;
            z = transform.position.z + Time.deltaTime * 0.1f;
            transform.position = new Vector3(x, y, z);
            camera.fieldOfView = camera.fieldOfView - Time.deltaTime * fieldOfViewSpeed;
        }
        else if (timer > -7f)
        {
            x = transform.position.x + Time.deltaTime * 0.1f;
            y = transform.position.y;
            z = transform.position.z - Time.deltaTime * 0.1f;
            transform.position = new Vector3(x, y, z);
            camera.fieldOfView = camera.fieldOfView + Time.deltaTime * fieldOfViewSpeed;
        }
        else
        {
            timer = 7;
        }
        
    }
}
