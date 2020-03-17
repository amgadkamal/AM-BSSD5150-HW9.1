using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonActions : MonoBehaviour
{
    [SerializeField] 
    AudioSource audioSource;

    [SerializeField] 
    Text rollText;

    public void rollDice(int V)
    { audioSource.Play(); 
        rollText.text = "  you rolled a " + V.ToString(); }
    
    public void Attack(int W)
    { audioSource.Play();
        rollText.text = "  you did " + W.ToString() + " damage"; }
    
    public void Heal(int Z)
    { audioSource.Play();
        rollText.text = "  you recovered " + Z.ToString() + " health"; }
}

