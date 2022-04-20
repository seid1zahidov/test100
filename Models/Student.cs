using System;
using System.Collections.Generic;
using System.Text;

namespace Home_taskk.Models
{
    class Student
    {
        public static int no;

        public string _FullName;
        public string _GroupNo;

        public string Fullname 
        {
            get => _FullName;
            set 
            {
                while (Fullname(value))
                {
                    Console.WriteLine("daxil edin");
                    value = Console.ReadLine();

                }
                return _FullName;
            
            
            } 
            
        
        }

        static bool CheckGroupNo( string GroupNo) 
        {
            bool cehckupper = false;
            bool cehckisdigit1 = false;
            bool checkisdigit2 = false;
            bool chechdigit3 = false;

            foreach (char item in GroupNo)
            {
                if (char.IsUpper(GroupNo[0]))
                {
                    cehckupper = true;
                }
                else if (char.IsDigit(GroupNo[1]))
                {
                    cehckisdigit1 = false;
                }
                else if (char.IsDigit(GroupNo[2]))
                {
                    checkisdigit2 = false;
                }
                else if (char.IsDigit(GroupNo[3]))
                {
                    chechdigit3 = false;
                }
                if (cehckupper && cehckisdigit1 && checkisdigit2 && chechdigit3)
                {
                    return true;
                }


            }
            if (cehckupper || cehckisdigit1 || checkisdigit2 || chechdigit3)
            {
                return false;
            }
            return false;
        }

       

        //public int Age { get; set; }

    }
    
}
