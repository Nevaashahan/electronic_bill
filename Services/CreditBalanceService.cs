using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;

namespace BillingSystem.Services
{
    public class CreditBalanceService
    {
        private DbContext _db;
        public CreditBalanceService(DbContext context)
        {
            _db = context;
        }

        public void AddCreditBalance(String NIC , decimal balance)
        {
            var creditBalance = new Models.CreditBalance
            {
                NIC = NIC,
                Balance = balance
            };
            _db.Add(creditBalance);
            _db.SaveChanges();
        }

        public void UpdateCreditBalance(String NIC, decimal balance)
        {
            var creditBalance = _db.Set<Models.CreditBalance>().Find(NIC);
            creditBalance.Balance = balance;
            _db.SaveChanges();
        }

        public void DeleteCreditBalance(String NIC)
        {
            var creditBalance = _db.Set<Models.CreditBalance>().Find(NIC);
            _db.Remove(creditBalance);
        }

        public decimal GetCreditBalance(String NIC)
        {
            var creditBalance = _db.Set<Models.CreditBalance>().Find(NIC);
            return creditBalance.Balance;
        }
    }
}
