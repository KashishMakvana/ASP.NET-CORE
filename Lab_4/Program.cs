using System.Collections;
using System.Collections.Generic;


//progarm 1 
//namespace Lab_4
//{
//    internal class Progarm
//    {
//        public static void Main(String[] args)
//        {
//            ArrayList studentName = new ArrayList();
//            Console.WriteLine("********** Array List Demo **********");
//            studentName.Add("Mira");
//            studentName.Add("Tina");
//            studentName.Add("Mohan");
//            studentName.Add("Merry");
//            studentName.Add("Bob");
//            studentName.Add("John");
//            studentName.Add("Herry");
//            studentName.Add("Nick");


//            Console.WriteLine("\n Elements Of Array List");
//            foreach (string stu in studentName) {
//                Console.WriteLine("Student Name :" + stu);
//            }


//            studentName.RemoveAt(7);
//            Console.WriteLine("\n Delete Elements with Specific Index in Array List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.Remove("Bob");
//            Console.WriteLine("\n Delete Elements with in Array List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.RemoveRange(3, 2);
//            Console.WriteLine("\n Delete Elements within a given range in Array List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.Clear();
//            Console.WriteLine("\nClear Array List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }
//        }
//    }
//}





//progarm 2
//namespace Lab_4
//{
//    internal class Progarm
//    {
//        public static void Main(String[] args)
//        {
//            List<string> studentName = new List<string>();
//            Console.WriteLine("********** List Demo **********");
//            studentName.Add("Bob");
//            studentName.Add("John");
//            studentName.Add("Herry");
//            studentName.Add("Mohan");
//            studentName.Add("Merry");
//            studentName.Add("Nick");
//            studentName.Add("Mira");
//            studentName.Add("Tina");


//            Console.WriteLine("\n Elements Of List :");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }


//            studentName.RemoveAt(7);
//            Console.WriteLine("\n Delete Elements with Specific Index in List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.Remove("Bob");
//            Console.WriteLine("\n Delete Elements with in List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.RemoveRange(3, 1);
//            Console.WriteLine("\n Delete Elements within a given range in List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }

//            studentName.Clear();
//            Console.WriteLine("\nClear List");
//            foreach (string stu in studentName)
//            {
//                Console.WriteLine("Student Name :" + stu);
//            }
//        }
//    }
//}


//progarm 3:
//namespace Lab_4
//{
//    internal class Progarm
//    {
//        public static void Main(String[] args)
//        {
//            Stack stk = new Stack();
//            Console.WriteLine("********** Stack Demo **********");
//            stk.Push(10);
//            stk.Push(20);
//            stk.Push(30);
//            stk.Push(40);
//            stk.Push(50);
//            stk.Push(60); 
//            stk.Push(70);
//            stk.Push(80);
//            stk.Push(90);
//            stk.Push(100);

//            Console.WriteLine("\n Elements Of Stack Push opration:");
//            foreach (int s in stk)
//            {
//                Console.WriteLine(s);
//            }

//            stk.Pop();
//            stk.Pop();
//            Console.WriteLine("\n Elements Of Stack After Pop opration :");
//            foreach (int s in stk)
//            {
//                Console.WriteLine(s);
//            }

//            Console.WriteLine("\n Top most Elements Of Stack is  : "+ stk.Peek());
//            Console.WriteLine("\n Stack Conatins given element true / false ?  : " + stk.Contains(20));
              //Console.WriteLine("Clear Stack");
//            stk.Clear();
//        }
//    }
//}


//program 4:


namespace Lab_4
{
    internal class Progarm
    {
        public static void Main(String[] args)
        {
            Queue que = new Queue();
            Console.WriteLine("********** Queue Demo **********");
            que.Enqueue(100);
            que.Enqueue(200);
            que.Enqueue(300);
            que.Enqueue(400);
            que.Enqueue(500);
            que.Enqueue(600);
            que.Enqueue(700);
            que.Enqueue(800);
            que.Enqueue(900);
            que.Enqueue(1000);
            Console.WriteLine("\n Elements Of Queue After Enquqeue opration:");
            foreach (int q in que)
            {
                Console.WriteLine(q);
            }

            que.Dequeue();
            que.Dequeue();
            Console.WriteLine("\n Elements Of Queue After Dequqeue opration:");
            foreach (int q in que)
            {
                Console.WriteLine(q);
            }

            Console.WriteLine("\n top most elements of queue is  : " + que.Peek());
            Console.WriteLine("\n queue conatins given element true / false ?  : " + que.Contains(200));
            Console.WriteLine("Clear Queue");

            //stk.Clear();
        }
    }
}
