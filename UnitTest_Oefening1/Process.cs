using System;
using System.Xml.Linq;

namespace UnitTest_Oefeningen
{
    public class Process
    {
        public string? Name { get; set; }
        public List<string>NameList {  get; set; }
        public Process()
        {
            NameList = new List<string>();
        }
        public string SayHallo(string naam)
        {
            return "Hallo, " + naam +"!";
        }
        public int GetMax(int num1, int num2) 
        {
            if (num1 > num2)
            {
                return num1;
            }
            return num2;

           
        }
        public bool GetMaxvalue(int num1, int num2)
        {
            int max = 0;
            if (num1 > num2)
            { 
                max = num1;
                return true;
            }
            else if (num1 < num2) 
            {
                max = num2;
                return true;
            }
            return false;


        }

        public void GetNameVoid(string naam)
        {
            Name = naam;
           
        }
        public void GetStringList(string naam)
        {
            NameList.Add(naam);
        }


        public int ReverseNumber(int num)
        {
            int reversed = 0;
            int reminder = 0;
          
            while (num != 0)
            {
                reminder = num % 10;
                reversed = reversed * 10 + reminder;
                num /= 10;
            }
            return reversed;
        }
        public bool PalindromString(string naam)
        {
            string reverse=new string(naam.ToCharArray().Reverse().ToArray());
            if (reverse.Equals(naam,StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            return false;
        }
        public string StringGreeting(DateTime datetime)
        {
           var time = datetime.Hour;
            if (time>=06 &&time<12)
            {
                return "Good Morning!";
            }
            else if (time >= 12 && time < 18)
            {
                return "Good Day!";
            }
            else if (time >= 18 && time < 22)
            {
                return "Good Evening!";
            }
            return "Good Night!";
        }

        public int Count_HoeveelKeer_InArray(int[] arry)
        {
            int count = 0;
            for (int i = 0; i < arry.Length; i++)
            { 
                for (int j = i+1; j < arry.Length; j++)
                {
                    if (arry[i] == arry[j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public string Read_Last_Number(int input)
        {
            string num = "";
            int lastnumber = input % 10;
            switch (lastnumber) 
            {
                
                case 1:
                    num= "One";
                    break;
                    
                case 2:
                    num= "Two";
                    break;
                    
                case 3:
                    num= "Three";
                    break;
                case 4:
                    num= "Four";
                    break;
                 case 5:
                    num= "Five";
                    break;
                 case 6:
                    num= "Six";
                    break;
                 case 7:
                    num= "Seven";
                    break;
                 case 8:
                    num= "Eight";
                    break;
                 case 9:
                    num= "Nine";
                    break;
                default:
                    num= "Zero";
                    break;

            }
            return num; 
        }
    }
}