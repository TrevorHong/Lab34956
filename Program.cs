namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                int classlabel = 1;
                int predict = 3;
                int datapoints = 100;


                string[] attributes = new string[] {"damage", "pierce", "accuracy", "round passed"};

                string[][] attributeValues = new string[attributes.Length][];  
                attributeValues[0] = new string[] {"low", "medium", "high", ""};
                attributeValues[1] = new string[] {"low", "medium", "high", ""};
                attributeValues[2] = new string[] {"low", "medium", "high", ""};
                attributeValues[3] = new string[] { "0", "1", "", "" };

                for (int i = 0; i < predict + 1; ++i) {
                    Console.Write("attribute values" + " " + attributes[i] + ": ");
                    for (int j = 0; j < predict + 1; ++j)
                    {
                        Console.Write( attributeValues[i][j] + " ");
                    }
                    Console.WriteLine("\n");
                }
                  
                Console.WriteLine("\n");
            }
            catch(Exception error) {
                Console.WriteLine(error);

            }
        }
    }
}