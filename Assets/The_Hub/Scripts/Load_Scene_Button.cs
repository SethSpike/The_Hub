using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load_Scene_Button : MonoBehaviour
{
    public void LoadScene()
    {
        SceneManager.LoadScene("The_Hub_Inside_V1"); //the index of the seconf scene
    }

}
