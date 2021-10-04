using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{
    public LayerMask mask;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse0))
        {
            RaycastHit hit;
            Color newColor = new Color(1f, 0.7f, 0);
            Debug.DrawRay(Vector3.zero, transform.forward * 10, newColor);
            if(Physics.Raycast(Vector3.zero, transform.forward, out hit, 10, mask))
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
}
