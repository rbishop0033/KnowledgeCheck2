
using MusicalInstruments;


Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<Drums>();
for (int i = 0; i < numberOfRecords; i++)
{
    // In this loop, populate the object's properties using Console.ReadLine()
    var myDrums = new Drums();

    Console.WriteLine("How many cymbals do I have?");
    myDrums.numberOfCymbals = Convert.ToInt32(Console.ReadLine());


    recordList.Add(myDrums);
        
    Console.WriteLine("Number of cymbals: " + myDrums.numberOfCymbals);
}

// Print out the list of records using Console.WriteLine()