using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectiveD : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text ObjectiveText;
    private EnemyHealth enemy;
    public int count = 0;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
         ObjectiveText.SetText("Goblins Killed: " + count + "/6");
        
    }
}
