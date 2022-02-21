using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExternalLinks : MonoBehaviour
{
    public void OpenFacebook () {
        Application.OpenURL("https://www.facebook.com/"); 
    }

    public void OpenInstagram () {
        Application.OpenURL("https://www.instagram.com/"); 
    }

    public void OpenYoutube () {
        Application.OpenURL("https://www.youtube.com/"); 
    }

    public void OpenTwitter () {
        Application.OpenURL("https://twitter.com/"); 
    }

    public void OpenWhatsapp () {
        Application.OpenURL("https://www.whatsapp.com/"); 
    }

}
