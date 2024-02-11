using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissionReportBehaviour : MonoBehaviour
{
    public GameObject MainText;
    public GameObject SubText;
    void Start()
    {
        StartCoroutine(TextMoveTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator TextMoveTimer()
    {
        yield return new WaitForSeconds(2);
        MainText.transform.position = new Vector2(-190, 275);
        SubText.transform.position = new Vector2(-240, 235);
        Debug.Log("MoveStart");
    }
}
