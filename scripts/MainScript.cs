using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainScript : MonoBehaviour
{
    public Image img_kararma;
    Color color;
    [SerializeField] private GameObject kararmaObject;
    private bool kararma;
    private Animator animator;
    private void Start()
    {
        animator = GetComponent<Animator>();
        color = img_kararma.color;
    }
    public void Geçiþ() => animator.SetBool("ÝsSlide", true);

    public void Kararma() => kararma = true;
    private void Update()
    {

        if (kararma)
        {
            img_kararma.color = color;
            if (color.a < 1)
            {
                kararmaObject.SetActive(true);
                color.a += 0.0018f;
            }
            else
            {
                SceneManager.LoadScene(1);
                print("bruh");
                kararma = false;
                

            }



        }


    }
}
    
       