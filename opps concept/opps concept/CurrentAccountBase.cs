namespace opps_concept
{
    public class CurrentAccountBase
    {
        public void CurrentAccounts(string Name)
        {
            Console.WriteLine("Withdraw/Deposit - ");
            string ans = Console.ReadLine();
            if ((ans == "Withdraw") || (ans == "withdraw"))
            {
                CwithdrawORdeposit WOD = new CwithdrawORdeposit();
                WOD.Withdraw();
            }
            else
            {
                CwithdrawORdeposit WOD = new CwithdrawORdeposit();
                WOD.Deposit();
            }
            return;
        }
    }
}