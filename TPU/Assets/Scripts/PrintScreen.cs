﻿using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;


public enum CaptureMethod
{
    AppCapture_Asynch,
    AppCapture_Synch,
    ReadPixels_Asynch,
    ReadPixels_Synch,
    RenderToTex_Asynch,
    RenderToTex_Synch
}
public class PrintScreen : MonoBehaviour
{

    public int scale;
	void Update ()
	{
	    if (Input.GetKeyDown(KeyCode.P))
	    {
	        Scene scene = SceneManager.GetActiveScene();
            ScreenCapture.CaptureScreenshot(scene.name +" - " + Time.time + ".png", scale);
	    }
	}

    public void SaveScreenshot(CaptureMethod method, string filePath)
    {
        Debug.LogError(filePath);
        if (method == CaptureMethod.AppCapture_Asynch)
        {
            ScreenCapture.CaptureScreenshot(filePath);
        }
        else if (method == CaptureMethod.AppCapture_Synch)
        {
            Texture2D texture = GetScreenshot(CaptureMethod.AppCapture_Synch);
            byte[] bytes = texture.EncodeToPNG();
            File.WriteAllBytes(filePath, bytes);
        }
        else if (method == CaptureMethod.ReadPixels_Asynch)
        {
            StartCoroutine(SaveScreenshot_ReadPixelsAsynch(filePath));
        }
        else if (method == CaptureMethod.ReadPixels_Synch)
        {
            Texture2D texture = GetScreenshot(CaptureMethod.ReadPixels_Synch);

            byte[] bytes = texture.EncodeToPNG();

            //Save our test image (could also upload to WWW)
            File.WriteAllBytes(filePath, bytes);

            //Tell unity to delete the texture, by default it seems to keep hold of it and memory crashes will occur after too many screenshots.
            DestroyObject(texture);
        }
        else if (method == CaptureMethod.RenderToTex_Asynch)
        {
            StartCoroutine(SaveScreenshot_RenderToTexAsynch(filePath));
        }
        else
        {
            Texture2D screenShot = GetScreenshot(CaptureMethod.RenderToTex_Synch);
            byte[] bytes = screenShot.EncodeToPNG();
            File.WriteAllBytes(filePath, bytes);
        }
    }
    private IEnumerator SaveScreenshot_ReadPixelsAsynch(string filePath)
    {
        //Wait for graphics to render
        yield return new WaitForEndOfFrame();

        //Create a texture to pass to encoding
        Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        //Put buffer into texture
        texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);

        //Split the process up--ReadPixels() and the GetPixels() call inside of the encoder are both pretty heavy
        yield return 0;

        byte[] bytes = texture.EncodeToPNG();

        //Save our test image (could also upload to WWW)
        File.WriteAllBytes(filePath, bytes);

        //Tell unity to delete the texture, by default it seems to keep hold of it and memory crashes will occur after too many screenshots.
        DestroyObject(texture);
    }

    /*void OnGUI() //For testing
    {
        if (GUI.Button(new Rect(100 * 0, 0, 100, 30), "AppCapture_Asynch"))
        {
            Debug.LogError("AppCapture_Asynch");
            SaveScreenshot(CaptureMethod.AppCapture_Asynch, Application.dataPath + "/screen1.png");
        }
        else if(GUI.Button(new Rect(100 * 1, 0, 100, 30), "AppCapture_Synch"))
            SaveScreenshot(CaptureMethod.AppCapture_Synch, Application.dataPath + "/screen2.png");
        else if(GUI.Button(new Rect(100 * 2, 0, 100, 30), "ReadPixels_Asynch"))
            SaveScreenshot(CaptureMethod.ReadPixels_Asynch, Application.dataPath + "/screen3.png");
        else if(GUI.Button(new Rect(100 * 3, 0, 100, 30), "ReadPixels_Synch"))
            SaveScreenshot(CaptureMethod.ReadPixels_Synch, Application.dataPath + "/screen4.png");
        else if(GUI.Button(new Rect(100 * 4, 0, 100, 30), "RenderToTex_Asynch"))
            SaveScreenshot(CaptureMethod.RenderToTex_Asynch, Application.dataPath + "/screen5.png");
        else if(GUI.Button(new Rect(100 * 5, 0, 100, 30), "RenderToTex_Synch"))
            SaveScreenshot(CaptureMethod.RenderToTex_Synch, Application.dataPath + "/screen6.png");
    }*/

    private IEnumerator SaveScreenshot_RenderToTexAsynch(string filePath)
    {
        //Wait for graphics to render
        yield return new WaitForEndOfFrame();

        RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 24);
        Texture2D screenShot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

        //Camera.main.targetTexture = rt;
        //Camera.main.Render();

        //Render from all!
        foreach (Camera cam in Camera.allCameras)
        {
            cam.targetTexture = rt;
            cam.Render();
            cam.targetTexture = null;
        }

        RenderTexture.active = rt;
        screenShot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
        Camera.main.targetTexture = null;
        RenderTexture.active = null; //Added to avoid errors
        Destroy(rt);

        //Split the process up
        yield return 0;

        byte[] bytes = screenShot.EncodeToPNG();
        File.WriteAllBytes(filePath, bytes);
    }

    private static int tempFileCount = 0;
    ///<summary>Must use a Synch capture type to work.</summary>
    public Texture2D GetScreenshot(CaptureMethod method)
    {
        if (method == CaptureMethod.AppCapture_Synch)
        {
            string tempFilePath = System.Environment.GetEnvironmentVariable("TEMP") + "/screenshotBuffer" + tempFileCount + ".png";
            tempFileCount++;
            ScreenCapture.CaptureScreenshot(tempFilePath);
            WWW www = new WWW("file://" + tempFilePath.Replace(Path.DirectorySeparatorChar.ToString(), "/"));

            Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
            while (!www.isDone) { }
            www.LoadImageIntoTexture((Texture2D)texture);
            File.Delete(tempFilePath); //Can delete now

            return texture;
        }
        else if (method == CaptureMethod.ReadPixels_Synch)
        {
            //Create a texture to pass to encoding
            Texture2D texture = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

            //Put buffer into texture
            texture.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0); //Unity complains about this line's call being made "while not inside drawing frame", but it works just fine.*

            return texture;
        }
        else if (method == CaptureMethod.RenderToTex_Synch)
        {
            RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 24);
            Texture2D screenShot = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);

            //Camera.main.targetTexture = rt;
            //Camera.main.Render();

            //Render from all!
            foreach (Camera cam in Camera.allCameras)
            {
                cam.targetTexture = rt;
                cam.Render();
                cam.targetTexture = null;
            }

            RenderTexture.active = rt;
            screenShot.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0);
            Camera.main.targetTexture = null;
            RenderTexture.active = null; //Added to avoid errors
            Destroy(rt);

            return screenShot;
        }
        else
            return null;
    }
}
