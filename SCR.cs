using UnityEngine;
using System.Collections;

public class SCR : MonoBehaviour
{
    public void ChangeScene(string scenename)
    {
        Application.LoadLevel(scenename);
    }
}