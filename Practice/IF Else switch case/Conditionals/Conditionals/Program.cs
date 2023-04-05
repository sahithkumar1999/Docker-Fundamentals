
/*
namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 10;

            if (hour >0 && hour < 12)
            {
                Console.WriteLine("It's morning");
            }
            else if (hour >=12 && hour<18)
            {
                Console.WriteLine("It's afternoon");
            }
            else
            {
                Console.WriteLine("It's evening");
            }
        }
    }
}
*/


//namespace Conditionals
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool isGoldCstomer = true;

//            //float price;
//            //if(isGoldCstomer)
//            //{
//            //    price = 19.95f;
//            //}
//            //else                                          // control +k+c --> to comment multiple lines
//            //{
//            //    price = 29.95f;

//            //}

//            // the above if else can be written as follows
//            float price = (isGoldCstomer) ? 19.95f : 29.95f;

//            Console.WriteLine(price);
//        }
//    }
//}


// switch case

namespace Conditionals
{
   
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Autumn;

            switch(season)
            {
                case Season.Autumn:
                    Console.WriteLine("Its autumn and a beautiful season.");
                    break;

                case Season.Summer: 
                    Console.WriteLine("It's perfect time to go to beach");
                    break;  

                default: Console.WriteLine("I don't understand that season!");
                    break;


            }

        }
    }
}
