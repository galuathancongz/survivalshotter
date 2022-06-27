using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public float speed=1f;
    [Range(0f,100f)]
    public float rotationSpeed=1f;
    public Vector3 newPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Look();
    }

    // Move 
    void Move()
    {
        var vertical = Input.GetAxis("Vertical") * Vector3.forward * speed * Time.deltaTime;
        transform.Translate(vertical);
        var horizontal= Input.GetAxis("Horizontal")*Vector3.right * speed * Time.deltaTime;
        transform.Translate(horizontal);
          }
    public Vector3 MousePoint()
    {
        newPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Mathf.Abs(Camera.main.transform.position.z - transform.position.z)));
        newPos.z = transform.rotation.z;
       return newPos;
    }
    void Look()
    {
        MousePoint();
        transform.eulerAngles = new Vector3(0, newPos.x * rotationSpeed, 0);
    }

}
