using System.Collections;
using System.IO;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{

    
    private IEnumerator Screenshot(){

        yield return new WaitForEndOfFrame();

        var width = 815;
        var height = 1705;
        var startX = 178;
        var startY = 400;
        Texture2D texture = new Texture2D(width, height, TextureFormat.RGB24, false);

        texture.ReadPixels(new Rect(startX, startY, width , height), 0, 0);
        texture.Apply();

        string name = "Screenshot_EpicApp" + System.DateTime.Now.ToString("yyy-MM-dd-HH-mm-ss") + ".png";

        //PC

        //byte[] bytes = texture.EncodeToPNG();
        //File.WriteAllBytes(Application.dataPath + "/../" + name, bytes);

        //Mobile
        NativeGallery.SaveImageToGallery(texture, "MyApp pictures", name);


        Destroy(texture);

    }

    public void TakeScreenShot(){

        StartCoroutine("Screenshot");

    }
}
