using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.ARFoundation;

[Serializable]
public class Mask
{
    public GameObject prefabMask;
    public Sprite imageMask;
    public AudioClip sound;
}

public class SelectingMask : MonoBehaviour
{

    //qwe
    [SerializeField]
    private List<Mask> masks = new List<Mask>();

    [SerializeField]
    private ARFaceManager faceManager;

    [SerializeField]
    private Image image;

    [SerializeField]
    private AudioSource audioSource;

    private int indexMask = 0;

    [SerializeField]
    private GameObject rightAroww;
    [SerializeField]
    private GameObject lehtAroww;

    private void Start()
    {
        if (indexMask == 0)
            lehtAroww.SetActive(false);

        else
            lehtAroww.SetActive(true);

        if (indexMask == masks.Count - 1)
            rightAroww.SetActive(false);

        else
            rightAroww.SetActive(true);

        audioSource.PlayOneShot(masks[indexMask].sound);
    }

    private void Update()
    {
        faceManager.facePrefab = masks[indexMask].prefabMask;
        image.sprite = masks[indexMask].imageMask;
    }

    public void IndexChange(int index)
    {
        indexMask += index;

        if (indexMask == 0)
            lehtAroww.SetActive(false);

        else
            lehtAroww.SetActive(true);

        if (indexMask == masks.Count - 1)
            rightAroww.SetActive(false);

        else
            rightAroww.SetActive(true);

        audioSource.Stop();

        audioSource.PlayOneShot(masks[indexMask].sound);
    }
}
