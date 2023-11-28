using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringSearch : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string greeting = "Good Morning";
        Debug.Log(greeting);

        // IndexOf()
        var result = greeting.IndexOf("Good");
        result = greeting.IndexOf("o");

        var result2 = greeting.StartsWith("Good");
        result2 = greeting.StartsWith("Morning");

        result2 = greeting.EndsWith("Good");
        result2 = greeting.EndsWith("Morning");

        result2 = greeting.Contains("Evening");
        result2 = greeting.Contains("Morning");

        var result3 = greeting.Replace("Morning", "Evening");


        Debug.Log($"IndexOf: 'Good' : { greeting.IndexOf("Good") }");
        Debug.Log($"IndexOf: 'o' : { greeting.IndexOf("o") }");

        // LastIndexOf()
        Debug.Log($"LastIndexOf 'Good' : { greeting.LastIndexOf("Good") }");
        Debug.Log($"LastIndexOf 'g' : { greeting.LastIndexOf("g") }");

        // StartWith()
        Debug.Log($"StartWith 'Good' : { greeting.StartsWith("Good") }");
        Debug.Log($"StartWith 'Morning' : { greeting.StartsWith("Morning") }");

        // EndWith()
        Debug.Log($"EndWith 'Good' : { greeting.EndsWith("Good") }");
        Debug.Log($"EndWith 'Morning' : { greeting.EndsWith("Morning") }");

        // Contains()
        Debug.Log($"Contains 'Evening' : { greeting.Contains("Evening") }");
        Debug.Log($"Contains 'Morning' : { greeting.Contains("Morning") }");

        // Replace
        Debug.Log($"Replaced 'Morning' with 'Evening' : { greeting.Replace("Morning", "Evening")}");

        
    }
}
