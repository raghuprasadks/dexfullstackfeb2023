using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBasics
{
    class CoronaTest_19
    {

        List<Corona> CoronaDashBoard = new List<Corona>();

        /**
         * Add Corona object to the corona list
         */
        public void addCorona(Corona corona)
        {
            this.CoronaDashBoard.Add(corona);
        }

        public void listCorona()
        {
            foreach(Corona corona in this.CoronaDashBoard)
            {
                Console.WriteLine(corona.info());
            }
        }

        public void deleteCorona(Corona corona)
        {
            this.CoronaDashBoard.Remove(corona);
        }

        public string maxtotalState()
        {
            int maxtotal = 0;
            String coronamax = "";
            foreach (Corona corona in this.CoronaDashBoard)
            {
                if (corona.Total> maxtotal)
                {
                    maxtotal = corona.Total;
                    coronamax= corona.info();
                }
            }
            return coronamax;
        }

        public void testCorona()
        {

            Console.WriteLine("AddCorona");
            Corona state1 = new Corona(1, "Karnataka", 10000, 1000, 8000, 1000);
            Corona state2 = new Corona(2, "Tamilnadu", 20000, 2000, 16000, 2000);
            Corona state3 = new Corona(3, "Maharashtra", 50000, 10000, 35000, 15000);
            //CoronaTest_19 coronaTest = new CoronaTest_19();
            
            addCorona(state1);
            addCorona(state2);
            addCorona(state3);
            Console.WriteLine("List Corona");
            listCorona();
            Console.WriteLine("Delete Corona");
            Console.WriteLine("Enter state name to delete");
            string sname = Console.ReadLine();

            Corona objtodelete = null;

            foreach (Corona corona in this.CoronaDashBoard)
            {
                if (corona.StateName.Equals(sname))
                {
                    objtodelete = corona;
                    break;
                }

            }
            deleteCorona(objtodelete);
            Console.WriteLine("After delete");
            listCorona();

            Console.WriteLine("State with max total cases");

            String info = maxtotalState();
            Console.WriteLine(info);


        }
    }

    internal class Corona
    {
        public int StateCode { get; set; }

        public string StateName { get; set; }

        public int Total { get; set; }

        public int Active { get; set; }

        public int Recovered { get; set; }

        public int Death { get; set; }


        public Corona(int code,String name,int total,int active,int recoved,int death)
        {
            this.StateCode = code;
            this.StateName = name;
            this.Total = total;
            this.Active = active;
            this.Death = death;
        }

        public string info()
        {
            return "Code : " + this.StateName + " Name : " + this.StateName + "Total : " + this.Total;

        }
    }
}
