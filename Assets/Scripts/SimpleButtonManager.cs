using UnityEngine;
using TMPro;
using System.Collections;

public class SimpleButtonManager : MonoBehaviour
{
    public GameObject optionPanel;
    public TMP_Text resultText;

    private void Start()
    {
        resultText.gameObject.SetActive(false);
    }

    public void Ambulance()
    {
        optionPanel.SetActive(false);

        resultText.gameObject.SetActive(true);

        StartCoroutine(AmbulanceSequence());
    }

    IEnumerator AmbulanceSequence()
    {
        resultText.text =
        "Great choice! Calling an ambulance quickly can save a person's life during emergencies.\n";

        yield return new WaitForSeconds(2f);

        string arrivingMessage = "\n\n\n\nAmbulance is arriving...";

        for (int i = 0; i < arrivingMessage.Length; i++)
        {
            resultText.text += arrivingMessage[i];

            yield return new WaitForSeconds(0.07f);
        }
    }

    public void Ignore()
    {
        optionPanel.SetActive(false);

        resultText.gameObject.SetActive(true);

        StartCoroutine(IgnoreSequence());
    }
    IEnumerator IgnoreSequence()
{
    resultText.text =
    "Ignoring a person in need can be dangerous. \nHelping quickly can save lives.\n";

    yield return new WaitForSeconds(2f);

    string message = "\nFAILED";

    resultText.text += "\n";

    foreach (char letter in message)
    {
        resultText.text += letter;

        yield return new WaitForSeconds(0.05f);
    }

    while (true)
    {
        resultText.text = resultText.text.Replace("...", ".");

        yield return new WaitForSeconds(0.3f);

        resultText.text = resultText.text.Replace(".", "..");

        yield return new WaitForSeconds(0.3f);

        resultText.text = resultText.text.Replace("..", "...");

        yield return new WaitForSeconds(0.3f);
    }
}

    public void Friend()
    {
        optionPanel.SetActive(false);

        resultText.gameObject.SetActive(true);

        resultText.text =
        "Calling friends may take extra time. \nCalling an ambulance first is safer and can save a life faster.";
    }
}