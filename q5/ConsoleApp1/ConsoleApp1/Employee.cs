using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Employee
    {
        private int empID;
        private string empName;
        private string empDesignation;

        public void setEmpID(int IDFromUser)
        {
            empID = IDFromUser;
        }
        public int getEmpID()
        {
            return empID;
        }

        public void setEmpName(string nameFromUser)
        {
            empName = nameFromUser;
        }
        public string getName()
        {
            return empName;
        }


        public void setEmpDesg(string desgFromUser)
        {
            empDesignation = desgFromUser;
        }
        public string getEmpDesg()
        {
            return empDesignation;
        }

    }
}
