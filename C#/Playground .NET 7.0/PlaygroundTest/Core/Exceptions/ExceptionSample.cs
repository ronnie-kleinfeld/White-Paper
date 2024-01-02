using System.Reflection;
using BE.Exceptions;

namespace PlaygroundTest.Core.Exceptions
{
    public class ExceptionSample
    {
        public static void Main1()
        {
            try
            {
                DoSomething();

            }
            catch (SwitchOutOfRangeException ex) when (ex.InnerException != null)
            {
                Console.WriteLine("check inside exception details with when");
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
