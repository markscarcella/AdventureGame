using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMagic : MonoBehaviour {

    // define the max magic power
	public int maxPower;
    // define the current magic power
	public int power;
    // define the projectile
    public GameObject projectile;
    // define the position to shoot from
    public Transform shootPosition;
    // define the spell sound
    public AudioClip audioClip;

    // define the audio source
    AudioSource audioSource;

	// Use this for initialization
	void Start () {
        // set the powerbar maximum to max power
		GameManager.Instance.UI.powerBar.maxValue = maxPower;
        // start the powerbar value with 0 power
		GameManager.Instance.UI.powerBar.value = 0;
		// assign the audio source
		if (GetComponent<AudioSource>() != null)
		{
			audioSource = GetComponent<AudioSource>();
		}
		else
		{
			audioSource = gameObject.AddComponent<AudioSource>();
		}
    }
	
	// Update is called once per frame
	void Update () {
        // if the space key is pressed and the power is high enough
        if (Input.GetKeyDown(KeyCode.Space) && power >= maxPower)
        {
            // cast spell
            CastSpell();
        }
	}

	void CastSpell()
	{
        // play audio clip if it exists
        if (audioClip != null)
        {
            audioSource.PlayOneShot(audioClip);
        }
        // instantiate the projectile at the shoot position
        GameObject spell = Instantiate(projectile, shootPosition.position, Quaternion.identity);
        // give the spell a force forwards
		spell.GetComponent<Rigidbody>().AddForce(transform.forward * 100);
        // destroy the spell after 3 seconds
		Destroy(spell, 3.0f);
	}

	public void ModifyPower(int amt)
	{
        // increase power by amt
		power += amt;
        // modify the powerbar value
		GameManager.Instance.UI.powerBar.value = power;
	}
}
