using UnityEngine;
using System.Collections;

public class PictureLoad : MonoBehaviour {
    public string url = Application.dataPath + "/snake.jpg"; // "C:/usc/home/smandler/Desktop/GitHub/usc_cave/snake.jpg";
    private WWW ww;

    IEnumerator Start()
    {
        ww = new WWW(url);
        yield return ww;
    }

    void OnTriggerEnter(Collider other)
    {
        Renderer rend = GetComponent<Renderer>();
        rend.material.mainTexture = ww.texture;
    }

}
