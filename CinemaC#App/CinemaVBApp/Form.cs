using System;
using System.Diagnostics;

namespace CinemaCSharpApp
{
    public partial class Form
    {
        private static void Cinemas_Load(object sender, EventArgs e)
        {
        }

        public static double getAdultTicketPrice(double adults, bool happyTuesday, bool earlyMovie, bool ThreeD)
        //calculate single ticket price for child based on movie type, day and time
        {
            double MAX_NUM_OF_AGE = 10;
            if (adults >= 0 && adults <= MAX_NUM_OF_AGE)
            {
                double TicketPrice = 0;
                for (int i = 0; i < adults; i += 1)
                {
                    if (i == 0) { Console.WriteLine("adding " + adults + " adult ticket(s)"); }
                    if (happyTuesday)
                    {
                        Console.WriteLine("Tuesday Special Price");
                        TicketPrice += ThreeD ? 15.5 : 13;
                    }
                    else
                    {
                        Console.WriteLine("Regular Day Price");
                        TicketPrice += earlyMovie ? (ThreeD ? 15.5 : 14.5) : (ThreeD ? 18.5 : 17.5);
                        if (earlyMovie) Console.WriteLine("Early Movie Price");
                    }
                }
                return TicketPrice;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("adults", adults, "number of adults should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }
        }

        public static double getChildrenTicketPrice(double children, bool ThreeD)
        //calculate single ticket price for child based on movie type
        {
            double MAX_NUM_OF_AGE = 10;
            if (children >= 0 && children <= MAX_NUM_OF_AGE)
            {
                double TicketPrice = 0;
                for (int i = 0; i < children; i += 1)
                {
                    if (i == 0) { Console.WriteLine("adding " + children + " children ticket(s)"); }
                    TicketPrice += ThreeD ? 13.5 : 12;
                }
                return TicketPrice;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("children", children, "number of children should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }

        }

        public static double getSeniorTicketPrice(double seniors, bool ThreeD)
        //calculate single ticket price for senior based on movie type
        {
            double MAX_NUM_OF_AGE = 10;
            if (seniors >= 0 && seniors <= MAX_NUM_OF_AGE)
            {
                double TicketPrice = 0;
                for (int i = 0; i < seniors; i += 1)
                {
                    if (i == 0) { Console.WriteLine("adding " + seniors + " senior ticket(s)"); }
                    TicketPrice += ThreeD ? 14 : 12.5;
                }
                return TicketPrice;

            }
            else
            {
                throw new System.ArgumentOutOfRangeException("seniors", seniors, "number of seniors should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }
        }

        public static double getStudentTicketPrice(double students, bool ThreeD)
        //calculate single ticket price for child based on movie type, day and time
        {
            double MAX_NUM_OF_AGE = 10;
            if (students >= 0 && students <= MAX_NUM_OF_AGE)
            {
                double TicketPrice = 0;
                for (int i = 0; i < students; i += 1)
                {
                    if (i == 0) { Console.WriteLine("adding " + students + " student ticket(s)"); }
                    TicketPrice += ThreeD ? 15.5 : 14;
                }
                return TicketPrice;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("students", students, "number of students should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }
        }

        public static double getFamilyPassPrice(double adults, double children, bool ThreeD)
        //calculate single ticket price for child based on movie type, day and time
        {
            double MAX_NUM_OF_AGE = 2;
            if (adults >= 0 && adults <= MAX_NUM_OF_AGE)
            {
                if (adults == 1) { MAX_NUM_OF_AGE = 3; }
                double TicketPrice = 0;
                if (children >= 0 && children <= MAX_NUM_OF_AGE)
                {
                    TicketPrice += ThreeD ? 53 : 46;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("children", children, "number of children should be between 0 and " + MAX_NUM_OF_AGE.ToString());
                }
                return TicketPrice;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("adults", adults, "number of adults should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }
        }

        public static double getChickFlickPrice(double adults)
        //calculate single ticket price for child based on movie type, day and time
        {
            double MAX_NUM_OF_AGE = 10;
            if (adults >= 0 && adults <= MAX_NUM_OF_AGE)
            {
                double TicketPrice = 0;
                for (int i = 0; i < adults; i += 1)
                {
                    if (i == 0) { Console.WriteLine("adding " + adults + " chick flick ticket(s)"); }
                    TicketPrice += 21.5;
                }
                return TicketPrice;
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("adults", adults, "number of adults should be between 0 and " + MAX_NUM_OF_AGE.ToString());
            }
        }

        public static double getKidsCarersPrice(double children, string day, bool holiday)
        //calculate single ticket price for child based on movie type, day and time
        {
            double MAX_NUM_OF_AGE = 10;
            if (day == "wednesday" && !holiday)
            {
                if (children >= 0 && children <= MAX_NUM_OF_AGE)
                {
                    double TicketPrice = 0;
                    for (int i = 0; i < children; i += 1)
                    {
                        if (i == 0) { Console.WriteLine("adding " + children + " children and carers ticket(s)"); }
                        TicketPrice += 12;
                    }
                    return TicketPrice;
                }
                else
                {
                    throw new System.ArgumentOutOfRangeException("children", children, "number of children and carers should be between 0 and " + MAX_NUM_OF_AGE.ToString());
                }
            }
            else
            {
                throw new System.ArgumentOutOfRangeException("This offer is only available on wednesdays that are not holidays");
            }

        }



    }
}
