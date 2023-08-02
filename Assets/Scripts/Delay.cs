using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public void PanelView()
    {
        StartCoroutine (ShowPanelAfterDelay(3.0f));
        }

        public GameObject panel2;
        
        private IEnumerator ShowPanelAfterDelay(float delay)
        
        { 
            yield return new WaitForSeconds(delay);
            
         
                panel2.gameObject.SetActive(true);
             
          
                    }
                    
                    }
