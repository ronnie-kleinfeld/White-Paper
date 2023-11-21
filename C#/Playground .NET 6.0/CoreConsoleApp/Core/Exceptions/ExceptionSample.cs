using System.Reflection;
using BE.Exceptions;

namespace CoreConsoleApp.Core.Exceptions
{
    public class ExceptionSample
    {
        public static void Main()
        {
            try
            {
                DoSomething();

            }
            catch (SwitchOutOfRangeException ex)
            {
                Console.WriteLine("Exception " + ex.ToString());
            }
            catch
            {

            }
            finally
            {
                // close connections..
            }
        }

        private static void DoSomething()
        {
            throw new SwitchOutOfRangeException(MethodBase.GetCurrentMethod(), 15);
        }
    }
}