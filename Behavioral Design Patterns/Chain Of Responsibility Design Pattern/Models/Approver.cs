
using Chain_Of_Responsibility_Design_Pattern.Interfaces;

namespace Chain_Of_Responsibility_Design_Pattern.Models;

public abstract class Approver : IApprover
{
    public IApprover _approver;

    public abstract void Approve(PurchaseItem item);

    public void SetNextApprover(IApprover approver)
    {
        _approver = approver;   
    }
}
