using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SoundController : MonoBehaviour {
    public GameObject buttonPlay, buttonPause, audioContoller;
    // Start is called before the first frame update
    void Start() { 
       buttonPlay.SetActive(true);
       buttonPause.SetActive(false);
    }

    // Update is called once per frame
    void Update() {
        if(Input.GetMouseButtonDown(0)) {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit)) {
                if(hit.collider.tag == "play_major" && buttonPlay.tag == "play_major") {
                    buttonPlay.SetActive(false);
                    buttonPause.SetActive(true);
                    audioContoller.GetComponent<AudioSource>().Play();
                }else if(hit.collider.tag == "play_hotel" && buttonPlay.tag == "play_hotel") {
                    buttonPlay.SetActive(false);
                    buttonPause.SetActive(true);
                    audioContoller.GetComponent<AudioSource>().Play();
                }else if(hit.collider.tag == "play_outras" && buttonPlay.tag == "play_outras") {
                    buttonPlay.SetActive(false);
                    buttonPause.SetActive(true);
                    audioContoller.GetComponent<AudioSource>().Play();
                }else if(hit.collider.tag == "play_igreja" && buttonPlay.tag == "play_igreja") {
                    buttonPlay.SetActive(false);
                    buttonPause.SetActive(true);
                    audioContoller.GetComponent<AudioSource>().Play();
                }

                 if(hit.collider.tag == "pause") {
                    buttonPlay.SetActive(true);
                    buttonPause.SetActive(false);
                    audioContoller.GetComponent<AudioSource>().Pause();
                }
            }
        }
    }
}
