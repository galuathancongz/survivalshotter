using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform HeadGun;
    public LineRenderer lineRenderer;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0)) { StartCoroutine(Fire(1f)); };
     }
      
    IEnumerator Fire(float seconds)
    {
        lineRenderer.SetPosition(0, HeadGun.position);
        lineRenderer.SetPosition(1, HeadGun.position + HeadGun.forward);
        lineRenderer.enabled = true;
        yield return new WaitForSeconds(seconds);
        lineRenderer.enabled = false;
    }
  
}
