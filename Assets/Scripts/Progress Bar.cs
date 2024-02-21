using System.Collections;
using System.Collections.Generic;
using UnityEditor.ShaderGraph.Legacy;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    public int maximum;
    public int current;
    public Image mask;
    

    // Start is called before the first frame update
    void Start()
    {
        maximum = 100;
        current = 100;
    }

    // Update is called once per frame
    void Update()
    {
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fill = (float)current/ (float)maximum;
        mask.fillAmount = fill;
    }    

}
