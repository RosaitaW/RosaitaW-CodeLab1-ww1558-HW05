using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public GameObject wall;
    public GameObject wallSpecial;
    public GameObject player;
    public GameObject prize;
    public GameObject prizeSpecial;
    public float xOffset = -5;
    public float yOffset = 5;
    private const string level0 = "/Level0.txt";
    private const string level1 = "/Level1.txt";
    private const string level2 = "/Level2.txt";
    public string fileLevel0 = "Level0.txt";
    public string fileLevel1 = "Level1.txt";
    public string fileLevel2 = "Level2.txt";


    // Start is called before the first frame update
    void Start()
    {
        int randomLevel = Random.Range(0, 2);
        string fullFilePath = Application.dataPath + "/" + fileLevel0;
        print("Full file path: " + fullFilePath);
        print(File.ReadAllText(fullFilePath));
        //lines will be an array of strings, with each line in a different array
        string[] lines = File.ReadAllLines(fullFilePath);
        GameObject wallHolder = new GameObject("Wall Holder");
        for (int y = 0; y < lines.Length; y++)
        {
            string line = lines[y];//get each line
            char[] characters = line.ToCharArray();
            //go through each character on the current line
            for (int x = 0; x < characters.Length; x++)
            {
                GameObject newObject;

                switch (characters[x])
                {
                    case 'x':
                        newObject = Instantiate<GameObject>(wall);
                        newObject.transform.position = new Vector2(x + xOffset, -y + yOffset);
                        newObject.transform.SetParent(wallHolder.transform);
                        break;
                    case 'p':
                        newObject = Instantiate<GameObject>(player);
                        newObject.transform.position = new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case '*':
                        newObject = Instantiate<GameObject>(prize);
                        newObject.transform.position = new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case '^':
                        newObject = Instantiate<GameObject>(prizeSpecial);
                        newObject.transform.position = new Vector2(x + xOffset, -y + yOffset);
                        break;
                    case '%':
                        newObject = Instantiate<GameObject>(wallSpecial);
                        newObject.transform.position = new Vector2(x + xOffset, -y + yOffset);
                        break;
                    default:
                        print("Empty");
                        break;
                }


            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}

