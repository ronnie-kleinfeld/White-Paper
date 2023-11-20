namespace CoreConsoleApp.Core.Delegates
{
    public class ActionOrFunc
    {
        public void Show()
        {
            Func<int, int, bool> theDel1 = new Func<int, int, bool>(AreBothEven);
            var theDel2 = new Func<int, int, bool>(AreBothEven);
            var theDel3 = new Func<int, int, bool>((first, second) => first % 2 == 0 && second % 2 == 0);

            Console.WriteLine(theDel1.Invoke(6, 8)); // use invoke
            Console.WriteLine(theDel1(6, 8)); // just call
        }

        public bool AreBothEven(int first, int second)
        {
            return first % 2 == 0 && second % 2 == 0;
        }
    }
}