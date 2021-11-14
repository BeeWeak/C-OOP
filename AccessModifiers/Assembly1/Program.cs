using System;

namespace Assembly1
{
    class Program
    {
        public class Assembly1BaseClass
        {
            private string privateVariable = "private";
            protected string protectedVariable = "protected";
            internal string internalVariable = "internal";
            protected internal string protectedInternalVaraible = "protected internal";
            public string publicVariable = "public";


            public void testAccess()
            {
                //Accessible
                Console.WriteLine(privateVariable);
                Console.WriteLine(protectedVariable);
                Console.WriteLine(internalVariable);
                Console.WriteLine(protectedInternalVaraible);
                Console.WriteLine(publicVariable);
            }
        }

        public class Assembly1DerivedClass : Assembly1BaseClass
        {
            public void TestAccessInDerivedClass()
            {
                //Not accessible
                //Console.WriteLine(privateVariable);

                //Accessible
                Console.WriteLine(protectedVariable);
                Console.WriteLine(internalVariable);
                Console.WriteLine(protectedInternalVaraible);
                Console.WriteLine(publicVariable);

            }
        }


        public class Assembly1OtherClass
        {
            public void TestAccess()
            {
                Assembly1BaseClass objBase = new Assembly1BaseClass();
                //Not accessible
                //Console.WriteLine(objBase.privateVariable);
                //Console.WriteLine(objBase.protectedVariable);

                //Accessible
                Console.WriteLine(objBase.internalVariable);
                Console.WriteLine(objBase.protectedInternalVaraible);
                Console.WriteLine(objBase.publicVariable);
            }
        }
            static void Main(string[] args)
        {
            //Assembly1BaseClass objBase = new Assembly1BaseClass();
            //objBase.testAccess();

            //Assembly1DerivedClass objDerivedClass = new Assembly1DerivedClass();
            //objDerivedClass.TestAccessInDerivedClass();
            //objDerivedClass.testAccess();



            Assembly1OtherClass objOther = new Assembly1OtherClass();
            objOther.TestAccess();
            Console.ReadKey();
        }
    }
}
