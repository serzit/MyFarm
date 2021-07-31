using System.Collections.Generic;

[System.Serializable]
public class SceneSave
{
    // string is a key as an identifier 
    public Dictionary<string, int> intDictionary;
    public Dictionary<string, bool> boolDictionary; 
    public Dictionary<string, string> stringDictionary;
    public Dictionary<string, Vector3Serializable> vector3Dictionary;
    public Dictionary<string, int[]> intArrayDictionary;
    public List<SceneItem> listSceneItem;
    public Dictionary<string, GridPropertyDetails> gridPropertyDetailsDictionary;
    public List<InventoryItem>[] ListInvItemArray;
}