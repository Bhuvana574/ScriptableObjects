using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Human data", menuName = "Humandata=50f")]
public class HumanData :ScriptableObject
{
    [SerializeField]
    private string Pname;
    [SerializeField]
    private string age;
    [SerializeField]
    private Texture HImage;
    [SerializeField]
    private string Mobileno;
    [SerializeField]
    private string Addr;


    public string Name { get { return name; } }
    public string  Age { get { return age; } }
    public Texture Image { get { return HImage; } }
    public string Phoneno { get { return Mobileno; } }
    public string Location { get { return Addr; } }

}
