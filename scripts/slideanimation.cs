using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slideanimation : MonoBehaviour
{
    public Image sil�et;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
   public void Goingtoslide()
    {
        sil�et.color = new Color(sil�et.color.r, sil�et.color.g, sil�et.color.b, 0.5f);
    }
}
