using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersAndFinalizers_Destructors
{
    internal class Members
    {
        //  1A MEMBER - PRIVATE FIELD
        private string memberName;
        private string jobTitle;
        private int salary;

        // 1B MEMBER - PUBLIC FIELD
        public int age;

        // 2 MEMBER - PROPERTY, which exposes jobTitle safely, not directly thru the string field, now private
        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        // 3A MEMBER - PUBLIC METHOD - can be called from other classes
        public void Introduction(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi, my name is {memberName}, my job is {jobTitle}. I'm {age}");
            }
        }

        // 3B creating a PRIVATE METHOD - to only share salary info with isFriend
        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // 4 MEMBER - CONSTRUCTOR
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created"); //-- what the fuck for??
        }

        // 5 MEMBER: FINALIZER-DESTRUCTOR #1 per class #can't be inherited or called
        // only creating one if it has a purpose
        ~Members()
        {
            //  FOR CLEANUP STATEMENTS, for when the object runs out of scope
            Console.WriteLine("Deconstruction of Members object");
        }

    }
}
