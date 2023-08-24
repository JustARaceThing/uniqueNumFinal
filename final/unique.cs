/******************************************************************* 
 * Name: Jacob Race
 * Date: 8/23/2022
 * Assignment CIS214 Final
 *  
 *  
 * Unique class. 
 * class for retrieving the unique values from the user 
 */

 public class Unique {

        private static List<int> NumList = new List<int>();
        public int SmallestNum { set; get; }
        public int LargestNum{ set; get;}
        public int Sum {set; get;}
        public double Avg { set; get;}
        public double Divide { set; get;}

        public Unique(int smallestNum, int largestNum, int sum, double avg, double divide) {
            SmallestNum = smallestNum;
            LargestNum = largestNum;
            Sum = sum;
            Avg = avg;
            Divide = divide;
        }

        


    
    public void getNumbers() {
        do {
            try {
                Console.WriteLine("Please Enter a unique integer value: ");
                string? val = Console.ReadLine();
                int userNum = Convert.ToInt32(val);
                if (userNum < 1 || userNum > 100) {
                    throw new Exception();
                }
                else {
                    if (NumList.Contains(userNum)) {
                        Console.WriteLine("Number already exists!");
                    }
                    else {
                        NumList.Add(userNum);
                        if (userNum < SmallestNum) {
                             SmallestNum = userNum;
                        }
                        if (userNum > LargestNum) {
                            LargestNum = userNum;
                        }
                    }
                }
                Sum = userNum + Sum;    
            }
            catch (Exception e) {
                Console.WriteLine(e);
                Console.WriteLine("Please enter a number bewteen 1-100 (inclusive)");
            }
        }
        while(NumList.Count < 5);

        Avg = Sum/5;
        Divide = NumList.Last()/NumList.First();
    }

    public void printNum() {
        Console.WriteLine("Unique Values Entered: ");
        for (int i = 0; i < NumList.Count; i++) {
            Console.WriteLine(NumList[i]);
        }
        Console.WriteLine("Min value entered: {0}\n", SmallestNum);
        Console.WriteLine("Max value entered: {0}\n", LargestNum);
        Console.WriteLine("Average of values entered: {0}\n", Avg);
        Console.WriteLine("The sum of entered numbers is: {0}\n", Sum);
        Console.WriteLine("First value divided by last value: {0}", Divide);
        }
    }

