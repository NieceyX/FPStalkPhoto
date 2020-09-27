using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Photo : MonoBehaviour
{
    public List<Camera> Cameras;

    public AudioSource click;
    public IsVisible Blood;
    public IsVisible Flashlight;
    public IsVisible Axe;
    public IsVisible Hammer;

    public int pictureCount;

    private bool _blood = false;
    private bool _light = false;
    private bool _axe = false;
    private bool _hammer = false;

    void Start()
    {
        click = GetComponent<AudioSource>();
        pictureCount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pictureCount == 4)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene("Win");
        }
        if (Input.GetKeyDown(KeyCode.Mouse0) && Cameras[0].enabled == true)
        {
            click.Play();
            //Debug.Log("click click");
            if (Blood.seen && Blood.near)
            {
                if (_blood == false)
                {
                    _blood = true;
                    pictureCount++;
                }

                //Debug.Log("blood!! Blood everywhere!! Muahahaha");
            }
            else if (Flashlight.seen && Flashlight.near)
            {
                if (_light == false)
                {
                    _light = true;
                    pictureCount++;
                }

                //Debug.Log("and at last I see the light!!");
            }
            else if (Axe.seen && Axe.near)
            {
                if (_axe == false)
                {
                    _axe = true;
                    pictureCount++;
                }

                //Debug.Log("Axe me a question");
            }
            else if (Hammer.seen && Hammer.near)
            {
                if (_hammer == false)
                {
                    _hammer = true;
                    pictureCount++;
                }

                //Debug.Log("Stop! Hammer time!");
            }

            GameObject.Find("PictureCount").GetComponent<TextMeshProUGUI>().text = pictureCount.ToString();
        }
    }
}
