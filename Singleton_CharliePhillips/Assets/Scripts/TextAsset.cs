using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEditor;

public class TextAsset : FileSystem
{
    private string _text;

    protected TextAsset(string text)
    {
        _text = text;
    }

    public override void CreateFolder(string name)
    {
        //TODO
    }

    public override void DeleteFolder(string name)
    {
        //TODO
    }

    public override void DeleteFile(string fileName)
    {
      
    }

    public override void CreateTextFile(string fileName, string fileContents)
    {
        
    }

    public override System.IO.FileStream GetOpenORCreateFileStream(string Name)
    {
        return new System.IO.FileStream(System.IO.Path.Combine(Path, Name), System.IO.FileMode.OpenOrCreate);
    }
}
