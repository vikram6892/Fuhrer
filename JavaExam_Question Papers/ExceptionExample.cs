using System;

namespace ExceptionExample
{
    class BlueException : Exception {
    }

    class GreenException : BlueException {
    }

    class RedException : BlueException{
    }

    public class CatchAndPrint
    {
        public void foo(int num) {
            Console.WriteLine("num : " + num);

            if (num == 0) {
                throw new BlueException();
            }
            if (num == 1) {
                throw new RedException();
            }
            if (num == 2) {
                int res = 10 / (num - 2);
            }
            if (num == 3) {
                throw new RedException();
            }
            if (num == 4) {
                int[] numbers = new int[4];
                numbers[num] = num;
            }
        }

        public void bar(){
            for (int i = 0; i < 5; i++) {
                try {
                    foo(i);
                }
                catch (DivideByZeroException divideByZeroException) {
                    Console.WriteLine(divideByZeroException.Message);
                }
                catch (IndexOutOfRangeException indexException)
                {
                    Console.WriteLine(indexException.Message);
                }
                catch(RedException redException) {
                    Console.WriteLine(redException.Message);
                }
                catch(GreenException greenException) {
                    Console.WriteLine(greenException.Message);
                }
                catch (BlueException blueException)  {
                    Console.WriteLine(blueException.Message);
                }
            }
        }


        static void Main(string[] args)
        {
            CatchAndPrint cap = new CatchAndPrint();
            cap.bar();
        }
    }
}
