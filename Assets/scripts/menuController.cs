using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    public GameObject painelMenu;
    public GameObject painelInstructons;
    

    public void toStart() {
        SceneManager.LoadScene("AR");
    }

    public void quit() {
        Application.Quit();
    }

    public void openInstructions() {
        painelMenu.SetActive(false);
        painelInstructons.SetActive(true);
    }

    public void closeInstructions() {
        painelMenu.SetActive(true);
        painelInstructons.SetActive(false);
    }

    public void back() {
         SceneManager.LoadScene("Menu");
    }
}
