using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Vidplay : MonoBehaviour
{
    [SerializeField] string videoFileName;
    public GameObject vid;
    public VideoPlayer player;
    // Start is called before the first frame update
    void Start()
    {
        playVid();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == ("Player"))
        vid.SetActive(true);
        player.Play();

        
    }
    public void playVid()
    {
        VideoPlayer videopPlayer = GetComponent<VideoPlayer>();

        if (videopPlayer)
        {
            string videoPath = System.IO.Path.Combine(Application.streamingAssetsPath, videoFileName);
            Debug.Log(videoPath);
            player.url = videoPath;
            
        }
    }
}
