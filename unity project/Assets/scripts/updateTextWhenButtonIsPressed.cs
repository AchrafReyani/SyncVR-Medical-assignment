using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateTextWhenButtonIsPressed : MonoBehaviour
{

	
    public Text result;
    public Text calculation;
    public AudioSource backgroundMusic1;
    public AudioSource backgroundMusic2;
    public AudioSource backgroundMusic3;
    public GameObject amogus;

	int n1=1;
	int n2=2;
	int n3;
	int i;

    // Start is called before the first frame update
    void Start()
    {	
	
        backgroundMusic1.mute=false;
	backgroundMusic2.mute=true;
	backgroundMusic3.mute=true;
	backgroundMusic1.Play();
	backgroundMusic2.Play();
	backgroundMusic3.Play();
	amogus.SetActive(false);
	calculation.text = n1.ToString()+" + "+n2.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updateNumber()
	{
		n3=n1+n2;
		n1=n2;
		n2=n3;
		result.text = n3.ToString();
		calculation.text = n1.ToString()+" + "+n2.ToString();
		if(n3 > 2000 && n3 < 300000)
		{
	        backgroundMusic1.mute=true;
		backgroundMusic2.mute=false;
		backgroundMusic3.mute=true;
		}
		if(n3 > 300000)
		{
	        backgroundMusic1.mute=true;
		backgroundMusic2.mute=true;
		backgroundMusic3.mute=false;
		}
		if(n3 > 10000000)
		{
		amogus.SetActive(true);
		}
	}   

    public void resetNumber()
	{
	        backgroundMusic1.mute=false;
		backgroundMusic2.mute=true;
		backgroundMusic3.mute=true;
		amogus.SetActive(false);
		n1=1;
		n2=1;
		n3=n1+n2;
		n1=n2;
		n2=n3;
		result.text = n3.ToString();
		calculation.text = n1.ToString()+" + "+n2.ToString();
	}
}
