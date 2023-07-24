using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slideanimation : MonoBehaviour
{
    public Image silüet;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
   public void Goingtoslide()
    {
        silüet.color = new Color(silüet.color.r, silüet.color.g, silüet.color.b, 0.5f);
    }
}
