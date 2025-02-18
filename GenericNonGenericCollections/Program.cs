using System.Collections;

namespace GenericNonGenericCollections
{
    public class Program
    {

        static void Main(string[] args)
        {
            //ArrayList myArrayList = new ArrayList();
            //myArrayList.Add(1);
            //myArrayList.Add(1);
            //myArrayList.Add("ArrayList");
            //Display(myArrayList);

            //List<object> list = new List<object>();
            //list.Add(1);
            //list.Add(1);
            //list.Add("List");
            //Display(list);

            //Hashtable myHashtable = new Hashtable();
            //myHashtable.Add(1, "One");
            //myHashtable.Add(2, 2);
            //myHashtable.Add(3, "Three");

            //// Call the Display method
            //Display(myHashtable);

            Dictionary<object, object> myDictionary = new Dictionary<object, object>();
            myDictionary.Add(1, 1);
            myDictionary.Add(2, "Two");
            myDictionary.Add(3, "Three");

            // Call the Display method
            Display(myDictionary);



        }
        static void Display(Dictionary<object, object> dictionary)
        {
            foreach (var entry in dictionary)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
        }

    }
}
