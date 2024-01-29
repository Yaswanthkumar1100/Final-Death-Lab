using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TwoHandDrag : XRGrabInteractable
{
    // Start is called before the first frame update
    public List<XRSimpleInteractable> secondHandGrabPoints = new List<XRSimpleInteractable>();
    void Start()
    {
        foreach (var item in secondHandGrabPoints)
        {
            item.onSelectEntered.AddListener(OnSecondHandGrab);
            item.onSelectExited.AddListener(OnSecondHandRelease);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnSecondHandGrab(XRBaseInteractor interactor)
    {
        UnityEngine.Debug.Log("Second Hand Grab");
        
      
    }
    public void OnSecondHandRelease(XRBaseInteractor interactor)
    {
        UnityEngine.Debug.Log("Secon Hand Release");

    }


    public override bool IsSelectableBy(XRBaseInteractor interactor)
    {
        bool isalreadygrabbed = selectingInteractor && !interactor.Equals(selectingInteractor);
        return base.IsSelectableBy(interactor) && !isalreadygrabbed;
    }
    
}
