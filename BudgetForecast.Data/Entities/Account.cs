using System.ComponentModel.DataAnnotations;
using BudgetForecast.Data.Interfaces;

namespace BudgetForecast.Data.Models.Entities
{
    public class Account : IAccount, IEntity
    {
         public Account()
        {
          Balance = 0.00m;
          PaycheckContribution = 0.00m;
          SuggestedPaycheckContribution = 0.00m;
          RequiredSavings = 0.00m;
          BalanceLimit = 0.00m;
          BalanceSurplus = 0.00m;
          IsDisposableIncomeAccount = false;
          IsEmergencyFund = false;
          IsMandatory = false;
          ExcludeFromSurplus = false;
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required, StringLength(255)]
        public string Name { get; set; }

        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true)]
        public decimal Balance { get; set; }

        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C0}", ApplyFormatInEditMode = true), Display(Name = "Paycheck Contribution")]
        public decimal PaycheckContribution { get; set; }

        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true), Display(Name = "Suggested Paycheck Contribution")]
        public decimal SuggestedPaycheckContribution { get; set; }

        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true), Display(Name = "Required Savings")]
        public decimal RequiredSavings { get; set; }

        [Required, DataType(DataType.Currency), DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true), Display(Name = "Surplus/Deficit")]
        public decimal BalanceSurplus { get; set; }

        [Required, Display(Name = "Exclude From Surplus")]
        public bool ExcludeFromSurplus { get; set; }

        [Required, Display(Name = "Pool Account")]
        public bool IsDisposableIncomeAccount { get; set; }

        [Required, Display(Name = "Emergency Fund")]
        public bool IsEmergencyFund { get; set; }

        [Required, Display(Name = "Add New Account")]
        public bool IsAddNewAccount { get; set; }
        
        [Required, Display(Name = "Mandatory Account?")]
        public bool IsMandatory { get; set; }

        [Required, Display(Name = "Balance Limit"), DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = true)]
        public decimal BalanceLimit { get; set; }
    }
}
