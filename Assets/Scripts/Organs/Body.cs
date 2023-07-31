using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Body : MonoBehaviour
{
    public GameObject brain;
    public GameObject guts;
    public GameObject heart;
    public GameObject kidney;
    public GameObject liver;
    public GameObject lung;

    //Change me to change the touch phase used.
    TouchPhase touchPhase = TouchPhase.Ended;

    // Start is called before the first frame update
    void Start()
    {
        brain.GetComponent<MeshRenderer>().enabled = false;
        guts.GetComponent<MeshRenderer>().enabled = false;
        heart.GetComponent<MeshRenderer>().enabled = false;
        liver.GetComponent<MeshRenderer>().enabled = false;

        kidney.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        kidney.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;

        lung.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
        lung.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount == 1 && Input.GetTouch(0).phase == touchPhase)
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
            RaycastHit hit;

            Debug.DrawRay(ray.origin, ray.direction * 100, Color.yellow, 100f);

            if (Physics.Raycast(ray, out hit))
            {

                Debug.Log(hit.transform.name);
                if (hit.collider != null)
                {
                    GameObject touchedObject = hit.transform.gameObject;

                    Debug.Log("Touched " + touchedObject.transform.name);
                    HandleTouch(touchedObject);
                }
            }
        }
    }

    void HandleTouch(GameObject touchedObject)
    {
       
        
        if (touchedObject.transform.childCount == 0) {
            
            touchedObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            touchedObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            touchedObject.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = true;
        }
    }
}
