using System;
//using NastedIf;

namespace NastedIfDemo
{
    public class Details
    {
        string fname;
        string lname;
        int age;
        double per1;
        double per2;
        double per3;
        double per4;
        char type;

        public void input()
        {
            Console.WriteLine("Enter Your First Name :");
            fname = Console.ReadLine();
            Console.WriteLine("Enter Your Last Name :");
            lname = Console.ReadLine();

            Console.WriteLine("Enter Your SSC Marks(in percent) :");
            per1 = Convert.ToDouble(Console.ReadLine());
        Edu:
            {
                Console.WriteLine("For HSC press: H");
                Console.WriteLine("For Diploma press: D");
                Console.WriteLine("For bot press: B");
                type = Convert.ToChar(Console.ReadLine());
                if (type == 'H')
                {
                    Console.WriteLine("Enter Your HSC Marks(in percent) :");
                    per2 = Convert.ToDouble(Console.ReadLine());
                }
                else if (type == 'D')
                {
                    Console.WriteLine("Enter Your Diploma Marks(in percent) :");
                    per3 = Convert.ToDouble(Console.ReadLine());
                }
                else if (type == 'B')
                {
                    Console.WriteLine("Enter Your HSC Marks(in percent) :");
                    per2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter Your Diploma Marks(in percent) :");
                    per3 = Convert.ToDouble(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Choose Correct option. Thank You!!!");
                    goto Edu;
                }

            }
            Console.WriteLine("Enter Your BE Marks(in percent) :");
            per4 = Convert.ToDouble(Console.ReadLine());
        }
        public void oprtn()
        {
            if (per1 >= 60)
            {
                if (type == 'H' || type == 'D')
                {
                    if (per2 >= 60 || per3 >= 60)
                    {
                        if (per4 >= 60)
                        {
                            Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you are fit in our elegibility criteria, we will contact you. Thank you!!!");
                        }
                        else
                        {
                            Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you does not fit in our elegibility criteria, Fill free to contact us. Thank you!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you does not fit in our elegibility criteria, Fill free to contact us. Thank you!!!");
                    }
                }
                else if (type == 'B')
                {
                    if (per2 >= 60 && per3 >= 60)
                    {
                        if (per4 >= 60)
                        {
                            Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you are fit in our elegibility criteria, we will contact you. Thank you!!!");
                        }
                        else
                        {
                            Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you does not fit in our elegibility criteria, Fill free to contact us. Thank you!!!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you does not fit in our elegibility criteria, Fill free to contact us. Thank you!!!");
                    }

                }

                else return;


            }
            else
            {
                Console.WriteLine("Hello " + fname + " " + lname + ", you are successfully applied in SVAG TECH, We appreciate your efforts, you does not fit in our elegibility criteria, Fill free to contact us. Thank you!!!");
            }
        }
        public void print()
        {
            Console.WriteLine("First Name :" + fname);
            Console.WriteLine("Last Name :" + lname);
            Console.WriteLine("SSC Marks :" + per1);
            if (type == 'H')
            {
                Console.WriteLine("HSC Marks :" + per2);
            }
            else if (type == 'D')
            {
                Console.WriteLine("Diploma Marks :" + per3);
            }
            else if (type == 'B')
            {
                Console.WriteLine("HSC Marks :" + per2);
                Console.WriteLine("Diploma Marks :" + per3);
            }
            Console.WriteLine("BE Marks :" + per1);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Details D = new Details();
            D.input();
            D.print();
            D.oprtn();
        }
    }
}
