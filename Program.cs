//using System;
////task1.verilmis n ededinin 3-e ve 7-e bolunub bolunmemesi
//namespace methods_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Divided(21);

//        }


//        static void Divided(int n)
//        {
//            if (n % 3 == 0 && n % 7 == 0)
//            {
//                Console.WriteLine("Divided");
//            }
//            else
//            {
//                Console.WriteLine("Not Divided");
//            }
//        }

//    }
//}










   
    
////task2.verilmis n ve m her ikisi cutdurse cemini tapmaq
//namespace methods_1
//{
//    class Program
//    {
    
//        static void Main(string[] args)
//        {
//            SumEvenNumbers(6, 8);
//        }


//        static void SumEvenNumbers(int n,int m)
//        { 
//           int sum = 0;


//           if (n%2==0 && m%2 ==0)
       
//           {
//              sum = n + m;

//            Console.WriteLine(sum ); 
//        }
//    }
//}










//    //task 3.verilmis n ve m arasindaki tek ededlerin cemini tapmaq

//    namespace methods_1
//    {
//        class Program
//        {
//            static void Main(string[] args)
//            {
//                SumOddNumbers(3,8);
//            }



//            static void SumOddNumbers(int n, int m)
//            { 
//                    int sum = 0;

//                 for (int i = n; i<=m; i++)
//			     {
//                   if (i % 2 == 1)
//                    {
//                        sum = sum + 1;

//                    }
//                 }
//                Console.WriteLine(sum);
//            }

//			}

              
//}
//}






////task 4.verilmis arrayin icindeki tek ededlerin cemini tapmaq


//namespace methods_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        { 
//            int[] arr = { 2, 3,4, 5, 7, 9 };
//            SumOddNumbersArr(arr) ;

//        }


//        static void SumOddNumbersArr(int[] odd)
//        { 
             
//              int sum = 0;
//            for (int i = 0; i < odd.Length; i++)
//            {
//                sum = sum + 1;
//            }

//                 {               
//    }              Console.WriteLine(sum);
//        }        }
//}



////task 5.verilmis arrayin icindeki cut ededlerin sayini tapmaq
//namespace methods_1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int[] arr = { 1, 2, 3, 4, 5, 6 };

//            CountEvenNumbersArr(arr);
//        }


//        static void CountEvenNumbersArr(int[] even)

//        {
//            int count = 0;

//            for (int i = 0; i < even.Length; i++)
//            {
//                if (i % 2 == 0)
//                {
//                    count++;
//                }

//            }
//            Console.WriteLine(count);
//        }
                   
            
                   
//}   }



////task 6. verilmis n tam ededlerin sade ve ya murekkeb oldugunu tapmaq
//namespace methods_1
//{
//    class Program
//    {
//        static void Main(string[] args)

//        {
//            PrimeCompositeNumber(7);
//        }


//        static void PrimeCompositeNumber(int n)
//        {
//            int m;
//            int count = 0;
//            m = n / 2;
//            for (int i = 2; i <= m; i++)
//            {
//                if (n % i == 0)
//                {
//                    Console.WriteLine("Composite");
//                    count = 1;
//                    break;
//                }
//                if (count == 0)
//                {
//                    Console.WriteLine("Prime");
//                }
//            }
//        }
//    }

//}
     