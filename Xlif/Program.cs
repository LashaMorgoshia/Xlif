using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Xlif is generating files ..");
        if (args.Length > 1)
            Process(args[0], args[1]);

        Console.WriteLine("xlf generation is complete");
    }

    static void Process(string path, string lang)
    {
        // Load the XML document
        XDocument doc = XDocument.Load(path);

        // Find all note elements with the specific text
        var noteElements = doc.Descendants()
                              .Where(e => (string)e.Name.LocalName == "note")
                              .ToList();

        // Replace each note element with a target element
        foreach (var noteElement in noteElements)
        {
            // Get the text of the note element
            string noteText = noteElement.Value;

            // Create a new target element with the same text
            XElement targetElement = new XElement("target", noteText);

            // Replace the note element with the target element
            noteElement.ReplaceWith(targetElement);
        }

        // Save the modified XML document
        doc.Save(path.Replace("messages.xlf", $"messages.{lang}.xlf"));
    }
}