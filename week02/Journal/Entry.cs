public class Entry
{
    public string Date;
    public string Prompt;
    public string Response;
    public string Location;

    public Entry(string date, string prompt, string response, string location)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
        Location = location;
    }

    public override string ToString()
    {
        return $"Date: {Date}\nPrompt: {Prompt}\nResponse: {Response}\nLocation: {Location}\n";
    }

    public string ToDataString()
    {
        return $"{Date}~|~{Prompt}~|~{Response}~|~{Location}";
    }

    public static Entry FromDataString(string dataLine)
    {
        string[] parts = dataLine.Split(new string[] { "~|~" }, StringSplitOptions.None);
        if (parts.Length == 4)
        {
            return new Entry(parts[0], parts[1], parts[2], parts[3]);
        }
        return null;
    }

    


}
