using ApprovalCommon;

namespace Approval
{
  interface IExpenseHandler
  {
    ApprovalResponse Approve(IExpenseReport expenseReport);
    void RegisterNext(IExpenseHandler next);
  }
}
