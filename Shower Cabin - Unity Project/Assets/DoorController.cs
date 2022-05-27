using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] float speed = 100f;
    Vector3 rotation;
    bool triggerClose = false;
    bool triggerOpen = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || triggerClose)
        {
            triggerClose = true;
            triggerOpen = false;

            if (gameObject.name == "door1")
            {
                if (135f < transform.rotation.eulerAngles.y && transform.rotation.eulerAngles.y < 235f)
                {
                    rotation = new Vector3(0f, 0f, -1f);

                    transform.Rotate(rotation * Time.deltaTime * speed);
                }
                else
                {
                    triggerClose = false;
                }
            }
            else if (gameObject.name == "door2")
            {
                if (125 < transform.rotation.eulerAngles.y && transform.rotation.eulerAngles.y < 225f)
                {
                    rotation = new Vector3(0f, 0f, 1f);

                    transform.Rotate(rotation * Time.deltaTime * speed);
                }
                else
                {
                    triggerClose = false;
                }
            }

        }
        else if (Input.GetKey(KeyCode.UpArrow) || triggerOpen)
        {
            triggerOpen = true;
            triggerClose = false;

            if (gameObject.name == "door1")
            {
                if (80f < transform.rotation.eulerAngles.y && transform.rotation.eulerAngles.y < 180f)
                {
                    rotation = new Vector3(0f, 0f, 1f);

                    transform.Rotate(rotation * Time.deltaTime * speed);
                }
                else
                {
                    triggerOpen = false;
                }
            }
            else if (gameObject.name == "door2")
            {
                if (180f < transform.rotation.eulerAngles.y && transform.rotation.eulerAngles.y < 280f)
                {
                    rotation = new Vector3(0f, 0f, -1f);

                    transform.Rotate(rotation * Time.deltaTime * speed);
                }
                else
                {
                    triggerOpen = false;
                }
            }
        }
        else rotation = Vector3.zero;
    }
}
