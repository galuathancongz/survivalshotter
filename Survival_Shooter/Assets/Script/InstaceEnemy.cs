using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InstaceEnemy : MonoBehaviour
{
    bool isInstace = true;
    int numberenemy = 0;
    Vector3 PlaceSpawn;
    // Start is called before the first frame update
    void Start()
    {
        PlaceSpawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isInstace) StartCoroutine(InstanceEnemy(5f));
    }
    IEnumerator InstanceEnemy(float seconds)
    {
        isInstace = false;
        yield return new WaitForSeconds(seconds);
        numberenemy++;
        if (numberenemy >2 ) numberenemy = 0;
        Instantiate(gameObject.transform.GetChild(numberenemy),PlaceSpawn,Quaternion.identity);
        isInstace = true;
    }
}
