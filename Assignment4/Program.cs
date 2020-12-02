using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
  //  Create a Generic Stack class with the following metods, Push(), Pop(), Sort(), Reverse(), Search() and Display(). 
  //  Push() method should add new record in Generic Stack, Pop() method should remove top record from statck.
  //The Sort() and Reverse() methods should sort and reverse the stach respectively.
  //  If the Generic Stack contains CLR objects(e.g.Employee class), 
  //  then the sort and reverse should take place based on EmpNo.The search method must search record 
  //  based on criteria.The Display() method must list all elements from Stack.
   public class Program
    {
        static void Main(string[] args)
        {
            //Stack<int> st = new Stack<int>();
            ////PUSH
            //st.Push(11);
            //st.Push(22);
            //st.Push(33);
            //st.Push(44);
            //st.Push(55);

            //foreach (int item in st)
            //{
            //    Console.WriteLine(item);
            //}

            ////POP

            //Console.WriteLine("value is deleted:=" + st.Pop());

            ////reverse
            //Console.WriteLine("reverse stack is:=");
            //st.Reverse();
         

            //foreach (int item in st)
            //{
            //    Console.WriteLine(item);
            //}

            ////search
            //Console.WriteLine("value is present:=" + st.Contains(11));


            Employee emp1 = new Employee()
            {
                ID = 101,
                EmpName = "Prajkta",
                Salary = 30000
            };

            Employee emp2 = new Employee()
            {
                ID = 102,
                EmpName = "Prachi",
                Salary = 40000
            };

            Employee emp3 = new Employee()
            {
                ID = 103,
                EmpName = "Jay",
                Salary = 50000
            };

            Stack<Employee> emp = new Stack<Employee>();
            emp.Push(emp1);
            emp.Push(emp2);
            emp.Push(emp3);

            foreach (var item in emp)
            {
                Console.WriteLine("ID:=" +item.ID);
                Console.WriteLine("Name:=" + item.EmpName);
                Console.WriteLine("Salary:=" + item.Salary);
           
                
            }


            if(emp.Contains(emp3))
            {
                Console.WriteLine("record is in the stack");
            }
            else
            {
                Console.WriteLine("record is not in stack");
            }

           
           

        }
    }
}
