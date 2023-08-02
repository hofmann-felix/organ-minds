using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Body : MonoBehaviour
{
    public GameObject brain;
    public GameObject guts;
    public GameObject heart;
    public GameObject kidney;
    public GameObject liver;
    public GameObject lung;
    public GameObject cross;
    public GameObject currentOrganText;
    public GameObject organInfos;
    public GameObject showInfosButton;
    GameObject[] organs = new GameObject[7];
    int currentOrganIndex = 0;
    public int initialOrganIndex = 0;
    bool collidersAdjusted = false;

    TouchPhase touchPhase = TouchPhase.Ended;

    int currentCrossVisibleTime = 0;
    public int crossVisibleTime = 50;

    int currentSuccessVisibleTime = 0;
    public int successVisibleTime = 100;

    // Start is called before the first frame update
    void Start()
    {
        organs = new GameObject[] { liver, brain, heart, guts, lung, kidney };
        cross.SetActive(false);

        LoadOrganIndexFromStorage();
        AdjustOrganVisibility();
    }

    // Update is called once per frame
    void Update()
    {
        //success handler
        if (currentSuccessVisibleTime > 0)
        {
            currentSuccessVisibleTime--;

            if (currentSuccessVisibleTime == 0)
            {

                if (currentOrganIndex != 6)
                {
                    Debug.Log("IntermediateScene" + currentOrganIndex);
                    SceneManager.LoadScene("IntermediateScene" + currentOrganIndex);
                }
                else
                {
                    Debug.Log("Urkunde (index:" + currentOrganIndex);
                    SceneManager.LoadScene("Urkunde");
                }
            }
        }

        TouchListener();
        ShowCross();
        AdjustColliders();
    }

    void HandleOrganTouch(GameObject touchedObject)
    {

        if (touchedObject.transform.childCount == 0)
        {

            touchedObject.GetComponent<MeshRenderer>().enabled = true;
        }
        else
        {
            touchedObject.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
            touchedObject.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = true;
        }
        currentOrganIndex++;
        //if (currentOrganIndex < organs.Length - 1) currentOrganIndex++;
        collidersAdjusted = false;

        //currentSuccessVisibleTime = successVisibleTime;

        showInfosButton.SetActive(true);
        currentOrganText.SetActive(false);

        showInfosButton.transform.GetComponent<Button>().onClick.AddListener(() =>
        {
            Debug.Log("Clicked");
            GameObject organInfo = organInfos.transform.Find(touchedObject.transform.name + "Info").transform.gameObject;
            organInfo.SetActive(true);
            showInfosButton.SetActive(false);
        });
    }

    void HandleMissTouch(RaycastHit hit)
    {
        Vector3 hitPoint = hit.point;
        currentCrossVisibleTime = crossVisibleTime;
        cross.transform.position = hitPoint;
        cross.SetActive(true);
    }

    void TouchListener()
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
                    string touchedObjectName = touchedObject.transform.name;

                    Debug.Log("Touched " + touchedObjectName);

                    if (touchedObjectName == "Robot Colider")
                    {
                        HandleMissTouch(hit);
                    }
                    else
                    {
                        HandleOrganTouch(touchedObject);
                    }
                }
            }
        }
    }

    void ShowCross()
    {
        if (currentCrossVisibleTime == 0)
        {
            cross.SetActive(false);
            currentCrossVisibleTime--;
        }
        else if (currentCrossVisibleTime > 0)
        {
            currentCrossVisibleTime--;
        }
    }

    void AdjustOrganVisibility()
    {
        for (int i = 0; i < organs.Length; i++)
        {
            GameObject currentOrgan = organs[i];
            string currentOrganName = currentOrgan.transform.name;
            if (i < currentOrganIndex)
            {
                if (currentOrganName == "Kidneys" || currentOrganName == "Lung")
                {
                    currentOrgan.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = true;
                    currentOrgan.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = true;
                }
                else
                {
                    currentOrgan.GetComponent<MeshRenderer>().enabled = true;
                }
            }
            else
            {
                if (currentOrganName == "Kidneys" || currentOrganName == "Lung")
                {
                    currentOrgan.transform.GetChild(0).GetComponent<MeshRenderer>().enabled = false;
                    currentOrgan.transform.GetChild(1).GetComponent<MeshRenderer>().enabled = false;
                }
                else
                {
                    currentOrgan.GetComponent<MeshRenderer>().enabled = false;
                }
            }
        }
    }

    void LoadOrganIndexFromStorage()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        Debug.Log("initialOrganIndex" + initialOrganIndex);

        int currentOrganIndexFromLocalStorage = PlayerPrefs.GetInt("currentOrganIndex");
        Debug.Log("currentOrganIndexFromLocalStorage" + currentOrganIndexFromLocalStorage);
        if (currentOrganIndexFromLocalStorage == 0)
        {
            PlayerPrefs.SetInt("currentOrganIndex", initialOrganIndex + 2);
            currentOrganIndex = initialOrganIndex;
        }
        else
        {
            currentOrganIndex = currentOrganIndexFromLocalStorage;
            PlayerPrefs.SetInt("currentOrganIndex", currentOrganIndexFromLocalStorage + 2);
        }

        TextMeshProUGUI textmeshPro = currentOrganText.GetComponent<TextMeshProUGUI>();
        textmeshPro.SetText($"Tippe auf {GetOrganText(organs[currentOrganIndex])} deines Mitspielers");
    }

    void AdjustColliders()
    {
        if (!collidersAdjusted)
        {
            for (int i = 0; i < organs.Length; i++)
            {
                GameObject currentOrgan = organs[i];
                if (i == currentOrganIndex)
                {
                    currentOrgan.GetComponent<Collider>().enabled = true;
                }
                else
                {
                    currentOrgan.GetComponent<Collider>().enabled = false;
                }
            }
            collidersAdjusted = true;
        }
    }

    string GetOrganText(GameObject organ)
    {
        string organName = organ.transform.name;

        switch (organName)
        {
            case "Liver":
                return "die Leber";
            case "Heart":
                return "das Herz";
            case "Lung":
                return "die Lunge";
            case "Kidneys":
                return "die Nieren";
            case "Guts":
                return "den Darm";
            case "Brain":
                return "das Gehirn";
            default:
                return "[Error in Body.cs]";
        }
    }
}
