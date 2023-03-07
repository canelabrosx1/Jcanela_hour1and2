using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class riig : MonoBehaviour
{
    /*
{
public global::System.Single Speed { get => speed; set => speed = value; }
    public global::System.Single Horizontalinput { get => Horizontalinput2; set => Horizontalinput2 = value; }
    public global::System.Single Horizontalinput1 { get => Horizontalinput2; set => Horizontalinput2 = value; }
    public global::System.Single Horizontalinput2 { get => horizontalinput; set => horizontalinput = value; }
    public global::System.Single Horizontalinput3 { get => horizontalinput; set => horizontalinput = value; }
    */

    private float horizontalinput;
    private float forwardinput;
    private float speed = 5.0f;
    private float vector3;

    public GameObject myGameObject { get; private set; }

    // Start is called before the first frame update
    void Start()
    {

    }

    private float GetSpeed()
    {
        return speed;
    }

    // Update is called once per frame
    void Update(Transform Transform, Transform t, float speed)
    {
        if (Transform == null)
        {
            throw new ArgumentNullException(nameof(Transform));
        }
        else
        {
            if (Transform is null)
            {
                throw new ArgumentNullException(nameof(Transform));
            }
            //if (Horizontalinput2 == 0x1)
            //{
            horizontalinput = Input.GetAxis("Horizontal");
            forwardinput = Input.GetAxis("Vertical");

            Vector3 movementVector = (Vector3.forward * forwardinput) + (Vector3.right * horizontalinput);


            //.(Translate)(Vector3.forward * Time.deltaTime * speed * forwardinput);
            myGameObject.transform.Translate(movementVector);
                //Transform.Translate(translation: horizontalinput = speed * Time.deltaTime * Vector3.right);


        }
    }

    private void Translate(Vector3 vector3)
    {
        throw new NotImplementedException();
    }
    //move the player forward
}

