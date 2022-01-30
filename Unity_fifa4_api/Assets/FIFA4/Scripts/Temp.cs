﻿using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.Networking;
using FIFA4;

public class Temp : MonoBehaviour
{
    public Image image;

    public Request request;

    private IEnumerator Start()
    {
        request = new Request();

        yield return null;

        //yield return GetImage((sprite) => image.sprite = sprite, "C:/Users/Hwang/Downloads/p101000001.png");

        yield return request.GetMatchRecords((response) =>
        {
            if (!response.isError)
            {
                Debug.Log(response.data);
            }
        }, null, "128db12de51acf8b954ea795", 50);
    }

    public IEnumerator GetImage(UnityAction<Sprite> callback, string resourcesPath)
    {
        using (UnityWebRequest www = UnityWebRequestTexture.GetTexture(new System.Uri(resourcesPath).AbsoluteUri))
        {
            yield return www.SendWebRequest();

            Debug.Log(www.GetResponseHeader("Content-Length"));

            Texture2D texture = DownloadHandlerTexture.GetContent(www);
            callback(Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f)));
        }
    }
}
