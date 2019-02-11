using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester
{
    class Student
    {
        private String CPR;
        private String name;
        private String address;
        private String telno;

        public Student(String CPR, String name, String address, String telno)
        {
            this.CPR = CPR;
            this.name = name;
            this.address = address;
            this.telno = telno;
        }

        public String getCPR()
        {
            return CPR;
        }

        public String getName()
        {
            return name;
        }

        public String getAddress()
        {
            return address;
        }

        public String getTelno()
        {
            return telno;
        }

        public String ToString()
        {
            return "CPR" + CPR + " Name " + name + " address " + address + " telno " + telno;
        }
    }
}

