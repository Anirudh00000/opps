namespace opps_concept
{
    public class CurrentAccountBase1
    {
        public override void Deposits()
        {
            Console.WriteLine("Current Rupees in your currentacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to Deposit - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Total Balance in your account is - {CurrentRupees + ans1}");
            return;

        }
        public override void Withdrawl()
        {
            Console.WriteLine("Current Rupees in your currentacc.- ");
            int CurrentRupees = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Rupees u want to withdraw - ");
            int ans1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Payment Done, Left Balance in your account is - {CurrentRupees - ans1}");
            return;
        }
    }
}