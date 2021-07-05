using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using Random = UnityEngine.Random;

public class playClickSound : MonoBehaviour
{


	public AudioSource tapSound1;
	public AudioSource tapSound2;
	public AudioSource tapSound3;
	public AudioSource tapSound4;
	public AudioSource tapSound5;
	int randomNumber;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        randomNumber = Random.Range(1,6);
    }

    public void playSoundEffect()
 	{
	 switch(randomNumber)
	 {
	case 1:
	tapSound1.Play();
	Debug.Log(randomNumber);
	break;
	case 2:
	tapSound2.Play();
	Debug.Log(randomNumber);
	break;
	case 3:
	tapSound3.Play();
	Debug.Log(randomNumber);
	break;
	case 4:
	tapSound4.Play();
	Debug.Log(randomNumber);
	break;
	case 5:
	tapSound5.Play();
	Debug.Log(randomNumber);
	break;
	default:
	Debug.Log(randomNumber);
	break;
	 }		
	}

}
