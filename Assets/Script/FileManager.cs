using Crosstales.FB;

using System.Collections;
using System.Collections.Generic;


using UnityEngine;
using UnityEngine.Profiling;

public class FileManager : MonoBehaviour
{
    private AudioSource audioSource;

    public void SaveFile()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = Microphone.Start(Microphone.devices[0], true,1,100);
        //devices[0] 내장 마이크 


        //FileBrowser.Instance.CurrentOpenSingleFileData = 
        string path = FileBrowser.Instance.SaveFile(audioSource.clip.name,"wav");
        print(path);
        //FileBrowser.Instance.
        
    }
    public void PlaySound()
    {
        audioSource.Play();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
