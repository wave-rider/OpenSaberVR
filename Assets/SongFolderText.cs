using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
public class SongFolderText : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        string path = Path.Combine(Application.persistentDataPath + "/Playlists");
        GetComponent<Text>().text="No song files found, please make sure that the files are located in the '"+path+"' folder.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
