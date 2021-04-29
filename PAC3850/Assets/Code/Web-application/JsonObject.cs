using System;


[Serializable]
public class JsonObject
{
    public string first_name;                // REQUIRED
    public string last_name;              // REQUIRED - will be deleted
    public string patientID;             // REQUIRED: THE ID OF THE CHILD
    public string dateOfBirth;          // REQUIRED: DOB OF THE CHILD

    public string levelOneFeedback;
    public string levelTwoFeedback;
    public string levelThreeFeedback;
    public string levelFourFeedback;
    public string levelFiveFeedback;

    public string gameplayDetailsLevelOne;
    public string gameplayDetailsLevelTwo;
    public string gameplayDetailsLevelThree;
    public string gameplayDetailsLevelFour;
    public string gameplayDetailsLevelFive;

    public string childEndOfGameFeedback;
    public string parentEndOfGameFeedback;

    public bool isComingFromParent;

    public bool sitOnLap;
    public bool needParents;
}
