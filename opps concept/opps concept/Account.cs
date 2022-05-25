using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps_concept
{
    internal abstract class Account
    {
        public abstract void Withdrawl();
        public abstract void Deposits();
    }

    public class SavingAccount : SavingAccountBase Account;
    {
        public void SavingAccounts(string Name)
        {
            Console.WriteLine("Withdraw/Deposit - ");
            string ans = Console.ReadLine();
            if ((ans == "Withdraw") || (ans == "withdraw"))
            {
                SwithdrawORdeposit WOD = new SwithdrawORdeposit();
                WOD.Withdraw();
            }
            else
            {
                SwithdrawORdeposit WOD = new SwithdrawORdeposit();
                WOD.Deposit();
            }
            return;
        }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    public class CurrentAccount : CurrentAccountBase1, ICurrentAccount
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

