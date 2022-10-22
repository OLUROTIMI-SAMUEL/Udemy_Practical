//See https://aka.ms/new-console-template for more information
namespace UdemyWork
{
    class Program
    {
       

        static void Main(string[] args)
        {
            MoreWork();
            //Calculator();
            //LetContinueWorking();
            string bestFriend1 = "John";
            string bestFriend2 = "Timileyin";
            string bestFriend3 = "Peter";
            string bestFriend4 = "paul";

            greetingBestFriend(bestFriend1, bestFriend2, bestFriend3, bestFriend4);


            writeSomething();
            writeSomethingSpecific("I love it when i read the open heavens every morning");
            GreetFriend("Hi Frank, my friend");


            Console.WriteLine("Hello, World!");
            // defing few variable
            int age = 32;
            string name = "Samuel";
            string food = "rice";
            //STRING CONCATENATION
            Console.WriteLine("Sting Concatenation");
            Console.WriteLine("MY NAME IS " + name + ", I AM " + age + " YEAR OLD. ");

            //STRING FORMATTING
            //STRING FORMATTING USER INDEX
            Console.WriteLine("string formatting");
            Console.WriteLine("my name is {0} , i am {1} years of age and i actually don't like {2}", name, age, food);

            //STRING INTERPOLATION
            //STRING INTERPOLATION USES DOLLAR $ AT THE START WHICH WILL ALLOW US TO WRITE OUR VARIABLES LIKE THIS {VARIABLE NAME}
            Console.WriteLine("STRING INTERPOLATION");
            Console.WriteLine($"MY NAME IS {name} I AM {age} and I dont really like {food}");

            //VERBATIM STRINGS
            //VERBATIMS STRING START WITH @ AND TELLS THE COMPILAR TO TAKE THE STRING 
            //AND IGNORE ANY SPACE AND ESCAPE CHARACTER LIKE \n
            //  NOTE THE SYMBOL \n is to create a new line.
            Console.WriteLine("VERBATIM STRING");
            Console.WriteLine(@"lorem ipim ixcnidfsdnguisfugiodjd firkfi n g svifi eiferiei rjrtgopvoweodsfo rmrimf wre4tefo rijeiqaij  etjeorwejwe rrjaej " +
                "jigegj[pgjwegoj 3jtwpo gof pjerpjerp[ofjefiosgiojweoidfnsn vdfbksdmd sf;rfsdv smfrmf vmdfamwemp'sKas sdm'egmawlms'mskdp'f wefasmqwef " +
                "efwe[wfjowegkowef esdosdosejoj iwfijefgiegisegjijasf idiseriw[p awiw3rioawfpii iwfjrgioqwfjsdksfij dj gdivwgoh dfusrnasjnsdbjnl ]" +
                "dghdfiefioegn dgjdgidgisdgo ndvsdsdj njrsdnjodfnjsdvnjnjkl jdngjrnjsdfnjnsdn jnsdvjnfbjnfbjn jvjegnjjsdfnjn jdgnjndgjndfb jnegjknfkl " +
                "vrgnsn dfngnsdvnjk  jfjfjsfjejkl jkdnrjdfjerl jdn gfgsaFIWEGSN V;IEGJWSCSD;IJ SV;DGNSDBNRGDVNS; KFKBFB;EKFZOVJ;K DNWEISDVN WEGIDJ ASJQ RJSP'OWJ[S " +
                "IWEFGISDPOEJ  G;RKLGSPSVDJI JIDGFIKNSKNDVJSEFASNERIN IJETISDIERIW  IJIOAWIOJWT4C  ONIOG;IOC II2    JSGJPWEJP IJPJPOWER I IJIJR2IIJ V IJ2AEN VN" +
                "I   FEI RIOHRFIOHWOIHWRIO IOH IIORWIO IDIOR1IOWEPIWJC  IJ3IRJ IJI2J2ERI  WIJRIJ WRJ3RWP[J FJR 23PJR VOVFOQEJO OJ2RPO VOWJFWJPWRJ " +
                "I3 3TE  JEJFIREJWI IJEGIJEGJE;QWSIJ VJEFJEFJ; FJEGJ KEJ;J EIJDIGJWFKN NIRG;E;I J ");

            //with verbatim string even escape character won't work
            Console.WriteLine(@" TIMILEYIN YOU HAVE \n no space in your \n work.");

            string firstName = "David";
            string lastName = "Anuoluwapo";
            string fullName = string.Concat("", firstName, lastName, "");
            Console.WriteLine(firstName.Substring(2));

            //string myname;
            //Console.WriteLine("PLEASE ENTER YOUR NAME");
            //myname = Console.ReadLine();
            //string myNameUpperCase = String.Format("Upper case :{0}", myname.ToUpper());
            //Console.WriteLine(myNameUpperCase);


            int num1 = 5;
            int num2 = 0;
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)

            {

                Console.WriteLine("Cant divide by Zero!");
            }

            int number1 = 5;
            int number2 = 3;
            int num3;

            num3 = -number1;
            Console.WriteLine("num3 is {0}", num3);
            Console.ReadKey();



        }


        public static void writeSomething()
        {

            Console.WriteLine("I am actually called from a method");

        }
        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);

        }
        public static void GreetFriend(string bestFriend)
        {
            Console.WriteLine(bestFriend);
        }
        public static void greetingBestFriend(string bestfriend1, string bestfriend2, string bestfriend3, string bestfriend4)
        {
            Console.WriteLine(" Hi " + bestfriend1 + "you know you are more that just a friend");
            Console.WriteLine(" Hi " + bestfriend2 + "you know you are more that just a friend");
            Console.WriteLine(" Hi " + bestfriend3 + "you know you are more that just a friend");
            Console.WriteLine(" Hi " + bestfriend4 + "you know you are more that just a friend");

        }
        //user input in general
        public static void LetContinueWorking()
        {
            
            string input = Console.ReadLine();
            Console.WriteLine(input);
        }
        
        public static void Calculator()
        {
            Console.WriteLine("Please enter your first number");
            string number1input = Console.ReadLine();
            Console.WriteLine("Please enter your first number");
            string number2input = Console.ReadLine();
          
            Console.WriteLine("total result is");
            int num1 = int.Parse(number1input);
            int num2 = int.Parse(number2input);

            int result = num1 + num2;

            Console.WriteLine(result); 

        }
        public static void MoreWork()
        {
            Console.WriteLine("\n\n-----------Please Enter A Number----------\n\n");
            string userInput = Console.ReadLine();
            try
            {
                int userInputAsInt = int.Parse(userInput);
            }
            catch (FormatException)
            {

                Console.WriteLine("\nFormat exception, please enter the correct type next time.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("General Exception");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException, the value was empty(null)");
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();
        }
    }

}
















